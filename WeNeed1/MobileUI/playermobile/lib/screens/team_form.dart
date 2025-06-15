import 'dart:convert';
import 'dart:io';

import 'package:file_picker/file_picker.dart';
import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:form_builder_validators/form_builder_validators.dart';
import 'package:playermobile/screens/team.dart';
import 'package:playermobile/screens/team_details.dart';
import '../models/team.dart';
import '../providers/team_provider.dart';
import '../widgets/master_screen.dart';

class SportTranslationService {
  static final Map<String, String> _sportTranslations = {
    'FOOTBALL': 'Fudbal',
    'BASKETBALL': 'Košarka',
    'FUTSAL': 'Futsal',
    'VOLLEYBALL': 'Odbojka',
    'BEACH_VOLLEYBALL': 'Odbojka na pijesku',
    'MINI_FOOTBALL': 'Mini fudbal',
    'HANDBALL': 'Rukomet',
    'TENNIS': 'Tenis',
  };

  static String translate(String? sportKey) {
    if (sportKey == null) return 'N/A';
    return _sportTranslations[sportKey] ?? sportKey;
  }

  static List<String> get allSportKeys => _sportTranslations.keys.toList();
}

class TeamFormScreen extends StatefulWidget {
  final Team? existingTeam;
  const TeamFormScreen({super.key, this.existingTeam});

  @override
  State<TeamFormScreen> createState() => _TeamFormScreenState();
}

class _TeamFormScreenState extends State<TeamFormScreen> {
  final _formKey = GlobalKey<FormBuilderState>();

  String? _teamPictureBase64;
  File? _pickedFile;
  bool _isPublic = true;

  @override
  void initState() {
    super.initState();
    final team = widget.existingTeam;
    if (team != null) {
      _isPublic = team.isPublic ?? true;
      _teamPictureBase64 = team.teamPicture;
      WidgetsBinding.instance.addPostFrameCallback((_) {
        _formKey.currentState?.patchValue({
          'teamName': team.name,
          'description': team.description,
          'sport': team.sport,
          'city': team.city,
          'teamPicture': 'picked',
        });
      });
    }
  }

  Future<void> _pickImage() async {
    final result = await FilePicker.platform.pickFiles(
      type: FileType.image,
    );
    if (result != null && result.files.single.path != null) {
      final file = File(result.files.single.path!);
      final bytes = await file.readAsBytes();
      setState(() {
        _pickedFile = file;
        _teamPictureBase64 = base64Encode(bytes);
      });
      _formKey.currentState?.fields['teamPicture']?.didChange('picked');
    }
  }

  void _submitForm() async {
    final formState = _formKey.currentState;
    if (formState == null) return;

    if (formState.saveAndValidate()) {
      final values = formState.value;

      final requestBody = {
        "name": values['teamName'] ?? "",
        "teamPicture": _teamPictureBase64 ?? "",
        "sport": values['sport'] ?? "",
        "description": values['description'] ?? "",
        "isPublic": _isPublic,
        "city": values['city'] ?? "",
      };

      try {
        final provider = TeamProvider();

        showDialog(
          context: context,
          barrierDismissible: false,
          builder: (_) => const Center(child: CircularProgressIndicator()),
        );

        if (widget.existingTeam != null) {
          await provider.update(widget.existingTeam!.id!, requestBody);
          ScaffoldMessenger.of(context).showSnackBar(
            const SnackBar(content: Text('Tim uspješno ažuriran!')),
          );

          Navigator.of(context).pushReplacement(
            MaterialPageRoute(
              builder: (_) => TeamDetailsScreen(teamId: widget.existingTeam!.id!),
            ),
          );
        } else {
          final createdTeam = await provider.insert(requestBody);

          Navigator.of(context).pop();

          ScaffoldMessenger.of(context).showSnackBar(
            const SnackBar(content: Text('Tim uspješno kreiran!')),
          );

          if (createdTeam != null && createdTeam.id != null) {
            Navigator.of(context).pushReplacement(
              MaterialPageRoute(
                builder: (_) => TeamDetailsScreen(teamId: createdTeam.id!),
              ),
            );
          } else {
            Navigator.of(context).pop();
          }
        }
      } catch (e) {
        Navigator.of(context).pop();
        ScaffoldMessenger.of(context).showSnackBar(
          SnackBar(content: Text('Greška: $e')),
        );
      }
    } else {
      ScaffoldMessenger.of(context).showSnackBar(
        const SnackBar(content: Text('Popunite sve obavezne podatke i odaberite sliku')),
      );
    }
  }


