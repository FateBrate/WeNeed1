import 'package:flutter/material.dart';
import 'package:playermobile/providers/user_provider.dart';
import 'package:playermobile/screens/register.dart';
import '../services/session_serivce.dart';
import '../utils/utils.dart';
import 'home.dart';

class LoginPage extends StatefulWidget {
  const LoginPage({super.key});

  @override
  State<LoginPage> createState() => _LoginPageState();
}

class _LoginPageState extends State<LoginPage> {
  final TextEditingController _usernameController = TextEditingController();
  final TextEditingController _passwordController = TextEditingController();
  bool _isLoading = false;

  Future<void> _login(BuildContext context) async {
    final username = _usernameController.text;
    final password = _passwordController.text;

    if (username.isEmpty || password.isEmpty) {
      _showErrorDialog("Unesite korisničko ime i lozinku.");
      return;
    }

    setState(() {
      _isLoading = true;
    });
    Authorization.username = username;
    Authorization.password = password;
    try {
      var userProvider = UserProvider();
      var user = await userProvider.getProfile();

      if (user.role != 'PLAYER') {
        _showErrorDialog("Niste ovlašteni za pristup ovoj aplikaciji.");
        return;
      }

      SessionService().playerId = user.id;

      Navigator.pushReplacement(
        context,
        MaterialPageRoute(builder: (context) => const HomePage()),
      );
    } catch (e) {
      _showErrorDialog("Nesupješna prijava. Unesite ispravne kredencijale.");
    } finally {
      setState(() {
        _isLoading = false;
      });
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
      body: Center(
        child: SingleChildScrollView(
          padding: const EdgeInsets.all(24.0),
          child: ConstrainedBox(
            constraints: const BoxConstraints(maxWidth: 400),
            child: Column(
              mainAxisAlignment: MainAxisAlignment.center,
              children: [
                Image.asset(
                  'assets/images/loginlogo.png',
                  height: 150,
                ),
                const SizedBox(height: 40),
                TextField(
                  controller: _usernameController,
                  decoration: const InputDecoration(
                    labelText: 'Korisničko ime',
                    prefixIcon: Icon(Icons.person),
                    border: OutlineInputBorder(),
                  ),
                ),
                const SizedBox(height: 20),
                TextField(
                  controller: _passwordController,
                  obscureText: true,
                  decoration: const InputDecoration(
                    labelText: 'Lozinka',
                    prefixIcon: Icon(Icons.lock),
                    border: OutlineInputBorder(),
                  ),
                ),
                const SizedBox(height: 30),
                _isLoading
                    ? const CircularProgressIndicator()
                    : ElevatedButton(
                  onPressed: () => _login(context),
                  style: ElevatedButton.styleFrom(
                    padding: const EdgeInsets.symmetric(
                        horizontal: 50, vertical: 15),
                    textStyle: const TextStyle(fontSize: 18),
                  ),
                  child: const Text("Prijava"),
                ),
                const SizedBox(height: 20),
                Wrap(
                  alignment: WrapAlignment.center,
                  spacing: 4,
                  children: [
                    const Text("Niste registrovani?"),
                    TextButton(
                      onPressed: () {
                        Navigator.push(
                          context,
                          MaterialPageRoute(
                              builder: (context) => const RegisterPage()),
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
        ),
      ),
    );
  }
}