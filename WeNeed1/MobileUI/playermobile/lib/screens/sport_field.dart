import 'dart:convert';

import 'package:flutter/material.dart';
import 'package:playermobile/screens/sport_field_details.dart';
import '../models/sport_field.dart';
import '../providers/sport_field_provider.dart';
import '../widgets/master_screen.dart';

class SportsFieldsScreen extends StatefulWidget {
  final int sportsCenterId;
  const SportsFieldsScreen({super.key, required this.sportsCenterId});

  @override
  State<SportsFieldsScreen> createState() => _SportsFieldsScreenState();
}

class _SportsFieldsScreenState extends State<SportsFieldsScreen> {
  final SportFieldProvider _sportFieldProvider = SportFieldProvider();
  final TextEditingController _searchController = TextEditingController();

  List<SportField> _fields = [];
  bool _isLoading = true;

  @override
  void initState() {
    super.initState();
    _loadFields();
  }

  Future<void> _loadFields() async {
    setState(() => _isLoading = true);
    try {
      final response = await _sportFieldProvider.get(filter: {
        "sportsCenterId": widget.sportsCenterId,
        "name": _searchController.text,
      });

      setState(() {
        _fields = response.result;
      });
    } catch (e) {
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(content: Text("Greška pri učitavanju terena: $e")),
      );
    } finally {
      setState(() => _isLoading = false);
    }
  }

  @override
  Widget build(BuildContext context) {
    return MobileMasterScreenWidget(
      title: "Tereni",
      child: Padding(
        padding: const EdgeInsets.all(16),
        child: Column(
          children: [
            Row(
              children: [
                Expanded(
                  child: TextField(
                    controller: _searchController,
                    decoration: const InputDecoration(labelText: "Naziv"),
                  ),
                ),
                const SizedBox(width: 8),
                ElevatedButton(
                  onPressed: _loadFields,
                  child: const Text("Pretraži"),
                ),
              ],
            ),
            const SizedBox(height: 16),
            _isLoading
                ? const Expanded(child: Center(child: CircularProgressIndicator()))
                : Expanded(
              child: _fields.isEmpty
                  ? const Center(child: Text("Nema terena."))
                  : ListView.builder(
                itemCount: _fields.length,
                itemBuilder: (context, index) {
                  final field = _fields[index];
                  return Card(
                    margin: const EdgeInsets.symmetric(vertical: 8),
                    child: Padding(
                      padding: const EdgeInsets.all(12.0),
                      child: Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: [
                          if (field.image != null)
                            ClipRRect(
                              borderRadius: BorderRadius.circular(8),
                              child: Image.memory(
                                base64Decode(field.image!),
                                width: double.infinity,
                                height: 160,
                                fit: BoxFit.cover,
                              ),
                            )
                          else
                            Container(
                              width: double.infinity,
                              height: 160,
                              decoration: BoxDecoration(
                                color: Colors.grey[300],
                                borderRadius: BorderRadius.circular(8),
                              ),
                              child: const Icon(Icons.image_not_supported, size: 60),
                            ),
                          const SizedBox(height: 12),
                          Text(
                            field.name ?? "N/A",
                            style: const TextStyle(fontSize: 18, fontWeight: FontWeight.bold),
                          ),
                          const SizedBox(height: 4),
                          Text("Sport: ${field.sportType ?? "-"}"),
                          const SizedBox(height: 8),
                          Align(
                            alignment: Alignment.centerRight,
                            child: IconButton(
                              icon: const Icon(Icons.info_outline),
                              onPressed: () {
                                Navigator.push(
                                  context,
                                  MaterialPageRoute(
                                    builder: (context) => SportFieldDetailsScreen(
                                      sportFieldId: field.id!,
                                    ),
                                  ),
                                );
                              },
                            ),
                          )
                        ],
                      ),
                    ),
                  );
                },
              ),
            ),
          ],
        ),
      ),
    );
  }


}
