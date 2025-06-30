import 'dart:convert';

import 'package:flutter/material.dart';
import '../../models/user.dart';
import '../providers/user_provider.dart';
import '../services/sport_translation_service.dart';
import '../widgets/master_screen.dart';

class MemberScreen extends StatefulWidget {
  final int userId;
  const MemberScreen({super.key, required this.userId});

  @override
  State<MemberScreen> createState() => _MemberScreenState();
}

class _MemberScreenState extends State<MemberScreen> {
  User? _user;
  bool _isLoading = true;
  final  _userProvider = UserProvider();
  @override
  void initState() {
    super.initState();
    _loadUser();
  }

  Future<void> _loadUser() async {
    try {
      final user = await _userProvider.getById(widget.userId);
      setState(() {
        _user = user;
        _isLoading = false;
      });
    } catch (e) {
      setState(() {
        _isLoading = false;
      });
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(content: Text('Failed to load user: $e')),
      );
    }
  }

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

  @override
  Widget build(BuildContext context) {
    if (_isLoading) {
      return const Center(child: CircularProgressIndicator());
    }

    if (_user == null) {
      return Center(child: Text('User not found'));
    }

    return MobileMasterScreenWidget(
      title: '${_user!.firstName ?? ''} ${_user!.lastName ?? ''}',
      child: SingleChildScrollView(
        padding: const EdgeInsets.all(16),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.center,
          children: [
            Center(
              child: _user!.profilePicture != null && _user!.profilePicture!.isNotEmpty
                  ? CircleAvatar(
                radius: 60,
                backgroundImage: MemoryImage(base64Decode(_user!.profilePicture!)),
              )
                  : const CircleAvatar(
                radius: 60,
                child: Icon(Icons.person, size: 60),
              ),
            ),
            const SizedBox(height: 24),
            buildReadOnlyField('Ime', _user!.firstName),
            buildReadOnlyField('Prezime', _user!.lastName),
            buildReadOnlyField('Broj telefona', _user!.phoneNumber),
            buildReadOnlyField('Email', _user!.email),
            if (_user!.sports != null && _user!.sports!.isNotEmpty) ...[
              const SizedBox(height: 16),
              const Align(
                alignment: Alignment.centerLeft,
                child: Text("Sportovi", style: TextStyle(fontWeight: FontWeight.bold)),
              ),
              const SizedBox(height: 8),
              Align(
                alignment: Alignment.centerLeft,
                child: Wrap(
                  spacing: 8,
                  runSpacing: 4,
                  children: _user!.sports!.map((sportKey) {
                    return Chip(
                      label: Text(SportTranslationService.translate(sportKey)),
                    );
                  }).toList(),
                ),
              ),
            ],
          ],
        ),
      ),
    );
  }
}
