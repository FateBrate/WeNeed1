import 'dart:convert';
import 'dart:io';

import 'package:file_picker/file_picker.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:form_builder_validators/form_builder_validators.dart';

import '../providers/sport_field_provider.dart';
import '../services/session_serivce.dart';
import '../widgets/confirmation_dialog.dart';
import '../widgets/master_screen.dart';


class SportFieldFormScreen extends StatefulWidget {
  final int? sportFieldId;
  final VoidCallback? onRefresh;
  const SportFieldFormScreen({super.key, this.onRefresh, this.sportFieldId});

  @override
  State<SportFieldFormScreen> createState() => _SportFieldFormScreenState();
}

class _SportFieldFormScreenState extends State<SportFieldFormScreen> {
  final _formKey = GlobalKey<FormBuilderState>();
  File? _image;
  String? _base64Image;
  bool _isLoading = true;

  late SportFieldProvider _sportFieldProvider;

  @override
  void initState() {
    super.initState();
    _sportFieldProvider = SportFieldProvider();
    if (widget.sportFieldId != null) {
      _loadFieldData();
    } else {
      _isLoading = false;
    }
  }

  Future<void> _loadFieldData() async {
    try {
      var field = await _sportFieldProvider.getById(widget.sportFieldId!);

      _base64Image = field.image;

      WidgetsBinding.instance.addPostFrameCallback((_) {
        _formKey.currentState?.patchValue({
          'name': field.name ?? '',
          'sportType': field.sportType ?? '',
          'description': field.description ?? '',
          'pricePerHour': field.pricePerHour?.toString() ?? '',
        });
      });
    } catch (e) {
      print("Error loading sport field: $e");
      ScaffoldMessenger.of(context).showSnackBar(
        const SnackBar(
          content: Text('Greška prilikom učitavanja podataka',style: TextStyle(color: Colors.white),),
          backgroundColor: Colors.red,),
      );
    } finally {
      setState(() {
        _isLoading = false;
      });
    }
  }

  Future getImage() async {
    var result = await FilePicker.platform.pickFiles(type: FileType.image);
    if (result != null && result.files.single.path != null) {
      _image = File(result.files.single.path!);
      _base64Image = base64Encode(_image!.readAsBytesSync());
    }
  }

