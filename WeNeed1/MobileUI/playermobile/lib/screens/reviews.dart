import 'package:flutter/material.dart';
import '../models/review.dart';
import '../providers/review_provider.dart';
import '../widgets/custom_snackbar.dart';
import '../widgets/master_screen.dart';

class ReviewScreen extends StatefulWidget {
  final int sportsCenterId;
  const ReviewScreen({super.key, required this.sportsCenterId});

  @override
  State<ReviewScreen> createState() => _ReviewScreenState();
}

class _ReviewScreenState extends State<ReviewScreen> {
  final ReviewProvider _reviewProvider = ReviewProvider();

  List<Review> _reviews = [];
  bool _isLoading = true;

  final TextEditingController _contentController = TextEditingController();
  double _rating = 3.0;

  @override
  void initState() {
    super.initState();
    _loadReviews();
  }

  Future<void> _loadReviews() async {
    setState(() => _isLoading = true);
    try {
      final response = await _reviewProvider.get(filter:{"sportsCenterId": widget.sportsCenterId});
      setState(() {
        _reviews = response.result;
      });
    } catch (e) {
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(content: Text("Greška pri učitavanju recenzija: $e")),
      );
    } finally {
      setState(() => _isLoading = false);
    }
  }

  Future<void> _addReview() async {
    final content = _contentController.text.trim();
    if (content.isEmpty) {
      CustomSnackbar.show(
        context,
        "Molimo unesite sadržaj recenzije.",
        SnackbarType.error,
      );
      return;
    }

    final newReview = Review(content: content, rating: _rating);

    try {
      await _reviewProvider.insertToSportsCenter(widget.sportsCenterId, newReview);
      _contentController.clear();
      _rating = 3.0;
      await _loadReviews();
      CustomSnackbar.show(
        context,
        "Recenzija je uspješno dodana.",
        SnackbarType.success,
      );
    } catch (e) {
      print(e);
      CustomSnackbar.show(
        context,
        "Greška pri dodavanju recenzije: $e",
        SnackbarType.error,
      );
    }
  }

  @override
  Widget build(BuildContext context) {
    return MobileMasterScreenWidget(
      title: "Recenzije",
      child: Padding(
        padding: const EdgeInsets.all(16),
        child: Column(
          children: [
            if (_isLoading)
              const Center(child: CircularProgressIndicator())
            else if (_reviews.isEmpty)
              const Text("Nema recenzija za ovaj sportski centar.")
            else
              Expanded(
                child: ListView.builder(
                  itemCount: _reviews.length,
                  itemBuilder: (context, index) {
                    final r = _reviews[index];
                    return Card(
                      margin: const EdgeInsets.symmetric(vertical: 8),
                      child: ListTile(
                        title: Text(r.content ?? ""),
                        subtitle: Row(
                          children: [
                            ...List.generate(
                              5,
                                  (i) => Icon(
                                i < (r.rating?.round() ?? 0)
                                    ? Icons.star
                                    : Icons.star_border,
                                color: Colors.amber,
                                size: 20,
                              ),
                            ),
                            const SizedBox(width: 8),
                            Text(r.created != null
                                ? "${r.created!.toLocal()}".split(' ')[0]
                                : ""),
                          ],
                        ),
                      ),
                    );
                  },
                ),
              ),
            const Divider(),
            TextField(
              controller: _contentController,
              maxLines: 3,
              decoration: const InputDecoration(
                labelText: "Nova recenzija",
                border: OutlineInputBorder(),
              ),
            ),
            const SizedBox(height: 8),
            Row(
              children: [
                const Text("Ocjena: "),
                Expanded(
                  child: Slider(
                    min: 1,
                    max: 5,
                    divisions: 4,
                    value: _rating,
                    label: _rating.toString(),
                    onChanged: (value) {
                      setState(() {
                        _rating = value;
                      });
                    },
                  ),
                ),
                Text(_rating.toString()),
              ],
            ),
            ElevatedButton(
              onPressed: _addReview,
              child: const Text("Dodaj recenziju"),
            )
          ],
        ),
      ),
    );
  }

}
