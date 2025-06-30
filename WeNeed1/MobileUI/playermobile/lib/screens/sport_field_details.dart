import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:playermobile/screens/slot_screen.dart';
import '../models/sport_field.dart';
import '../providers/sport_field_provider.dart';
import '../widgets/master_screen.dart';

class SportFieldDetailsScreen extends StatefulWidget {
  final int sportFieldId;

  const SportFieldDetailsScreen({super.key, required this.sportFieldId});

  @override
  State<SportFieldDetailsScreen> createState() => _SportFieldDetailsScreenState();
}

class _SportFieldDetailsScreenState extends State<SportFieldDetailsScreen> {
  final SportFieldProvider _provider = SportFieldProvider();
  SportField? _field;
  bool _isLoading = true;

  @override
  void initState() {
    super.initState();
    _loadDetails();
  }

  Future<void> _loadDetails() async {
    setState(() => _isLoading = true);
    try {
      final result = await _provider.getById(widget.sportFieldId);
      setState(() {
        _field = result;
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
      title: "Detalji terena",
      child: _isLoading
          ? const Center(child: CircularProgressIndicator())
          : _field == null
          ? const Center(child: Text("Teren nije pronađen."))
          : SingleChildScrollView(
        padding: const EdgeInsets.all(16),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            if (_field!.image != null)
              Image.memory(
                base64Decode(_field!.image!),
                height: 200,
                width: double.infinity,
                fit: BoxFit.cover,
              ),
            const SizedBox(height: 16),
            Text(
              _field!.name ?? "",
              style: const TextStyle(fontSize: 22, fontWeight: FontWeight.bold),
            ),
            const SizedBox(height: 8),
            Text("Sport: ${_field!.sportType ?? '-'}"),
            Text("Cijena po satu: ${_field!.pricePerHour?.toStringAsFixed(2) ?? '-'} KM"),
            const SizedBox(height: 12),
            if (_field!.description != null && _field!.description!.isNotEmpty)
              Container(
                width: double.infinity,
                padding: const EdgeInsets.all(12),
                decoration: BoxDecoration(
                  color: Colors.blue,
                  borderRadius: BorderRadius.circular(8),
                ),
                child: Text(
                  _field!.description!,
                  style: const TextStyle(color: Colors.white),
                ),
              ),
            const SizedBox(height: 20),
            Center(
              child: ElevatedButton.icon(
                icon: const Icon(Icons.search),
                label: const Text("Pretraži termine"),
                onPressed: () {
                  Navigator.push(
                    context,
                    MaterialPageRoute(
                      builder: (context) =>
                          AvailableSlotsScreen(sportFieldId: widget.sportFieldId),
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
