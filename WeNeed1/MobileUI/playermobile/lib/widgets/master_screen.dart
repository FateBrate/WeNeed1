import 'package:flutter/material.dart';

import '../screens/login.dart';
import '../screens/team.dart';

class MobileMasterScreenWidget extends StatelessWidget {
  final String title;
  final Widget child;

  const MobileMasterScreenWidget({
    super.key,
    required this.title,
    required this.child,
  });

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text(title),
        backgroundColor: Colors.black,
      ),
      backgroundColor: const Color(0xFF121212),
      drawer: Drawer(
        backgroundColor: const Color(0xFF1E1E1E),
        child: Column(
          children: [
            const DrawerHeader(
              decoration: BoxDecoration(color: Colors.black),
              child: Align(
                alignment: Alignment.bottomLeft,
                child: Text(
                  'Meni',
                  style: TextStyle(color: Colors.white, fontSize: 24),
                ),
              ),
            ),
            Expanded(
              child: ListView(
                padding: EdgeInsets.zero,
                children: [
                  ListTile(
                    leading: const Icon(Icons.groups, color: Colors.white),
                    title: const Text('Timovi', style: TextStyle(color: Colors.white)),
                    onTap: () {
                      Navigator.pop(context);
                      Navigator.of(context).push(MaterialPageRoute(
                        builder: (context) => const TeamScreen(),
                      ));
                    },
                  ),
                  ListTile(
                    leading: const Icon(Icons.sports_soccer, color: Colors.white),
                    title: const Text('Sportski Centri', style: TextStyle(color: Colors.white)),
                    onTap: () {
                      Navigator.pop(context);
                    },
                  ),
                  ListTile(
                    leading: const Icon(Icons.person, color: Colors.white),
                    title: const Text('Profil', style: TextStyle(color: Colors.white)),
                    onTap: () {
                      Navigator.pop(context);
                      // Navigacija na Profil screen
                    },
                  ),
                ],
              ),
            ),
            const Divider(color: Colors.white24),
            ListTile(
              leading: const Icon(Icons.logout, color: Colors.redAccent),
              title: const Text('Odjava', style: TextStyle(color: Colors.redAccent)),
              onTap: () {
                Navigator.of(context).pushReplacement(MaterialPageRoute(
                  builder: (context) => const LoginPage(),
                ));
              },
            ),
            const SizedBox(height: 16),
          ],
        ),
      ),
      body: Padding(
        padding: const EdgeInsets.all(16.0),
        child: child,
      ),
    );
  }
}