  @override
  @override
  Widget build(BuildContext context) {
    return MobileMasterScreenWidget(
      title: widget.existingTeam != null ? 'Uredi tim' : 'Novi tim',
      child: SingleChildScrollView(
        padding: const EdgeInsets.all(16),
        child: FormBuilder(
          key: _formKey,
          autovalidateMode: AutovalidateMode.disabled,
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.stretch,
            children: [
              Text('Slika tima', style: Theme.of(context).textTheme.bodyMedium),
              const SizedBox(height: 8),

              ClipRRect(
                borderRadius: BorderRadius.circular(8),
                child: _pickedFile != null
                    ? Image.file(_pickedFile!, height: 150, fit: BoxFit.cover)
                    : (_teamPictureBase64 != null
                    ? Image.memory(base64Decode(_teamPictureBase64!), height: 150, fit: BoxFit.cover)
                    : Container(
                  height: 150,
                  color: Colors.grey[800],
                  child: const Center(
                    child: Icon(Icons.camera_alt, size: 50, color: Colors.white70),
                  ),
                )),
              ),

              const SizedBox(height: 8),
              TextButton.icon(
                onPressed: _pickImage,
                icon: const Icon(Icons.upload_file),
                label: const Text("Odaberi novu sliku"),
              ),

              FormBuilderField<String>(
                name: 'teamPicture',
                validator: (val) {
                  if (_teamPictureBase64 == null) {
                    return 'Odaberite sliku tima';
                  }
                  return null;
                },
                builder: (field) => const SizedBox.shrink(),
              ),

              const SizedBox(height: 20),

              FormBuilderDropdown<String>(
                name: 'sport',
                decoration: const InputDecoration(
                  labelText: "Sport",
                  border: OutlineInputBorder(),
                ),
                items: SportTranslationService.allSportKeys.map((sportKey) {
                  return DropdownMenuItem<String>(
                    value: sportKey,
                    child: Text(SportTranslationService.translate(sportKey)),
                  );
                }).toList(),
                validator: FormBuilderValidators.required(errorText: 'Odaberite sport'),
              ),
              const SizedBox(height: 20),

              FormBuilderTextField(
                name: 'teamName',
                decoration: const InputDecoration(
                  labelText: 'Naziv tima',
                  border: OutlineInputBorder(),
                ),
                validator: FormBuilderValidators.compose([
                  FormBuilderValidators.required(errorText: 'Unesite naziv tima'),
                  FormBuilderValidators.minLength(2, errorText: 'Naziv mora imati najmanje 2 karaktera'),
                ]),
              ),
              const SizedBox(height: 20),

              FormBuilderTextField(
                name: 'description',
                decoration: const InputDecoration(
                  labelText: 'Opis tima',
                  border: OutlineInputBorder(),
                ),
                maxLines: 3,
              ),
              const SizedBox(height: 20),

              FormBuilderTextField(
                name: 'city',
                decoration: const InputDecoration(
                  labelText: 'Grad',
                  border: OutlineInputBorder(),
                ),
                validator: FormBuilderValidators.required(errorText: 'Unesite grad'),
              ),
              const SizedBox(height: 20),

              Row(
                children: [
                  Tooltip(
                    message: 'Ako označite, tim će biti skriven i moći će se pronaći samo putem koda',
                    child: Checkbox(
                      value: _isPublic,
                      onChanged: widget.existingTeam != null ? null : (val) {
                        if (val != null) setState(() => _isPublic = val);
                      },
                    ),
                  ),
                  const SizedBox(width: 8),
                  const Expanded(child: Text('Javni tim (vidljiv u pretrazi)')),
                ],
              ),
              const SizedBox(height: 30),

              ElevatedButton(
                onPressed: _submitForm,
                child: Padding(
                  padding: const EdgeInsets.symmetric(vertical: 14),
                  child: Text(
                    widget.existingTeam != null ? 'Sačuvaj promjene' : 'Kreiraj tim',
                    style: const TextStyle(fontSize: 18),
                  ),
                ),
              ),
            ],
          ),
        ),
      ),
    );
  }
}
