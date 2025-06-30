import 'dart:convert';
import 'dart:io';

import 'package:file_picker/file_picker.dart';
import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:form_builder_validators/form_builder_validators.dart';

import '../models/user.dart';
import '../providers/user_provider.dart';
import '../screens/login.dart';
import '../services/sport_translation_service.dart';
import '../widgets/master_screen.dart';
import '../widgets/custom_snackbar.dart';

class ProfileScreen extends StatefulWidget {
  const ProfileScreen({super.key});

  @override
  State<ProfileScreen> createState() => _ProfileScreenState();
}

class _ProfileScreenState extends State<ProfileScreen> {
  final _updateFormKey = GlobalKey<FormBuilderState>();
  final _passwordFormKey = GlobalKey<FormBuilderState>();

  final _userProvider = UserProvider();
  User? _user;
  bool _isLoading = true;
  File? _pickedFile;
  String? _profileImageBase64;
  final List<String> _allSports = [
    'FOOTBALL',
    'BASKETBALL',
    'FUTSAL',
    'VOLLEYBALL',
    'BEACH_VOLLEYBALL',
    'MINI_FOOTBALL',
    'HANDBALL',
    'TENNIS'
  ];
  List<String> _selectedSports = [];
  @override
  void initState() {
    super.initState();
    _loadProfile();
  }

  Future<void> _loadProfile() async {
    final user = await _userProvider.getProfile();
    setState(() {
      _user = user;
      _profileImageBase64 = user.profilePicture;
      _isLoading = false;
      _selectedSports = List<String>.from(user.sports ?? []);
    });

    WidgetsBinding.instance.addPostFrameCallback((_) {
      _updateFormKey.currentState?.patchValue({
        'firstName': user.firstName,
        'lastName': user.lastName,
        'email': user.email,
        'phoneNumber': user.phoneNumber,
        'profilePicture': 'picked',
      });
    });
  }

  Future<void> _pickImage() async {
    final result = await FilePicker.platform.pickFiles(type: FileType.image);
    if (result != null && result.files.single.path != null) {
      final file = File(result.files.single.path!);
      final bytes = await file.readAsBytes();
      setState(() {
        _pickedFile = file;
        _profileImageBase64 = base64Encode(bytes);
      });
      _updateFormKey.currentState?.fields['profilePicture']?.didChange('picked');
    }
  }

  Future<void> _submitUpdateForm() async {
    if (_updateFormKey.currentState?.saveAndValidate() ?? false) {
      final data = _updateFormKey.currentState!.value;

      try {
        await _userProvider.update(_user!.id!, {
          'firstName': data['firstName'],
          'lastName': data['lastName'],
          'email': data['email'],
          'phoneNumber': data['phoneNumber'],
          'profilePicture': _profileImageBase64 ?? "",
        });

        await _loadProfile();
        CustomSnackbar.show(context, "Profil uspješno ažuriran", SnackbarType.success);
      } catch (e) {
        CustomSnackbar.show(context, "Greška: $e", SnackbarType.error);
      }
    }
  }

  Future<void> _submitPasswordForm() async {
    if (_passwordFormKey.currentState?.saveAndValidate() ?? false) {
      final data = _passwordFormKey.currentState!.value;

      try {
        await _userProvider.changePassword(
          id: _user!.id!,
          password: data['oldPassword'],
          newPassword: data['newPassword'],
        );

        CustomSnackbar.show(context, "Lozinka uspješno promijenjena", SnackbarType.success);

        showDialog(
          context: context,
          builder: (_) => AlertDialog(
            title: const Text("Promjena lozinke"),
            content: const Text("Molimo prijavite se ponovo."),
            actions: [
              TextButton(
                onPressed: () {
                  Navigator.of(context).pop();
                  Navigator.of(context).pushAndRemoveUntil(
                    MaterialPageRoute(builder: (_) => const LoginPage()),
                        (route) => false,
                  );
                },
                child: const Text("OK"),
              ),
            ],
          ),
        );
      } catch (e) {
        if (e.toString().contains('INVALID_PASSWORD')) {
          CustomSnackbar.show(context, "Pogrešna trenutna lozinka", SnackbarType.error);
        } else {
          CustomSnackbar.show(context, "Greška: $e", SnackbarType.error);
        }
      }
    }
  }

  Future<void> _saveSports() async {
    if (_user?.id == null) return;

    try {
      await _userProvider.updateUserSports(_user!.id!, _selectedSports);
      if (mounted) {
          CustomSnackbar.show(context, "Sportovi uspješno sačuvani", SnackbarType.success);
      }
    } catch (e) {
      if (mounted) {
        CustomSnackbar.show(context, "Greška: $e", SnackbarType.error);
      }
    }
  }

