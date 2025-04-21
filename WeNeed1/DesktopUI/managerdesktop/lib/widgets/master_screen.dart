import 'package:flutter/material.dart';
import 'package:managerdesktop/screens/fields.dart';

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
                            title: Text('Nazad'),
                            onTap: () {
                                Navigator.of(context).push(
                                    MaterialPageRoute(
                                        builder: (context) => LoginPage(),
                                    ),
                                );
                            },
                        ),
                        ListTile(
                            title: Text('Početna'),
                            onTap: (){
                                Navigator.of(context).push(
                                    MaterialPageRoute(builder: (context)=> FieldsScreen(),));
                            },
                        )
                    ],
                ),
            ),
            body: widget.child!,
        );
    }
}
