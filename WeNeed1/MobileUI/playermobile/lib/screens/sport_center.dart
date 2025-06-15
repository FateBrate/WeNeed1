import 'dart:convert';

import 'package:flutter/material.dart';
import 'package:playermobile/screens/sport_center_details.dart';
import '../models/sport_center.dart';
import '../providers/sport_center_provider.dart';
import '../widgets/master_screen.dart';


class SportsCentersScreen extends StatefulWidget {
  const SportsCentersScreen({super.key});

  @override
  State<SportsCentersScreen> createState() => _SportsCentersScreenState();
}

class _SportsCentersScreenState extends State<SportsCentersScreen> {
  List<SportsCenter> _centers = [];
  bool _isLoading = true;
  final _searchController = TextEditingController();

  @override
  void initState() {
    super.initState();
    _fetchCenters();
  }

  Future<void> _fetchCenters({String? name}) async {
    setState(() => _isLoading = true);
    try {
      final data = await SportsCenterProvider().get(filter: name != null ? {'name': name} : null);
      setState(() {
        _centers = data.result;
        _isLoading = false;
      });
    } catch (e) {
      ScaffoldMessenger.of(context).showSnackBar(const SnackBar(content: Text("Greška pri učitavanju centara")));
    }
  }

  @override
  Widget build(BuildContext context) {
    return MobileMasterScreenWidget(
      title: "Sportski Centri",
      child: Padding(
        padding: const EdgeInsets.all(16),
        child: Column(
          children: [
            Row(
              children: [
                Expanded(
                  child: TextField(
                    controller: _searchController,
                    decoration: const InputDecoration(
                      labelText: "Pretraga po imenu",
                    ),
                  ),
                ),
                const SizedBox(width: 8),
                ElevatedButton(
                  onPressed: () {
                    _fetchCenters(name: _searchController.text.trim());
                  },
                  child: const Text("Pretraži"),
                ),
              ],
            ),
            const SizedBox(height: 16),
            Expanded(
              child: _isLoading
                  ? const Center(child: CircularProgressIndicator())
                  : ListView.builder(
                itemCount: _centers.length,
                itemBuilder: (context, index) {
                  final center = _centers[index];
                  return Card(
                    margin: const EdgeInsets.symmetric(vertical: 8),
                    shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(12)),
                    child: Column(
                      crossAxisAlignment: CrossAxisAlignment.stretch,
                      children: [
                        ClipRRect(
                          borderRadius: const BorderRadius.vertical(top: Radius.circular(12)),
                          child: center.image != null
                              ? Image.memory(
                            base64Decode(center.image!),
                            height: 150,
                            fit: BoxFit.cover,
                          )
                              : Container(
                            height: 150,
                            color: Colors.grey[300],
                            child: const Icon(Icons.image_not_supported, size: 50),
                          ),
                        ),
                        Padding(
                          padding: const EdgeInsets.all(12),
                          child: Column(
                            crossAxisAlignment: CrossAxisAlignment.start,
                            children: [
                              Text(
                                center.name ?? "Nepoznat centar",
                                style: const TextStyle(fontSize: 18, fontWeight: FontWeight.bold),
                              ),
                              const SizedBox(height: 6),
                              Row(
                                children: [
                                  const Icon(Icons.access_time, size: 18, color: Colors.grey),
                                  const SizedBox(width: 6),
                                  Text("${center.startTime ?? "?"} - ${center.endTime ?? "?"}"),
                                ],
                              ),
                              Align(
                                alignment: Alignment.centerRight,
                                child: IconButton(
                                  icon: const Icon(Icons.info_outline, color: Colors.blue),
                                  tooltip: "Detalji",
                                  onPressed: () {
                                    Navigator.push(
                                      context,
                                      MaterialPageRoute(
                                        builder: (context) => SportCenterDetailsScreen(sportsCenterId: center.id!),
                                      ),
                                    );
                                  },
                                ),
                              ),
                            ],
                          ),
                        ),
                      ],
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
