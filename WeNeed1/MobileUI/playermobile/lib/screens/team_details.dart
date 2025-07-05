import 'dart:convert';

import 'package:flutter/material.dart';
import 'package:playermobile/providers/team_provider.dart';
import 'package:playermobile/screens/squad.dart';
import 'package:playermobile/screens/team.dart';
import 'package:playermobile/screens/team_form.dart';
import 'package:playermobile/screens/team_members.dart';

import '../../models/team.dart';
import '../../services/session_serivce.dart';
import '../widgets/custom_snackbar.dart';
import '../widgets/master_screen.dart';
import 'game.dart';

class TeamDetailsScreen extends StatefulWidget {
  final int teamId;

  const TeamDetailsScreen({super.key, required this.teamId});

  @override
  State<TeamDetailsScreen> createState() => _TeamDetailsScreenState();
}

class _TeamDetailsScreenState extends State<TeamDetailsScreen> {
  final TeamProvider _teamService = TeamProvider();

  bool _isLoading = true;
  bool _isProcessing = false;
  Team? _team;
  String? _error;

  int? _currentUserId;
  bool get isCaptain =>
      _team?.captainId != null && _currentUserId == _team!.captainId;

  @override
  void initState() {
    super.initState();
    _currentUserId = SessionService().playerId;
    _loadTeamDetails();
  }

  Future<void> _loadTeamDetails() async {
    setState(() {
      _isLoading = true;
      _error = null;
    });
    try {
      var team = await _teamService.getById(widget.teamId);
      setState(() {
        _team = team;
        _isLoading = false;
      });
    } catch (e) {
      setState(() {
        _error = 'Greška pri učitavanju tima: $e';
        _isLoading = false;
      });
    }
  }

  Future<void> _joinTeam() async {
    setState(() {
      _isProcessing = true;
    });

    try {
      await _teamService.joinTeam(widget.teamId);
      await _loadTeamDetails();

      CustomSnackbar.show(context, 'Uspješno ste se pridružili timu.', SnackbarType.success);
    } catch (e) {
      CustomSnackbar.show(context, 'Greška pri pridruživanju timu: $e', SnackbarType.error);
    } finally {
      setState(() {
        _isProcessing = false;
      });
    }
  }
  Future<void> _deleteTeam() async {
    final confirm = await showDialog<bool>(
      context: context,
      builder: (_) => AlertDialog(
        title: const Text('Potvrda brisanja'),
        content: const Text('Da li ste sigurni da želite obrisati ovaj tim?'),
        actions: [
          TextButton(
            onPressed: () => Navigator.pop(context, false),
            child: const Text('Ne'),
          ),
          TextButton(
            onPressed: () => Navigator.pop(context, true),
            child: const Text('Da'),
          ),
        ],
      ),
    );

    if (confirm != true) return;

    setState(() {
      _isProcessing = true;
    });

    try {
      await _teamService.delete(widget.teamId);

      if (mounted) {
        CustomSnackbar.show(context, 'Tim je uspješno obrisan.', SnackbarType.success);

        Navigator.pushAndRemoveUntil(
          context,
          MaterialPageRoute(builder: (_) => const TeamScreen()),
              (route) => false,
        );
      }
    } catch (e) {
      setState(() {
        _isProcessing = false;
      });

      CustomSnackbar.show(context, 'Greška pri brisanju tima: $e', SnackbarType.error);
    }
  }


