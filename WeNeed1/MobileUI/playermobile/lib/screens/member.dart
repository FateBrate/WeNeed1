import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:playermobile/screens/team_details.dart';
import '../../models/user.dart';
import '../../models/team.dart';
import '../services/sport_translation_service.dart';
import '../widgets/master_screen.dart';
import '../providers/user_provider.dart';
import '../providers/team_provider.dart';

class MemberScreen extends StatefulWidget {
  final int userId;
  const MemberScreen({super.key, required this.userId});

  @override
  State<MemberScreen> createState() => _MemberScreenState();
}

class _MemberScreenState extends State<MemberScreen> {
  final _userProvider = UserProvider();
  final _teamProvider = TeamProvider();

  User? _user;
  List<Team> _teams = [];
  bool _isLoading = true;

  @override
  void initState() {
    super.initState();
    _loadData();
  }

  Future<void> _loadData() async {
    try {
      final user = await _userProvider.getById(widget.userId);
      final teamResult = await _teamProvider.get(filter: {'userId': widget.userId, 'isPublic': true});
      setState(() {
        _user = user;
        _teams = teamResult.result;
        _isLoading = false;
      });
    } catch (e) {
      setState(() => _isLoading = false);
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(content: Text('Greška prilikom učitavanja: $e')),
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
      return const Center(child: Text('Korisnik nije pronađen'));
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
            if (_teams.isNotEmpty) ...[
              const SizedBox(height: 24),
              const Align(
                alignment: Alignment.centerLeft,
                child: Text("Timovi", style: TextStyle(fontWeight: FontWeight.bold)),
              ),
              const SizedBox(height: 8),
              Wrap(
                spacing: 8,
                runSpacing: 8,
                children: _teams.map((team) {
                  return GestureDetector(
                    onTap: () {
                      Navigator.push(
                        context,
                        MaterialPageRoute(
                          builder: (_) => TeamDetailsScreen(teamId: team.id!),
                        ),
                      );
                    },
                    child: Container(
                      width: 80,
                      height: 80,
                      decoration: BoxDecoration(
                        borderRadius: BorderRadius.circular(8),
                        color: Colors.grey.shade200,
                        image: team.teamPicture != null
                            ? DecorationImage(
                          image: MemoryImage(base64Decode(team.teamPicture!)),
                          fit: BoxFit.cover,
                        )
                            : null,
                      ),
                      child: team.teamPicture == null
                          ? const Center(child: Icon(Icons.group, size: 32, color: Colors.grey))
                          : null,
                    ),
                  );
                }).toList(),
              ),
            ]
          ],
        ),
      ),
    );
  }
}
