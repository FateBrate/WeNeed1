import 'package:flutter/material.dart';
import 'package:managerdesktop/screens/register.dart';
import 'package:managerdesktop/services/session_serivce.dart';
import '../providers/sport_center_provider.dart';
import '../utils/utils.dart';
import '../widgets/custom_snackbar.dart';
import 'fields.dart';

class LoginPage extends StatefulWidget {
  const LoginPage({super.key});

  @override
  State<LoginPage> createState() => _LoginPageState();
}

class _LoginPageState extends State<LoginPage> {
  final _formKey = GlobalKey<FormState>();
  final TextEditingController _usernameController = TextEditingController();
  final TextEditingController _passwordController = TextEditingController();
  bool _isLoading = false;

  Future<void> _login(BuildContext context) async {
    if (!_formKey.currentState!.validate()) {
      CustomSnackbar.show(context, "Popunite sva obavezna polja", SnackbarType.error);
      return;
    }

    final username = _usernameController.text.trim();
    final password = _passwordController.text.trim();

    setState(() {
      _isLoading = true;
    });

    Authorization.username = username;
    Authorization.password = password;

    try {
      var sportsCenterProvider = SportsCenterProvider();
      var sportsCenter = await sportsCenterProvider.getMySportsCenter();

      SessionService().sportsCenterId = sportsCenter.id;

      Navigator.pushReplacement(
        context,
        MaterialPageRoute(builder: (context) => const FieldsScreen()),
      );
    } catch (e) {
      CustomSnackbar.show(context, "Neuspješna prijava. Unesite ispravne kredencijale.", SnackbarType.error);
    } finally {
      setState(() {
        _isLoading = false;
      });
    }
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
                  "Prijava",
                  style: TextStyle(fontSize: 24, fontWeight: FontWeight.bold),
                ),
                const SizedBox(height: 20),
                LayoutBuilder(
                  builder: (context, constraints) {
                    double maxWidth = constraints.maxWidth < 500 ? constraints.maxWidth : 500;
                    return SizedBox(
                      width: maxWidth,
                      child: Form(
                        key: _formKey,
                        child: Column(
                          children: [
                            TextFormField(
                              controller: _usernameController,
                              decoration: const InputDecoration(
                                labelText: 'Korisničko ime *',
                                prefixIcon: Icon(Icons.person),
                                border: OutlineInputBorder(),
                              ),
                              validator: (value) {
                                if (value == null || value.trim().isEmpty) {
                                  return 'Korisničko ime je obavezno';
                                }
                                return null;
                              },
                            ),
                            const SizedBox(height: 20),
                            TextFormField(
                              controller: _passwordController,
                              obscureText: true,
                              decoration: const InputDecoration(
                                labelText: 'Lozinka *',
                                prefixIcon: Icon(Icons.lock),
                                border: OutlineInputBorder(),
                              ),
                              validator: (value) {
                                if (value == null || value.trim().isEmpty) {
                                  return 'Lozinka je obavezna';
                                }
                                return null;
                              },
                            ),
                            const SizedBox(height: 30),
                            _isLoading
                                ? const CircularProgressIndicator()
                                : ElevatedButton(
                              onPressed: () => _login(context),
                              style: ElevatedButton.styleFrom(
                                padding: const EdgeInsets.symmetric(horizontal: 50, vertical: 15),
                                textStyle: const TextStyle(fontSize: 18),
                              ),
                              child: const Text("Prijava"),
                            ),
                            const SizedBox(height: 20),
                            Row(
                              mainAxisAlignment: MainAxisAlignment.center,
                              children: [
                                const Text("Nema registrovan nalog? "),
                                TextButton(
                                  onPressed: () {
                                    Navigator.push(
                                      context,
                                      MaterialPageRoute(builder: (context) => const RegisterPage()),
                                    );
                                  },
                                  child: const Text(
                                    "Registrujte se",
                                    style: TextStyle(fontWeight: FontWeight.bold),
                                  ),
                                ),
                              ],
                            ),
                          ],
                        ),
                      ),
                    );
                  },
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }
}
