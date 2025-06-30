import 'dart:convert';

import 'package:flutter/material.dart';
import '../../models/user.dart';
import '../widgets/master_screen.dart';

class MemberScreen extends StatelessWidget {
  final User user;

  const MemberScreen({super.key, required this.user});

  @override
  Widget build(BuildContext context) {
    Widget buildReadOnlyField(String label, String? value) {
      return Padding(
        padding: const EdgeInsets.symmetric(vertical: 8.0),
        child: TextFormField(
          initialValue: value ?? '',
          readOnly: true,
          decoration: InputDecoration(
            labelText: label,
            border: const OutlineInputBorder(),
            enabledBorder: OutlineInputBorder(
              borderSide: BorderSide(color: Colors.grey.shade400),
            ),
          ),
        ),
      );
    }

    return MobileMasterScreenWidget(
      title: '${user.firstName ?? ''} ${user.lastName ?? ''}',
      child: SingleChildScrollView(
        padding: const EdgeInsets.all(16),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.center,
          children: [
            Center(
              child: user.profilePicture != null && user.profilePicture!.isNotEmpty
                  ? CircleAvatar(
                radius: 60,
                backgroundImage: MemoryImage(base64Decode(user.profilePicture!)),
              )
                  : const CircleAvatar(
                radius: 60,
                child: Icon(Icons.person, size: 60),
              ),
            ),
            const SizedBox(height: 24),
            buildReadOnlyField('Ime', user.firstName),
            buildReadOnlyField('Prezime', user.lastName),
            buildReadOnlyField('Broj telefona', user.phoneNumber),
            buildReadOnlyField('Email', user.email),
          ],
        ),
      ),
    );
  }
}
