import 'dart:async';
import 'dart:convert';

import 'package:flutter/material.dart';
import 'package:managerdesktop/screens/sport_field_form.dart';
import 'package:managerdesktop/services/session_serivce.dart';
import 'package:managerdesktop/widgets/master_screen.dart';
import 'package:managerdesktop/providers/sport_field_provider.dart';
import 'package:managerdesktop/models/sport_field.dart';

class FieldsScreen extends StatefulWidget {
  const FieldsScreen({Key? key}) : super(key: key);

  @override
  State<FieldsScreen> createState() => _FieldsScreenState();
}

class _FieldsScreenState extends State<FieldsScreen> {
  late SportFieldProvider _sportFieldProvider;
  List<SportField> _fields = [];
  List<SportField> _filteredFields = [];
  bool isLoading = true;
  String searchQuery = '';
  Timer? _debounce;

  @override
  void initState() {
    super.initState();
    _sportFieldProvider = SportFieldProvider();
    _fetchFields();
  }

  Future<void> _fetchFields({String? query}) async {
    try {
      var filter = {};

      var sportsCenterId = SessionService().sportsCenterId;

      if (sportsCenterId != null) {
        filter['SportsCenterId'] = sportsCenterId.toString();
      }
      if (query != null && query.isNotEmpty) {
        filter['Name'] = query;
      }

      var result = await _sportFieldProvider.get(filter: filter);

      setState(() {
        _fields = result.result;
        _filteredFields = _fields;
      });
    } catch (e) {
      print("Error loading fields: $e");
    } finally {
      setState(() {
        isLoading = false;
      });
    }
  }

  void _filterFields(String query) async {
    if(_debounce?.isActive ?? false) _debounce!.cancel();
    _debounce = Timer(const Duration(milliseconds: 400), () async {
      setState(() {
        searchQuery = query;
        isLoading = true;
      });
      await _fetchFields(query: query);

    });
  }

  @override
  void dispose() {
    _debounce?.cancel();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
      child: Padding(
        padding: const EdgeInsets.all(16.0),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            const Text(
              "Tereni",
              style: TextStyle(fontSize: 32, fontWeight: FontWeight.bold),
            ),
            const SizedBox(height: 8),
            const Text(
              "Početna/Pregled terena",
              style: TextStyle(fontSize: 16, color: Colors.grey),
            ),
            const SizedBox(height: 16),
            Row(
              children: [
                Expanded(
                  child: TextField(
                    onChanged: _filterFields,
                    decoration: InputDecoration(
                      hintText: "Pretraži terene...",
                      border: OutlineInputBorder(
                        borderRadius: BorderRadius.circular(12),
                      ),
                      contentPadding: const EdgeInsets.symmetric(horizontal: 12),
                      suffixIcon: isLoading
                          ? const Padding(
                        padding: EdgeInsets.all(12.0),
                        child: SizedBox(
                          width: 20,
                          height: 20,
                          child: CircularProgressIndicator(strokeWidth: 2),
                        ),
                      )
                          : const Icon(Icons.search), // Default icon when not loading
                    ),
                  ),
                ),
                const SizedBox(width: 16),
                ElevatedButton.icon(
                  onPressed: () async {
                    await Navigator.push(
                      context,
                      MaterialPageRoute(
                        builder: (context) => SportFieldFormScreen(
                          onRefresh: _fetchFields, // 👈 pass the refresh method directly
                        ),
                      ),
                    );
                  },
                  icon: const Icon(Icons.add),
                  label: const Text("Dodaj novi teren"),
                  style: ElevatedButton.styleFrom(
                    padding: const EdgeInsets.symmetric(horizontal: 24, vertical: 20),
                    textStyle: const TextStyle(fontSize: 16),
                  ),
                ),
              ],
            ),
            const SizedBox(height: 16),
            Expanded(
              child: AnimatedSwitcher(
                duration: const Duration(milliseconds: 500),
                child: isLoading
                    ? const Center(
                  key: ValueKey('loader'), // 👈 important for switch animations
                  child: CircularProgressIndicator(),
                )
                    : LayoutBuilder(
                  key: ValueKey('grid'), // 👈 important for switch animations
                  builder: (context, constraints) {
                    double maxWidth = constraints.maxWidth;
                    int crossAxisCount = (maxWidth ~/ 220).clamp(1, 6);

                    return GridView.builder(
                      padding: const EdgeInsets.all(8),
                      gridDelegate: SliverGridDelegateWithFixedCrossAxisCount(
                        crossAxisCount: crossAxisCount,
                        crossAxisSpacing: 16,
                        mainAxisSpacing: 16,
                        childAspectRatio: 1,
                      ),
                      itemCount: _filteredFields.length + 1,
                      itemBuilder: (context, index) {
                        if (index < _filteredFields.length) {
                          return _buildFieldCard(_filteredFields[index]);
                        }
                      },
                    );
                  },
                ),
              ),
            )
          ],
        ),
      ),
    );
  }

  Widget _buildFieldCard(SportField field) {
    return GestureDetector(
      onTap: () async {
        var updated = await Navigator.push(
          context,
          MaterialPageRoute(
            builder: (context) => SportFieldFormScreen(sportFieldId: field.id, onRefresh: _fetchFields),
          ),
        );
        if (updated == true) {
          _fetchFields();
        }
      },
      child: Card(
        color: Colors.grey[900],
        shape: RoundedRectangleBorder(
          borderRadius: BorderRadius.circular(12),
        ),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.stretch,
          children: [
            Expanded(
              child: ClipRRect(
                borderRadius: const BorderRadius.vertical(top: Radius.circular(12)),
                child: field.image != null && field.image!.isNotEmpty
                    ? Image.memory(
                  base64Decode(field.image!),
                  fit: BoxFit.cover,
                )
                    : Image.asset(
                  "assets/images/placeholder_field.jpg",
                  fit: BoxFit.cover,
                ),
              ),
            ),
            Padding(
              padding: const EdgeInsets.all(8.0),
              child: Text(
                field.name ?? '',
                style: const TextStyle(fontSize: 16, fontWeight: FontWeight.w600),
                textAlign: TextAlign.center,
              ),
            ),
          ],
        ),
      ),
    );
  }
}
