import 'package:flutter/material.dart';
import 'package:managerdesktop/screens/fields.dart';
import 'package:managerdesktop/screens/settings.dart';
import 'package:managerdesktop/screens/users_reservations.dart';

import '../screens/login.dart';
import '../screens/profile.dart';
import '../screens/report.dart';

class MasterScreenWidget extends StatefulWidget {
    final Widget? child;
    final String? title;
    final Widget? titleWidget;

    const MasterScreenWidget({
        this.child,
        this.title,
        this.titleWidget,
        super.key,
    });

    @override
    State<MasterScreenWidget> createState() => _MasterScreenWidgetState();
}

class _MasterScreenWidgetState extends State<MasterScreenWidget> {
    @override
    Widget build(BuildContext context) {
        return Scaffold(
            appBar: AppBar(
                title: widget.titleWidget ?? Text(widget.title ?? ""),
            ),
            drawer: Drawer(
                child: Container(
                    color: const Color(0xFF13151B),
                    child: Column(
                        children: [
                            const SizedBox(height: 40),
                            Padding(
                                padding: const EdgeInsets.symmetric(vertical: 16.0),
                                child: Column(
                                    children: [
                                        const Icon(Icons.manage_accounts_rounded, size: 48, color: Colors.white),
                                        const SizedBox(height: 8),
                                        const Text(
                                            'WeNeed1',
                                            style: TextStyle(
                                                fontSize: 20,
                                                color: Colors.white,
                                                fontWeight: FontWeight.bold,
                                                letterSpacing: 1.2,
                                            ),
                                        ),
                                    ],
                                ),
                            ),
                            const Divider(color: Colors.white54),
                            Expanded(
                                child: ListView(
                                    padding: const EdgeInsets.symmetric(vertical: 8),
                                    children: [
                                        ListTile(
                                            leading: const Icon(Icons.sports_soccer, color: Colors.white),
                                            title: const Text('Tereni', style: TextStyle(color: Colors.white)),
                                            onTap: () {
                                                Navigator.of(context).push(MaterialPageRoute(builder: (context) => FieldsScreen()));
                                            },
                                        ),
                                        ListTile(
                                            leading: const Icon(Icons.people, color: Colors.white),
                                            title: const Text('Korisnici i Rezervacije', style: TextStyle(color: Colors.white)),
                                            onTap: () {
                                                Navigator.of(context).push(MaterialPageRoute(builder: (context) => ReservationScreen()));
                                            },
                                        ),
                                        ListTile(
                                            leading: const Icon(Icons.bar_chart, color: Colors.white),
                                            title: const Text('Izvještaji', style: TextStyle(color: Colors.white)),
                                            onTap: () {
                                                Navigator.of(context).push(MaterialPageRoute(builder: (context) => ReportScreen()));
                                            },
                                        ),
                                        ListTile(
                                            leading: const Icon(Icons.settings, color: Colors.white),
                                            title: const Text('Postavke Sportskog Centra', style: TextStyle(color: Colors.white)),
                                            onTap: () {
                                                Navigator.of(context).push(MaterialPageRoute(builder: (context) => SettingsScreen()));
                                            },
                                        ),
                                        ListTile(
                                            leading: const Icon(Icons.person, color: Colors.white),
                                            title: const Text('Profil', style: TextStyle(color: Colors.white)),
                                            onTap: () {
                                                Navigator.of(context).push(MaterialPageRoute(builder: (context) => ProfileScreen()));
                                            },
                                        ),
                                    ],
                                ),
                            ),
                            const Divider(color: Colors.white54),
                            Padding(
                                padding: const EdgeInsets.symmetric(vertical: 8.0),
                                child: Column(
                                    children: [
                                        const Text(
                                            'WeNeed1 © 2025',
                                            style: TextStyle(color: Colors.white70, fontSize: 12),
                                        ),
                                        const SizedBox(height: 8),
                                        ListTile(
                                            leading: const Icon(Icons.logout, color: Colors.white),
                                            title: const Text('Odjava', style: TextStyle(color: Colors.white)),
                                            onTap: () {
                                                Navigator.of(context).pushReplacement(
                                                    MaterialPageRoute(builder: (context) => LoginPage()),
                                                );
                                            },
                                        ),
                                    ],
                                ),
                            ),
                            const SizedBox(height: 12),
                        ],
                    ),
                ),
            ),
            body: widget.child!,
        );
    }
}
