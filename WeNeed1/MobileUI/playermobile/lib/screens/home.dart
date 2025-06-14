import 'dart:convert';
import 'package:flutter/material.dart';
import '../models/user.dart';
import '../providers/user_provider.dart';
import '../widgets/master_screen.dart';

class HomePage extends StatefulWidget {
  const HomePage({super.key});

  @override
  State<HomePage> createState() => _HomePageState();
}

class _HomePageState extends State<HomePage> {
  User? _user;

  @override
  void initState() {
    super.initState();
    _loadProfile();
  }

  Future<void> _loadProfile() async {
    var user = await UserProvider().getProfile();
    setState(() {
      _user = user;
    });
  }

  @override
  Widget build(BuildContext context) {
    return MobileMasterScreenWidget(
      title: "Početna",
      child: _user == null
          ? const Center(child: CircularProgressIndicator())
          : SingleChildScrollView(
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            // Profile Image & Welcome
            Row(
              children: [
                ClipRRect(
                  borderRadius: BorderRadius.circular(30),
                  child: _user!.profilePicture != null &&
                      _user!.profilePicture!.isNotEmpty
                      ? Image.memory(
                    base64Decode(_user!.profilePicture!),
                    width: 60,
                    height: 60,
                    fit: BoxFit.cover,
                  )
                      : Image.asset(
                    "assets/images/placeholder_field.jpg",
                    width: 60,
                    height: 60,
                    fit: BoxFit.cover,
                  ),
                ),
                const SizedBox(width: 12),
                RichText(
                  text: TextSpan(
                    style: Theme.of(context)
                        .textTheme
                        .titleLarge!
                        .copyWith(color: Colors.white),
                    children: [
                      const TextSpan(text: "Dobrodošli, "),
                      TextSpan(
                        text: "${_user!.firstName} ${_user!.lastName}",
                        style:
                        const TextStyle(color: Colors.blueAccent),
                      ),
                    ],
                  ),
                ),
              ],
            ),
            const SizedBox(height: 20),

            // Played Terms
            const Text("Broj odigranih termina",
                style: TextStyle(fontSize: 16, color: Colors.white70)),
            const SizedBox(height: 4),
            const Text("25",
                style: TextStyle(
                    fontSize: 28,
                    fontWeight: FontWeight.bold,
                    color: Colors.white)),

            const SizedBox(height: 20),

            // Last Result
            Container(
              width: double.infinity,
              padding: const EdgeInsets.all(16),
              decoration: BoxDecoration(
                color: Colors.deepOrange[200],
                borderRadius: BorderRadius.circular(12),
              ),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: const [
                  Text(
                    "Rezultat posljednjeg termina",
                    style: TextStyle(
                        fontSize: 14, fontWeight: FontWeight.w600),
                  ),
                  SizedBox(height: 4),
                  Text(
                    "Poraz",
                    style: TextStyle(
                        fontSize: 20, fontWeight: FontWeight.bold),
                  ),
                  SizedBox(height: 4),
                  Text(
                    "Na datum\nJan 31, 2024",
                    style: TextStyle(fontSize: 14),
                  ),
                ],
              ),
            ),

            const SizedBox(height: 30),

            // Play Button Box
            Container(
              padding: const EdgeInsets.all(16),
              decoration: BoxDecoration(
                color: Colors.black87,
                borderRadius: BorderRadius.circular(12),
              ),
              child: Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: const [
                  Text(
                    "Pronađi novi team i zakaži termin",
                    style:
                    TextStyle(fontSize: 16, color: Colors.white70),
                  ),
                  Icon(
                    Icons.play_arrow,
                    color: Colors.blueAccent,
                    size: 32,
                  )
                ],
              ),
            )
          ],
        ),
      ),
    );
  }
}
