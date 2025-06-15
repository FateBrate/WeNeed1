import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:playermobile/screens/reviews.dart';
import 'package:playermobile/screens/sport_field.dart';
import '../models/sport_center.dart';
import '../providers/sport_center_provider.dart';
import '../widgets/master_screen.dart';

class SportCenterDetailsScreen extends StatefulWidget {
  final int sportsCenterId;

  const SportCenterDetailsScreen({super.key, required this.sportsCenterId});

  @override
  State<SportCenterDetailsScreen> createState() => _SportCenterDetailsScreenState();
}

class _SportCenterDetailsScreenState extends State<SportCenterDetailsScreen> {
  SportsCenter? _center;
  bool _isLoading = true;

  @override
  void initState() {
    super.initState();
    _loadDetails();
  }

  Future<void> _loadDetails() async {
    try {
      final data = await SportsCenterProvider().getById(widget.sportsCenterId);
      setState(() {
        _center = data;
        _isLoading = false;
      });
    } catch (e) {
      setState(() => _isLoading = false);

      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
          content: Text('Greška pri učitavanju podataka: ${e.toString()}'),
          backgroundColor: Colors.red,
        ),
      );
    }
  }

  @override
  Widget build(BuildContext context) {
    return MobileMasterScreenWidget(
      title: "Detalji centra",
      child: _isLoading || _center == null
          ? const Center(child: CircularProgressIndicator())
          : SingleChildScrollView(
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            if (_center!.image != null)
              ClipRRect(
                borderRadius: BorderRadius.circular(10),
                child: Image.memory(
                  base64Decode(_center!.image!),
                  width: double.infinity,
                  height: 200,
                  fit: BoxFit.cover,
                ),
              ),
            const SizedBox(height: 12),
            Text(
              _center!.name ?? "N/A",
              style: const TextStyle(fontSize: 24, fontWeight: FontWeight.bold),
            ),
            const SizedBox(height: 8),
            Row(
              children: [
                const Icon(Icons.access_time),
                const SizedBox(width: 5),
                Text("${_center!.startTime} - ${_center!.endTime}"),
              ],
            ),
            const SizedBox(height: 16),
            Card(
              shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(10)),
              elevation: 2,
              child: Padding(
                padding: const EdgeInsets.all(16),
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    const Text("Adresa:", style: TextStyle(fontWeight: FontWeight.bold)),
                    Text(_center!.address ?? "-"),
                    const SizedBox(height: 12),
                    const Text("Opis:", style: TextStyle(fontWeight: FontWeight.bold)),
                    Text(_center!.description ?? "-"),
                  ],
                ),
              ),
            ),
            const SizedBox(height: 16),
            Row(
              mainAxisAlignment: MainAxisAlignment.spaceEvenly,
              children: [
                ElevatedButton.icon(
                  icon: const Icon(Icons.rate_review),
                  label: const Text("Recenzije"),
                  onPressed: () {
                    Navigator.push(
                      context,
                      MaterialPageRoute(
                        builder: (context) => ReviewScreen(sportsCenterId: widget.sportsCenterId),
                      ),
                    );
                  },
                ),
                ElevatedButton.icon(
                  icon: const Icon(Icons.sports_soccer),
                  label: const Text("Tereni"),
                  onPressed: () {
                    Navigator.push(
                      context,
                      MaterialPageRoute(
                        builder: (context) => SportsFieldsScreen(sportsCenterId: widget.sportsCenterId),
                      ),
                    );
                  },
                ),
              ],
            ),
            const SizedBox(height: 20),
          ],
        ),
      ),
    );
  }
}
