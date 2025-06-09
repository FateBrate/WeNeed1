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
        Key? key,
    }) : super(key: key);

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
                    color: Color(0xFF13151B),
                    child: Column(
                        children: [
                            Expanded(
                                child: ListView(
                                    children: [
                                        ListTile(
                                            leading: Icon(Icons.sports_soccer, color: Colors.white),
                                            title: const Text('Tereni', style: TextStyle(color: Colors.white)),
                                            onTap: () {
                                                Navigator.of(context).push(MaterialPageRoute(builder: (context) => FieldsScreen()));
                                            },
                                        ),
                                        ListTile(
                                            leading: Icon(Icons.people, color: Colors.white),
                                            title: const Text('Korisnici i Rezervacije', style: TextStyle(color: Colors.white)),
                                            onTap: () {
                                                Navigator.of(context).push(MaterialPageRoute(builder: (context) => ReservationScreen()));
                                            },
                                        ),
                                        ListTile(
                                            leading: Icon(Icons.bar_chart, color: Colors.white),
                                            title: const Text('Izvještaji', style: TextStyle(color: Colors.white)),
                                            onTap: () {
                                                Navigator.of(context).push(MaterialPageRoute(builder: (context) => ReportScreen()));
                                            },
                                        ),
                                        ListTile(
                                            leading: Icon(Icons.settings, color: Colors.white),
                                            title: const Text('Postavke Sportskog Centra', style: TextStyle(color: Colors.white)),
                                            onTap: () {
                                                Navigator.of(context).push(MaterialPageRoute(builder: (context) => SettingsScreen()));
                                            },
                                        ),
                                        ListTile(
                                            leading: Icon(Icons.person, color: Colors.white),
                                            title: const Text('Profil', style: TextStyle(color: Colors.white)),
                                            onTap: () {
                                                Navigator.of(context).push(MaterialPageRoute(builder: (context) => ProfileScreen()));
                                            },
                                        ),
                                    ],
                                ),
                            ),
                            const Divider(color: Colors.white54),
                            ListTile(
                                leading: Icon(Icons.logout, color: Colors.white),
                                title: const Text('Odjava', style: TextStyle(color: Colors.white)),
                                onTap: () {
                                    Navigator.of(context).pushReplacement(MaterialPageRoute(builder: (context) => LoginPage()));
                                },
                            ),
                            const SizedBox(height: 20),
                        ],
                    ),
                ),
            ),
            body: widget.child!,
        );
    }
}
