import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:form_builder_validators/form_builder_validators.dart';
import 'package:managerdesktop/widgets/custom_snackbar.dart';

import '../providers/sport_center_provider.dart';
import '../providers/user_provider.dart';
import '../services/session_serivce.dart';
import '../utils/utils.dart';
import 'fields.dart';
import 'login.dart';

class RegisterPage extends StatefulWidget {
  const RegisterPage({super.key});

  @override
  State<RegisterPage> createState() => _RegisterPageState();
}

class _RegisterPageState extends State<RegisterPage> {
  final _formKey = GlobalKey<FormBuilderState>();
  final _userProvider = UserProvider();
  bool _isLoading = false;

  Future<void> _register() async {
    if (_formKey.currentState?.saveAndValidate() ?? false) {
      final formData = _formKey.currentState!.value;

      if (formData['password'] != formData['confirmPassword']) {
        _showErrorDialog('Lozinke se ne podudaraju.');
        return;
      }

      final payload = {
        "firstName": formData['firstName'],
        "lastName": formData['lastName'],
        "email": formData['email'],
        "userName": formData['userName'],
        "phoneNumber": formData['phoneNumber'],
        "profilePicture": formData['profilePicture'] ?? '',
        "role": "MANAGER",
        "password": formData['password'],
        "confirmPassword": formData['confirmPassword']
      };

      setState(() => _isLoading = true);

      try {
        await _userProvider.insert(payload);
        Authorization.username = formData['userName'];
        Authorization.password = formData['password'];
        var sportsCenterProvider = SportsCenterProvider();
        var sportsCenter = await sportsCenterProvider.getMySportsCenter();
        SessionService().sportsCenterId = sportsCenter.id;

        if (!mounted) return;
        Navigator.pushReplacement(
          context,
          MaterialPageRoute(builder: (context) => const FieldsScreen()),
        );

        CustomSnackbar.show(context, 'Uspjesna registracija', SnackbarType.success);
      } catch (e) {
        CustomSnackbar.show(context, 'Greška pri registraciji', SnackbarType.error);
      } finally {
        setState(() => _isLoading = false);
      }
    }
  }

  void _showErrorDialog(String message) {
    showDialog(
      context: context,
      builder: (_) => AlertDialog(
        title: const Text("Greška"),
        content: Text(message),
        actions: [
          TextButton(
            onPressed: () => Navigator.pop(context),
            child: const Text("Uredu"),
          ),
        ],
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Padding(
        padding: const EdgeInsets.all(24.0),
        child: Center(
          child: SingleChildScrollView(
            child: Column(
              children: [
                Image.asset(
                  'assets/images/loginlogo.png',
                  height: 150,
                ),
                const SizedBox(height: 30),
                const Text(
                  "Registracija Menadžera",
                  style: TextStyle(fontSize: 24, fontWeight: FontWeight.bold),
                ),
                const SizedBox(height: 20),
                SizedBox(
                  width: 500,
                  child: FormBuilder(
                    key: _formKey,
                    child: Column(
                      children: [
                        FormBuilderTextField(
                          name: 'firstName',
                          decoration: const InputDecoration(
                            labelText: 'Ime',
                            border: OutlineInputBorder(),
                          ),
                          validator: FormBuilderValidators.required(errorText: 'Obavezno polje'),
                        ),
                        const SizedBox(height: 16),
                        FormBuilderTextField(
                          name: 'lastName',
                          decoration: const InputDecoration(
                            labelText: 'Prezime',
                            border: OutlineInputBorder(),
                          ),
                          validator: FormBuilderValidators.required(errorText: 'Obavezno polje'),
                        ),
                        const SizedBox(height: 16),
                        FormBuilderTextField(
                          name: 'email',
                          decoration: const InputDecoration(
                            labelText: 'Email',
                            border: OutlineInputBorder(),
                          ),
                          validator: FormBuilderValidators.compose([
                            FormBuilderValidators.required(errorText: 'Obavezno polje'),
                            FormBuilderValidators.email(errorText: 'Neispravan format'),
                          ]),
                        ),
                        const SizedBox(height: 16),
                        FormBuilderTextField(
                          name: 'userName',
                          decoration: const InputDecoration(
                            labelText: 'Korisničko ime',
                            border: OutlineInputBorder(),
                          ),
                          validator: FormBuilderValidators.required(errorText: 'Obavezno polje'),
                        ),
                        const SizedBox(height: 16),
                        FormBuilderTextField(
                          name: 'phoneNumber',
                          decoration: const InputDecoration(
                            labelText: 'Broj telefona',
                            border: OutlineInputBorder(),
                          ),
                          validator: FormBuilderValidators.compose([
                            FormBuilderValidators.required(errorText: "Obavezno polje"),
                            FormBuilderValidators.match(
                              RegExp(r'^\+?\d{6,15}$'),
                              errorText: 'Neispravan format broja',
                            ),
                          ]),
                        ),
                        const SizedBox(height: 16),
                        const SizedBox(height: 16),
                        FormBuilderTextField(
                          name: 'password',
                          obscureText: true,
                          decoration: const InputDecoration(
                            labelText: 'Lozinka',
                            border: OutlineInputBorder(),
                          ),
                          validator: FormBuilderValidators.compose([
                            FormBuilderValidators.required(errorText: 'Obavezno polje'),
                            FormBuilderValidators.minLength(8, errorText: 'Lozinka mora imati najmanje 8 znakova'),
                          ]),
                        ),
                        const SizedBox(height: 16),
                        FormBuilderTextField(
                          name: 'confirmPassword',
                          obscureText: true,
                          decoration: const InputDecoration(
                            labelText: 'Potvrdi lozinku',
                            border: OutlineInputBorder(),
                          ),
                          validator: FormBuilderValidators.compose([
                            FormBuilderValidators.required(errorText: 'Obavezno polje'),
                            FormBuilderValidators.minLength(8, errorText: 'Lozinka mora imati najmanje 8 znakova'),
                          ]),
                        ),
                        const SizedBox(height: 30),
                        _isLoading
                            ? const CircularProgressIndicator()
                            : ElevatedButton(
                          onPressed: _register,
                          style: ElevatedButton.styleFrom(
                            padding: const EdgeInsets.symmetric(
                                horizontal: 50, vertical: 15),
                            textStyle: const TextStyle(fontSize: 18),
                          ),
                          child: const Text("Registruj se"),
                        ),
                        Row(
                          mainAxisAlignment: MainAxisAlignment.center,
                          children: [
                            const Text("Već imate račun?"),
                            TextButton(
                              onPressed: () {
                                Navigator.of(context).pushReplacement(
                                  MaterialPageRoute(builder: (context) => const LoginPage()),
                                );
                              },
                              child: const Text(
                                "Prijavite se.",
                                style: TextStyle(fontWeight: FontWeight.bold),
                              ),
                            ),
                          ],
                        ),
                      ],
                    ),
                  ),
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }
}