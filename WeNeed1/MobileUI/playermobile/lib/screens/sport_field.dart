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
        "name": _searchController.text.trim(),
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
                    decoration: const InputDecoration(labelText: "Pretraga po imenu"),
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
                    child: ListTile(
                      leading: field.image != null
                          ? Image.memory(
                        base64Decode(field.image!),
                        width: 60,
                        height: 60,
                        fit: BoxFit.cover,
                      )
                          : const Icon(Icons.image_not_supported),
                      title: Text(field.name ?? "N/A"),
                      subtitle: Text("Sport: ${field.sportType ?? "-"}"),
                      trailing: IconButton(
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