  Future<void> _saveField() async {
    if (!_formKey.currentState!.saveAndValidate() || _base64Image == null) {
      ScaffoldMessenger.of(context).showSnackBar(
        const SnackBar(
            content: Text('Molimo popunite sva polja i dodajte sliku',style: TextStyle(color: Colors.white),),
            backgroundColor: Colors.red,),
      );
      return;
    }
    var sportsCenterId = SessionService().sportsCenterId;
    try {
      var request =
      Map<String, dynamic>.from(_formKey.currentState!.value);
      request['image'] = _base64Image;
      request['sportsCenterId'] = sportsCenterId;
      if (widget.sportFieldId == null) {
        await _sportFieldProvider.insert(request);
      } else {
        await _sportFieldProvider.update(widget.sportFieldId!, request);
      }

      if (widget.onRefresh != null) {
        widget.onRefresh!();
      }

      if (mounted) {
        ScaffoldMessenger.of(context).showSnackBar(
          const SnackBar
            (content: Text('Podaci su uspješno sačuvani',style: TextStyle(color: Colors.white),),
            backgroundColor: Colors.green,),
        );
      }

      await Future.delayed(const Duration(milliseconds: 500));

      if (mounted) {
        Navigator.of(context).pop();
      }
    } catch (e) {
      print("Error saving sport field: $e");
      if (mounted) {
        ScaffoldMessenger.of(context).showSnackBar(
          const SnackBar
            (content: Text('Greška prilikom spremanja podataka',style: TextStyle(color: Colors.white),),
            backgroundColor: Colors.red,),
        );
      }
    }
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
      child: _isLoading
          ? const Center(child: CircularProgressIndicator())
          : SingleChildScrollView(
        padding: const EdgeInsets.all(16),
        child: FormBuilder(
          key: _formKey,
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              Text(
                widget.sportFieldId == null ? "Dodaj novi teren" : "Uredi teren",
                style: const TextStyle(fontSize: 32, fontWeight: FontWeight.bold),
              ),
              const SizedBox(height: 16),

              // NAME
              FormBuilderTextField(
                name: 'name',
                decoration: const InputDecoration(labelText: "Naziv"),
                validator: FormBuilderValidators.compose([
                  FormBuilderValidators.required(errorText: 'Obavezno polje'),
                ]),
              ),
              const SizedBox(height: 12),

              // SPORT TYPE
              FormBuilderTextField(
                name: 'sportType',
                decoration: const InputDecoration(labelText: "Sport"),
                validator: FormBuilderValidators.compose([
                  FormBuilderValidators.required(errorText: 'Obavezno polje'),
                ]),
              ),
              const SizedBox(height: 12),

              // DESCRIPTION
              FormBuilderTextField(
                name: 'description',
                decoration: const InputDecoration(labelText: "Opis"),
                maxLines: 3,
                validator: FormBuilderValidators.compose([
                  FormBuilderValidators.required(errorText: 'Obavezno polje'),
                ]),
              ),
              const SizedBox(height: 12),

              // PRICE
              FormBuilderTextField(
                name: 'pricePerHour',
                decoration: const InputDecoration(labelText: "Cena po satu"),
                keyboardType: TextInputType.numberWithOptions(decimal: true),
                inputFormatters: [
                  FilteringTextInputFormatter.digitsOnly
                ],
                validator: FormBuilderValidators.compose([
                  FormBuilderValidators.required(errorText: 'Obavezno polje'),
                  FormBuilderValidators.numeric(errorText: 'Mora biti broj'),
                ]),
              ),
              const SizedBox(height: 16),

              // IMAGE
              Text(
                "Slika",
                style: const TextStyle(fontSize: 18, fontWeight: FontWeight.bold),
              ),
              const SizedBox(height: 8),

              _base64Image != null
                  ? Column(
                children: [
                  ClipRRect(
                    borderRadius: BorderRadius.circular(8),
                    child: Image.memory(
                      base64Decode(_base64Image!),
                      height: 200,
                      width: double.infinity,
                      fit: BoxFit.cover,
                    ),
                  ),
                  TextButton.icon(
                    onPressed: () {
                      setState(() {
                        _base64Image = null;
                      });
                    },
                    icon: const Icon(Icons.delete, color: Colors.red),
                    label: const Text(
                      "Ukloni sliku",
                      style: TextStyle(color: Colors.red),
                    ),
                  ),
                ],
              )
                  : Container(
                height: 200,
                width: double.infinity,
                color: Colors.grey[300],
                child: const Icon(Icons.image, size: 100, color: Colors.white),
              ),
              const SizedBox(height: 8),

              ElevatedButton.icon(
                onPressed: () async {
                  await getImage();
                  setState(() {}); // Force rebuild after image is picked
                },
                icon: const Icon(Icons.upload),
                label: const Text("Izaberi sliku"),
              ),

              const SizedBox(height: 24),

              // SAVE BUTTON
              Center(
                child: Column(
                  children: [
                    ElevatedButton(
                      onPressed: _saveField,
                      style: ElevatedButton.styleFrom(
                        padding: const EdgeInsets.symmetric(horizontal: 40, vertical: 16),
                        textStyle: const TextStyle(fontSize: 18),
                      ),
                      child: const Text("Sačuvaj"),
                    ),
                    if (widget.sportFieldId != null) const SizedBox(height: 16),
                    if (widget.sportFieldId != null)
                      ElevatedButton(
                        onPressed: () {
                          showDialog(
                            context: context,
                            builder: (ctx) => ConfirmationDialog(
                              title: 'Potvrda brisanja',
                              content: 'Jeste li sigurni da želite obrisati ovaj sportski teren?',
                              confirmButtonText: 'Da',
                              cancelButtonText: 'Ne',
                              onConfirm: () async {
                                try {
                                  await _sportFieldProvider.delete(widget.sportFieldId!);

                                  if (widget.onRefresh != null) {
                                    widget.onRefresh!();
                                  }

                                  if (mounted) {
                                    Navigator.of(context).pop();
                                  }

                                  ScaffoldMessenger.of(context).showSnackBar(
                                    const SnackBar(
                                        content: Text('Teren uspješno obrisan.',style: TextStyle(color: Colors.white)),
                                        backgroundColor: Colors.green
                                    ),
                                  );
                                } catch (e) {
                                  ScaffoldMessenger.of(context).showSnackBar(
                                    const SnackBar(
                                        content: Text('Greška prilikom brisanja.',
                                          style: TextStyle(color: Colors.white)
                                        ),
                                        backgroundColor: Colors.red
                                    ),
                                  );
                                }
                              },
                            ),
                          );
                        },
                        style: ElevatedButton.styleFrom(
                          backgroundColor: Colors.red,
                          padding: const EdgeInsets.symmetric(horizontal: 40, vertical: 16),
                          textStyle: const TextStyle(fontSize: 18),
                          foregroundColor: Colors.white
                        ),
                        child: const Text("Obriši"),
                      ),
                  ],
                ),
              ),
            ],
          ),
        ),
      ),
    );
  }
}