  Future<void> _leaveTeam() async {
    final confirm = await showDialog<bool>(
      context: context,
      builder: (_) => AlertDialog(
        title: const Text('Potvrda napuštanja'),
        content: const Text('Da li želite napustiti ovaj tim?'),
        actions: [
          TextButton(
            onPressed: () => Navigator.pop(context, false),
            child: const Text('Ne'),
          ),
          TextButton(
            onPressed: () => Navigator.pop(context, true),
            child: const Text('Da'),
          ),
        ],
      ),
    );

    if (confirm != true) return;

    setState(() {
      _isProcessing = true;
    });

    try {
      await _teamService.leaveTeam(widget.teamId);

      if (mounted) {
        CustomSnackbar.show(context, 'Uspješno ste napustili tim.', SnackbarType.success);

        Navigator.pushAndRemoveUntil(
          context,
          MaterialPageRoute(builder: (_) => const TeamScreen()),
              (route) => false,
        );
      }
    } catch (e) {
      setState(() {
        _isProcessing = false;
      });

      CustomSnackbar.show(context, 'Greška pri napuštanju tima: $e', SnackbarType.error);
    }
  }


  @override
  Widget build(BuildContext context) {
    if (_isLoading) {
      return MobileMasterScreenWidget(
        title: 'Detalji tima',
        child: const Center(child: CircularProgressIndicator()),
      );
    }

    if (_error != null) {
      return MobileMasterScreenWidget(
        title: 'Detalji tima',
        child: Center(child: Text(_error!)),
      );
    }

    if (_team == null) {
      return MobileMasterScreenWidget(
        title: 'Detalji tima',
        child: const Center(child: Text('Tim nije pronađen')),
      );
    }

    return MobileMasterScreenWidget(
      title: _team!.name ?? 'Detalji tima',
      child: SingleChildScrollView(
        child: Column(
          children: [
            _team!.teamPicture != null && _team!.teamPicture!.isNotEmpty
                ? ClipRRect(
                  borderRadius: BorderRadius.circular(12),
                  child: Image.memory(
                    base64Decode(_team!.teamPicture!),
                    width: 150,
                    height: 150,
                    fit: BoxFit.cover,
                  ),
                )
                : Container(
                  width: 150,
                  height: 150,
                  decoration: BoxDecoration(
                    color: Colors.grey.shade300,
                    borderRadius: BorderRadius.circular(12),
                  ),
                  child: const Icon(Icons.group, size: 80, color: Colors.white),
                ),
            const SizedBox(height: 16),
            Text(
              _team!.name ?? 'N/A',
              style: const TextStyle(
                fontSize: 24,
                fontWeight: FontWeight.bold,
                color: Colors.white,
              ),
            ),
            const SizedBox(height: 4),
            if (isCaptain)
              Container(
                padding: const EdgeInsets.symmetric(horizontal: 8, vertical: 4),
                decoration: BoxDecoration(
                  color: Colors.blueAccent,
                  borderRadius: BorderRadius.circular(8),
                ),
                child: const Text(
                  'Kapiten',
                  style: TextStyle(
                    color: Colors.white,
                    fontWeight: FontWeight.bold,
                  ),
                ),
              ),
            const SizedBox(height: 8),
            Text(
              'Sport: ${SportTranslationService.translate(_team!.sport)}',
              style: const TextStyle(fontSize: 18, color: Colors.white),
            ),
            const SizedBox(height: 8),
            Text(
              'Broj članova: ${_team!.memberCount ?? 0}',
              style: const TextStyle(fontSize: 18, color: Colors.white),
            ),
            if (_team!.isPublic == false && _team!.joinCode != null)
              Padding(
                padding: const EdgeInsets.only(top: 12),
                child: Row(
                  mainAxisAlignment: MainAxisAlignment.center,
                  children: [
                    const Icon(Icons.qr_code, color: Colors.white70),
                    const SizedBox(width: 8),
                    Text(
                      'Kod za pristup: ${_team!.joinCode!}',
                      style: const TextStyle(fontSize: 16, color: Colors.white),
                    ),
                  ],
                ),
              ),

            const SizedBox(height: 24),
            if (_isProcessing) const CircularProgressIndicator(),
            if (!_isProcessing)
              Wrap(
                spacing: 12,
                children: [
                  if (isCaptain) ...[
                    ElevatedButton.icon(
                      icon: const Icon(Icons.edit, color: Colors.white),
                      label: const Text(
                        'Uredi tim',
                        style: TextStyle(color: Colors.white),
                      ),
                      onPressed: () {
                        Navigator.push(
                          context,
                          MaterialPageRoute(
                            builder: (_) => TeamFormScreen(existingTeam: _team),
                          ),
                        );
                      },
                      style: ElevatedButton.styleFrom(
                        backgroundColor: Colors.blue,
                      ),
                    ),
                    ElevatedButton.icon(
                      icon: const Icon(Icons.delete, color: Colors.white),
                      label: const Text(
                        'Obriši tim',
                        style: TextStyle(color: Colors.white),
                      ),
                      onPressed: _deleteTeam,
                      style: ElevatedButton.styleFrom(
                        backgroundColor: Colors.red,
                      ),
                    ),
                  ] else if (_team!.isMember) ...[
                    ElevatedButton.icon(
                      icon: const Icon(Icons.exit_to_app, color: Colors.white),
                      label: const Text(
                        'Napusti tim',
                        style: TextStyle(color: Colors.white),
                      ),
                      onPressed: _leaveTeam,
                      style: ElevatedButton.styleFrom(
                        backgroundColor: Colors.orange,
                      ),
                    ),
                  ] else ...[
                    ElevatedButton.icon(
                      icon: const Icon(Icons.group_add, color: Colors.white),
                      label: const Text(
                        'Pridruži se timu',
                        style: TextStyle(color: Colors.white),
                      ),
                      onPressed: _joinTeam,
                      style: ElevatedButton.styleFrom(
                        backgroundColor: Colors.green,
                      ),
                    ),
                  ],
                ],
              ),

            const SizedBox(height: 24),
            const Divider(color: Colors.white24),
            if (_team!.isMember)
            ListTile(
              title: const Text(
                'Članovi tima',
                style: TextStyle(color: Colors.white),
              ),
              trailing: const Icon(Icons.arrow_forward, color: Colors.white),
              onTap: () {
                Navigator.push(
                  context,
                  MaterialPageRoute(
                    builder: (context) => TeamMembersScreen(teamId: _team!.id!),
                  ),
                );
              },
            ),
            if (_team!.isMember)
            ListTile(
              title: const Text(
                'Ekipe',
                style: TextStyle(color: Colors.white),
              ),
              trailing: const Icon(Icons.arrow_forward, color: Colors.white),
              onTap: () {
                Navigator.push(
                  context,
                  MaterialPageRoute(
                    builder: (context) => SquadScreen(teamId: _team!.id!),
                  ),
                );
              },
            ),
            if (_team!.isMember)
              ListTile(
                title: const Text(
                  'Mečevi',
                  style: TextStyle(color: Colors.white),
                ),
                trailing: const Icon(Icons.arrow_forward, color: Colors.white),
                onTap: () {
                  Navigator.of(context).push(
                    MaterialPageRoute(
                      builder: (context) => GamesScreen(teamId: _team!.id!),
                    ),
                  );
                },
              ),

            if (_team!.description != null && _team!.description!.isNotEmpty)
              Padding(
                padding: const EdgeInsets.only(top: 16, left: 16, right: 16),
                child: Card(
                  color: Colors.blueGrey.shade700,
                  shape: RoundedRectangleBorder(
                    borderRadius: BorderRadius.circular(12),
                  ),
                  child: Padding(
                    padding: const EdgeInsets.all(16),
                    child: Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        const Text(
                          'Opis tima:',
                          style: TextStyle(
                            fontSize: 18,
                            fontWeight: FontWeight.bold,
                            color: Colors.white,
                          ),
                        ),
                        const SizedBox(height: 8),
                        Text(
                          _team!.description!,
                          style: const TextStyle(
                            fontSize: 16,
                            color: Colors.white,
                          ),
                        ),
                      ],
                    ),
                  ),
                ),
              ),

            const SizedBox(height: 40),
          ],
        ),
      ),
    );
  }
}
