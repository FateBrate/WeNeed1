import 'package:flutter/material.dart';
import 'package:managerdesktop/screens/fields.dart';
import 'package:managerdesktop/screens/settings.dart';
import 'package:managerdesktop/screens/users_reservations.dart';

import '../screens/login.dart';

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
                child: ListView(
                    children: [
                        ListTile(
                            title: const Text('Nazad', style: TextStyle(color: Colors.white)),
                            onTap: () {
                                Navigator.of(context).push(
                                    MaterialPageRoute(
                                        builder: (context) => LoginPage(),
                                    ),
                                );
                            },
                        ),
                        ListTile(
                            title: const Text('Početna', style: TextStyle(color: Colors.white)),
                            onTap: (){
                                Navigator.of(context).push(
                                    MaterialPageRoute(builder: (context)=> FieldsScreen(),));
                            },
                        ),
                        ListTile(
                            title: const Text('Korisnici', style: TextStyle(color: Colors.white)),
                            onTap: () {
                                Navigator.of(context).push(
                                    MaterialPageRoute(builder: (context)=> ReservationScreen(),));
                            },
                        ),
                        ListTile(
                            title: const Text('Postavke', style: TextStyle(color: Colors.white)),
                            onTap: () {
                                Navigator.of(context).push(
                                    MaterialPageRoute(builder: (context)=> SettingsScreen(),));
                            },
                        )
                    ],
                ),
            ),
            body: widget.child!,
        );
    }
}