  @override
  Widget build(BuildContext context) {
    if (_isLoading || _user == null) {
      return const Center(child: CircularProgressIndicator());
    }

    return MobileMasterScreenWidget(
      title: "Moj profil",
      child: SingleChildScrollView(
        padding: const EdgeInsets.all(16),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.stretch,
          children: [
            // --- Profile Image ---
            const Text("Profilna slika", style: TextStyle(fontWeight: FontWeight.bold)),
            const SizedBox(height: 8),
            ClipRRect(
              borderRadius: BorderRadius.circular(8),
              child: _pickedFile != null
                  ? Image.file(_pickedFile!, height: 150, fit: BoxFit.cover)
                  : (_profileImageBase64 != null
                  ? Image.memory(base64Decode(_profileImageBase64!), height: 150, fit: BoxFit.cover)
                  : Container(
                height: 150,
                color: Colors.grey[800],
                child: const Center(child: Icon(Icons.person, size: 50, color: Colors.white70)),
              )),
            ),
            const SizedBox(height: 8),
            TextButton.icon(
              onPressed: _pickImage,
              icon: const Icon(Icons.upload),
              label: const Text("Odaberi novu sliku"),
            ),
            FormBuilderField<String>(
              name: 'profilePicture',
              validator: (val) {
                if (_profileImageBase64 == null) return 'Odaberite sliku';
                return null;
              },
              builder: (field) => const SizedBox.shrink(),
            ),

            const Divider(height: 32),

            // --- Profile Data ---
            const Text("Podaci o profilu", style: TextStyle(fontWeight: FontWeight.bold)),
            FormBuilder(
              key: _updateFormKey,
              child: Column(
                children: [
                  FormBuilderTextField(
                    name: 'firstName',
                    decoration: const InputDecoration(labelText: 'Ime'),
                    validator: FormBuilderValidators.required(),
                  ),
                  FormBuilderTextField(
                    name: 'lastName',
                    decoration: const InputDecoration(labelText: 'Prezime'),
                    validator: FormBuilderValidators.required(),
                  ),
                  FormBuilderTextField(
                    name: 'email',
                    decoration: const InputDecoration(labelText: 'Email'),
                    validator: FormBuilderValidators.compose([
                      FormBuilderValidators.required(),
                      FormBuilderValidators.email(),
                    ]),
                  ),
                  FormBuilderTextField(
                    name: 'phoneNumber',
                    decoration: const InputDecoration(labelText: 'Telefon'),
                    validator: FormBuilderValidators.compose([
                      FormBuilderValidators.required(),
                      FormBuilderValidators.match(
                        RegExp(r'^\+?\d{6,15}$'),
                        errorText: 'Neispravan format broja',
                      ),
                    ]),
                  ),
                  const SizedBox(height: 16),
                  ElevatedButton(onPressed: _submitUpdateForm, child: const Text("Sačuvaj izmjene")),
                ],
              ),
            ),
            const Divider(height: 32),

            const Text("Sportovi", style: TextStyle(fontWeight: FontWeight.bold)),
            const SizedBox(height: 8),
            Wrap(
              spacing: 8,
              runSpacing: 4,
              children: _allSports.map((sport) {
                return FilterChip(
                  label: Text(SportTranslationService.translate(sport)),
                  selected: _selectedSports.contains(sport),
                  onSelected: (bool selected) {
                    setState(() {
                      if (selected) {
                        _selectedSports.add(sport);
                      } else {
                        _selectedSports.remove(sport);
                      }
                    });
                  },
                );
              }).toList(),
            ),
            const SizedBox(height: 12),
            ElevatedButton(
              onPressed: _saveSports,
              child: const Text("Sačuvaj sportove"),
            ),
            const Divider(height: 32),


            // --- Password Change ---
            const Text("Promijeni lozinku", style: TextStyle(fontWeight: FontWeight.bold)),
            FormBuilder(
              key: _passwordFormKey,
              child: Column(
                children: [
                  FormBuilderTextField(
                    name: 'oldPassword',
                    obscureText: true,
                    decoration: const InputDecoration(labelText: 'Trenutna lozinka'),
                    validator: FormBuilderValidators.required(),
                  ),
                  FormBuilderTextField(
                    name: 'newPassword',
                    obscureText: true,
                    decoration: const InputDecoration(labelText: 'Nova lozinka'),
                    validator: FormBuilderValidators.compose([
                      FormBuilderValidators.required(),
                      FormBuilderValidators.minLength(6),
                    ]),
                  ),
                  FormBuilderTextField(
                    name: 'confirmPassword',
                    obscureText: true,
                    decoration: const InputDecoration(labelText: 'Potvrdi lozinku'),
                    validator: (val) {
                      final newPassword = _passwordFormKey.currentState?.fields['newPassword']?.value;
                      if (val != newPassword) return 'Lozinke se ne poklapaju';
                      return null;
                    },
                  ),
                  const SizedBox(height: 16),
                  ElevatedButton(onPressed: _submitPasswordForm, child: const Text("Promijeni lozinku")),
                ],
              ),
            ),
          ],
        ),
      ),
    );
  }
}
