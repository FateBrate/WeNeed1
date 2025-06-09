import 'dart:convert';
import 'dart:io';
import 'package:file_picker/file_picker.dart';
import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:form_builder_validators/form_builder_validators.dart';
import 'package:managerdesktop/models/sport_center.dart';

import '../providers/sport_center_provider.dart';
import '../widgets/master_screen.dart';
import '../widgets/custom_snackbar.dart';

class SettingsScreen extends StatefulWidget {
  const SettingsScreen({super.key});

  @override
  State<SettingsScreen> createState() => _SettingsScreenState();
}

class _SettingsScreenState extends State<SettingsScreen> {
  final _formKey = GlobalKey<FormBuilderState>();
  final _sportsCenterProvider = SportsCenterProvider();
  SportsCenter? _sportsCenter;
  bool isLoading = true;
  String? _base64Image;
  File? _image;

  @override
  void initState() {
    super.initState();
    _loadData();
  }

  Future<void> _loadData() async {
    try {
      var center = await _sportsCenterProvider.getMySportsCenter();
      setState(() {
        _sportsCenter = center;
        _base64Image = center.image;
        isLoading = false;
      });
    } catch (e) {
      setState(() => isLoading = false);
    }
  }

  Future getImage() async {
    var result = await FilePicker.platform.pickFiles(type: FileType.image);
    if (result != null && result.files.single.path != null) {
      setState(() {
        _image = File(result.files.single.path!);
        _base64Image = base64Encode(_image!.readAsBytesSync());
      });
    }
  }

  void _pickTime(String fieldName) async {
    TimeOfDay initial = const TimeOfDay(hour: 10, minute: 0);
    final formValue = _formKey.currentState?.fields[fieldName]?.value;

    if (formValue is String && formValue.contains(':')) {
      final parts = formValue.split(':');
      initial = TimeOfDay(hour: int.parse(parts[0]), minute: int.parse(parts[1]));
    }

    final TimeOfDay? picked = await showTimePicker(context: context, initialTime: initial);
    if (picked != null) {
      final timeString = "${picked.hour.toString().padLeft(2, '0')}:${picked.minute.toString().padLeft(2, '0')}:00";
      _formKey.currentState?.fields[fieldName]?.didChange(timeString);
    }
  }

  Future<void> _save() async {
    if (!_formKey.currentState!.saveAndValidate()) {
      CustomSnackbar.show(context, 'Molimo popunite sva polja', SnackbarType.error);
      return;
    }

    try {
      var data = Map<String, dynamic>.from(_formKey.currentState!.value);
      data['image'] = _base64Image;

      await _sportsCenterProvider.update(_sportsCenter!.id!, data);

      if (mounted) {
        CustomSnackbar.show(context, 'Postavke su sačuvane', SnackbarType.success);
      }
    } catch (e) {
      if (mounted) {
        CustomSnackbar.show(context, 'Greška prilikom spremanja', SnackbarType.error);
      }
    }
  }

  @override
  Widget build(BuildContext context) {
    if (isLoading || _sportsCenter == null) {
      return const Center(child: CircularProgressIndicator());
    }

    return MasterScreenWidget(
      child: SingleChildScrollView(
        padding: const EdgeInsets.all(16),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            const Text(
              "Postavke",
              style: TextStyle(fontSize: 32, fontWeight: FontWeight.bold),
            ),
            const SizedBox(height: 8),
            const Text(
              "Postavke sportskog centra",
              style: TextStyle(fontSize: 16, color: Colors.grey),
            ),
            const SizedBox(height: 16),
            FormBuilder(
              key: _formKey,
              child: Column(
                children: [
                  ClipRRect(
                    borderRadius: BorderRadius.circular(8),
                    child: _base64Image != null && _base64Image!.isNotEmpty
                        ? Image.memory(base64Decode(_base64Image!), height: 180, fit: BoxFit.cover)
                        : Image.asset("assets/images/placeholder_center.png", height: 180),
                  ),
                  TextButton.icon(
                    onPressed: getImage,
                    icon: const Icon(Icons.photo_library_outlined),
                    label: const Text("Izaberi sliku"),
                  ),
                  const SizedBox(height: 16),
                  FormBuilderTextField(
                    name: 'name',
                    initialValue: _sportsCenter!.name,
                    decoration: const InputDecoration(labelText: 'Naziv'),
                    validator: FormBuilderValidators.required(errorText: "Polje 'Naziv' je obavezno"),
                  ),
                  const SizedBox(height: 8),
                  FormBuilderTextField(
                    name: 'address',
                    initialValue: _sportsCenter!.address,
                    decoration: const InputDecoration(labelText: 'Adresa'),
                    validator: FormBuilderValidators.required(errorText: "Polje 'Adresa' je obavezno"),
                  ),
                  const SizedBox(height: 8),
                  FormBuilderTextField(
                    name: 'description',
                    initialValue: _sportsCenter!.description,
                    maxLines: 3,
                    decoration: const InputDecoration(labelText: 'Opis'),
                    validator: FormBuilderValidators.required(errorText: "Polje 'Opis' je obavezno"),
                  ),
                  const SizedBox(height: 8),
                  FormBuilderTextField(
                    name: 'startTime',
                    initialValue: _sportsCenter!.startTime,
                    decoration: const InputDecoration(
                      labelText: 'Početak radnog vremena',
                      suffixIcon: Icon(Icons.access_time),
                    ),
                    readOnly: true,
                    onTap: () => _pickTime('startTime'),
                    validator: FormBuilderValidators.required(errorText: "Polje 'Početak radnog vremena' je obavezno"),
                  ),
                  const SizedBox(height: 8),
                  FormBuilderTextField(
                    name: 'endTime',
                    initialValue: _sportsCenter!.endTime,
                    decoration: const InputDecoration(
                      labelText: 'Kraj radnog vremena',
                      suffixIcon: Icon(Icons.access_time),
                    ),
                    readOnly: true,
                    onTap: () => _pickTime('endTime'),
                    validator: FormBuilderValidators.required(errorText: "Polje 'Kraj radnog vremena' je obavezno"),
                  ),
                  const SizedBox(height: 16),
                  ElevatedButton.icon(
                    onPressed: _save,
                    icon: const Icon(Icons.save),
                    label: const Text("Spremi"),
                  ),
                ],
              ),
            ),
          ],
        ),
      ),
    );
  }
}