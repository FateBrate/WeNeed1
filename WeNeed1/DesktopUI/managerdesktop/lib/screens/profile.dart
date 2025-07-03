import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:form_builder_validators/form_builder_validators.dart';
import '../models/user.dart';
import '../providers/user_provider.dart';
import '../widgets/master_screen.dart';
import '../widgets/custom_snackbar.dart';
import 'login.dart';

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

  @override
  void initState() {
    super.initState();
    _loadProfile();
  }

  Future<void> _loadProfile() async {
    final user = await _userProvider.getProfile();
    setState(() {
      _user = user;
      _isLoading = false;
    });
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
        });

        await _loadProfile();
        CustomSnackbar.show(context, "Profil uspješno ažuriran", SnackbarType.success);
      } catch (e) {
        CustomSnackbar.show(context, "Greška prilikom ažuriranja profila: $e", SnackbarType.error);
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
          builder: (BuildContext context) {
            return AlertDialog(
              title: const Text("Promjena lozinke"),
              content: const Text(
                  "Vaša lozinka je uspješno promijenjena.\n\nMolimo prijavite se ponovo sa novim kredencijalima."
              ),
              actions: [
                TextButton(
                  onPressed: () {
                    Navigator.of(context).pop();
                    Navigator.of(context).pushAndRemoveUntil(
                      MaterialPageRoute(builder: (context) => const LoginPage()),
                          (route) => false,
                    );
                  },
                  child: const Text("U redu"),
                ),
              ],
            );
          },
        );
      } catch (e) {
        final errorMessage = e.toString();

        if (errorMessage.contains('INVALID_PASSWORD')) {
          CustomSnackbar.show(context, "Unesena trenutna lozinka nije tačna.", SnackbarType.error);
        } else {
          CustomSnackbar.show(context, "Greška pri promjeni lozinke: $errorMessage", SnackbarType.error);
        }
      }
    }
  }



  @override
  Widget build(BuildContext context) {
    if (_isLoading || _user == null) {
      return const Center(child: CircularProgressIndicator());
    }

    return MasterScreenWidget(
      title: "Profil vlasnika",
      child: SingleChildScrollView(
        padding: const EdgeInsets.all(16),
        child: Row(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Expanded(
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  const Text("Profil vlasnika", style: TextStyle(fontSize: 20, fontWeight: FontWeight.bold)),
                  const SizedBox(height: 16),
                  FormBuilder(
                    key: _updateFormKey,
                    child: Column(
                      children: [
                        FormBuilderTextField(
                          name: 'firstName',
                          decoration: const InputDecoration(labelText: 'Ime'),
                          initialValue: _user!.firstName,
                          validator: FormBuilderValidators.required(errorText: "Polje 'Ime' je obavezno"),
                        ),
                        FormBuilderTextField(
                          name: 'lastName',
                          decoration: const InputDecoration(labelText: 'Prezime'),
                          initialValue: _user!.lastName,
                          validator: FormBuilderValidators.required(errorText: "Polje 'Prezime' je obavezno"),
                        ),
                        FormBuilderTextField(
                          name: 'email',
                          decoration: const InputDecoration(labelText: 'Email'),
                          initialValue: _user!.email,
                          validator: FormBuilderValidators.compose([
                            FormBuilderValidators.required(errorText: "Polje 'Email' je obavezno"),
                            FormBuilderValidators.email(errorText: "Unesite ispravan email format"),
                          ]),
                        ),
                        FormBuilderTextField(
                          name: 'phoneNumber',
                          decoration: const InputDecoration(labelText: 'Broj telefona'),
                          initialValue: _user!.phoneNumber,
                          validator: FormBuilderValidators.compose([
                            FormBuilderValidators.required(errorText: "Polje 'Broj telefona' je obavezno"),
                            FormBuilderValidators.match(
                              RegExp(r'^\+?\d{6,15}$'),
                              errorText: 'Neispravan format broja',
                            ),
                          ]),
                        ),
                        const SizedBox(height: 16),
                        ElevatedButton(
                          onPressed: _submitUpdateForm,
                          child: const Text("Sačuvaj izmjene"),
                        ),
                      ],
                    ),
                  ),
                ],
              ),
            ),
            const SizedBox(width: 32),
            Expanded(
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  const Text("Promijeni lozinku", style: TextStyle(fontSize: 20, fontWeight: FontWeight.bold)),
                  const SizedBox(height: 16),
                  FormBuilder(
                    key: _passwordFormKey,
                    child: Column(
                      children: [
                        FormBuilderTextField(
                          name: 'oldPassword',
                          decoration: const InputDecoration(labelText: 'Trenutna lozinka'),
                          obscureText: true,
                          validator: FormBuilderValidators.compose([
                            FormBuilderValidators.required(errorText: "Polje 'trenutna lozinka' je obavezno"),
                            FormBuilderValidators.minLength(8, errorText: 'Lozinka mora imati najmanje 8 znakova'),
                          ]),
                        ),
                        FormBuilderTextField(
                          name: 'newPassword',
                          decoration: const InputDecoration(labelText: 'Nova lozinka'),
                          obscureText: true,
                          validator: FormBuilderValidators.compose([
                            FormBuilderValidators.required(errorText: "Polje 'Nova lozinka' je obavezno"),
                            FormBuilderValidators.minLength(8, errorText: 'Lozinka mora imati najmanje 8 znakova'),
                          ]),
                        ),
                        FormBuilderTextField(
                          name: 'confirmPassword',
                          decoration: const InputDecoration(labelText: 'Potvrdi lozinku'),
                          obscureText: true,
                          validator: (val) {
                            final password = _passwordFormKey.currentState?.fields['newPassword']?.value;
                            if (val != password) return 'Lozinke se ne podudaraju';
                            return null;
                          },
                        ),
                        const SizedBox(height: 16),
                        ElevatedButton(
                          onPressed: _submitPasswordForm,
                          child: const Text("Promijeni lozinku"),
                        ),
                      ],
                    ),
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
