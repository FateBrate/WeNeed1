import 'dart:convert';

import 'package:flutter/material.dart';
import 'package:playermobile/screens/team_members.dart';
import '../../models/user.dart';
import '../providers/user_provider.dart';
import '../providers/team_provider.dart';
import '../widgets/master_screen.dart';
import '../widgets/custom_snackbar.dart';

class AddTeamMemberScreen extends StatefulWidget {
  final int teamId;

  const AddTeamMemberScreen({super.key, required this.teamId});

  @override
  State<AddTeamMemberScreen> createState() => _AddTeamMemberScreenState();
}

class _AddTeamMemberScreenState extends State<AddTeamMemberScreen> {
  final TextEditingController _searchController = TextEditingController();
  final UserProvider _userProvider = UserProvider();
  final TeamProvider _teamProvider = TeamProvider();

  List<User> _results = [];
  bool _isLoading = false;

  @override
  void initState() {
    super.initState();
    _loadUsers();
    _searchController.addListener(() {
      _searchUsers(_searchController.text);
    });
  }

  Future<void> _loadUsers() async {
    setState(() => _isLoading = true);
    try {
      final data = await _userProvider.get(filter: {
        'role': 'PLAYER',
        'ExcludeTeamId': widget.teamId.toString(),
      });
      setState(() {
        _results = data.result;
      });
    } catch (e) {
      CustomSnackbar.show(
          context, 'Greška pri učitavanju korisnika: $e', SnackbarType.error);
    } finally {
      setState(() => _isLoading = false);
    }
  }

  Future<void> _searchUsers(String query) async {
    if (query.isEmpty) {
      await _loadUsers();
      return;
    }
    setState(() => _isLoading = true);
    try {
      final data = await _userProvider.get(filter: {
        'fullName': query,
        'role': 'PLAYER',
        'ExcludeTeamId': widget.teamId.toString(),
      });
      setState(() {
        _results = data.result;
      });
    } catch (e) {
      CustomSnackbar.show(
          context, 'Greška pri pretrazi korisnika: $e', SnackbarType.error);
    } finally {
      setState(() => _isLoading = false);
    }
  }

  Future<void> _addUserToTeam(User userToAdd) async {
    try {
      await _teamProvider.addToTeam(widget.teamId, userToAdd.id!);
      CustomSnackbar.show(
          context, "Korisnik ${userToAdd.firstName} je uspješno dodat u tim",
          SnackbarType.success);

      Navigator.pushReplacement(
        context,
        MaterialPageRoute(
          builder: (_) => TeamMembersScreen(teamId: widget.teamId),
        ),
      );
    } catch (e) {
      CustomSnackbar.show(context, "Greška prilikom dodavanja korisnika: $e",
          SnackbarType.error);
    }
  }

  @override
  Widget build(BuildContext context) {
    return MobileMasterScreenWidget(
      title: "Dodaj člana",
      child: Padding(
        padding: const EdgeInsets.all(16),
        child: Column(
          children: [
            TextField(
              controller: _searchController,
              decoration: InputDecoration(
                labelText: "Ime ili prezime",
                suffixIcon: _searchController.text.isEmpty
                    ? null
                    : IconButton(
                  icon: const Icon(Icons.clear),
                  onPressed: () {
                    _searchController.clear();
                  },
                ),
              ),
            ),
            const SizedBox(height: 16),
            _isLoading
                ? const Center(child: CircularProgressIndicator())
                : Expanded(
              child: _results.isEmpty
                  ? const Center(child: Text('Nema rezultata pretrage'))
                  : ListView.separated(
                itemCount: _results.length,
                separatorBuilder: (_, __) =>
                const Divider(color: Colors.white24),
                itemBuilder: (context, index) {
                  final user = _results[index];
                  return ListTile(
                    leading: user.profilePicture != null &&
                        user.profilePicture!.isNotEmpty
                        ? CircleAvatar(
                      backgroundImage: MemoryImage(base64Decode(
                          user.profilePicture!)),
                    )
                        : const CircleAvatar(child: Icon(Icons.person)),
                    title: Text(
                        '${user.firstName ?? ''} ${user.lastName ?? ''}'),
                    trailing: IconButton(
                      icon: const Icon(Icons.person_add),
                      onPressed: () => _addUserToTeam(user),
                    ),
                  );
                },
              ),
            ),
          ],
        ),
      ),
    );
  }
}
