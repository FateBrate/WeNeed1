import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:playermobile/services/session_serivce.dart';


import '../models/squad.dart';
import '../models/user.dart';
import '../providers/squad_provider.dart';
import '../widgets/custom_snackbar.dart';
import '../widgets/master_screen.dart';
import 'member.dart';

class SquadMembersScreen extends StatefulWidget {
  final int squadId;

  const SquadMembersScreen({super.key, required this.squadId});

  @override
  State<SquadMembersScreen> createState() => _SquadMembersScreenState();
}

class _SquadMembersScreenState extends State<SquadMembersScreen> {
  late Future<Squad> _squadFuture;
  List<User> _members = [];
  int? _currentUserId;
  bool _isMember = false;
  bool _isLoadingAction = false;

  final SquadProvider _squadProvider = SquadProvider();

  @override
  void initState() {
    super.initState();
    _currentUserId = SessionService().playerId;
    _squadFuture = _loadSquad();
  }

  Future<Squad> _loadSquad() async {
    final squad = await _squadProvider.getById(widget.squadId);

    final List<User> members = squad.userSquads;

    setState(() {
      _members = members;
      _isMember = _currentUserId != null && members.any((u) => u.id == _currentUserId);
    });

    return squad;
  }

  Future<void> _joinSquad() async {
    setState(() => _isLoadingAction = true);
    try {
      await _squadProvider.joinSquad(widget.squadId);
      CustomSnackbar.show(context, "Uspješno ste se pridružili ekipi.", SnackbarType.success);
      setState(() {
        _squadFuture = _loadSquad();
      });
    } catch (e) {
      CustomSnackbar.show(context, "Greška pri pridruživanju ekipi: $e", SnackbarType.error);
    } finally {
      setState(() => _isLoadingAction = false);
    }
  }

  Future<void> _leaveSquad() async {
    setState(() => _isLoadingAction = true);
    try {
      await _squadProvider.leaveSquad(widget.squadId);
      CustomSnackbar.show(context, "Uspješno ste napustili ekipu.", SnackbarType.success);
      setState(() {
        _squadFuture = _loadSquad();
      });
    } catch (e) {
      CustomSnackbar.show(context, "Greška pri napuštanju ekipe: $e", SnackbarType.error);
    } finally {
      setState(() => _isLoadingAction = false);
    }
  }

  @override
  Widget build(BuildContext context) {
    return MobileMasterScreenWidget(
      title: 'Članovi ekipe',
      child: FutureBuilder<Squad>(
        future: _squadFuture,
        builder: (context, snapshot) {
          if (snapshot.connectionState == ConnectionState.waiting) {
            return const Center(child: CircularProgressIndicator());
          }
          if (snapshot.hasError) {
            return Center(child: Text('Greška: ${snapshot.error}'));
          }
          if (!snapshot.hasData) {
            return const Center(child: Text('Ekipa nije pronađena'));
          }


          return Column(
            children: [
              Expanded(
                child: ListView.separated(
                  itemCount: _members.length,
                  separatorBuilder: (_, __) => const Divider(color: Colors.white24),
                  itemBuilder: (context, index) {
                    final member = _members[index];
                    return ListTile(
                      leading: member.profilePicture != null && member.profilePicture!.isNotEmpty
                          ? CircleAvatar(
                        backgroundImage: MemoryImage(base64Decode(member.profilePicture!)),
                      )
                          : const CircleAvatar(child: Icon(Icons.person)),
                      title: Text(
                        '${member.firstName ?? ''} ${member.lastName ?? ''}',
                        style: const TextStyle(color: Colors.white),
                      ),
                      trailing: IconButton(
                        icon: const Icon(Icons.info_outline, color: Colors.white70),
                        onPressed: () {
                          Navigator.push(
                            context,
                            MaterialPageRoute(
                              builder: (_) => MemberScreen(userId: member.id!),
                            ),
                          );
                        },
                      ),
                    );
                  },
                ),
              ),

              const SizedBox(height: 16),

              _isLoadingAction
                  ? const CircularProgressIndicator()
                  : ElevatedButton(
                onPressed: _isMember ? _leaveSquad : _joinSquad,
                style: ElevatedButton.styleFrom(
                  padding: const EdgeInsets.symmetric(horizontal: 40, vertical: 15),
                ),
                child: Text(_isMember ? 'Napusti ekipu' : 'Pridruži se ekipi'),
              ),

              const SizedBox(height: 24),
            ],
          );
        },
      ),
    );
  }
}
