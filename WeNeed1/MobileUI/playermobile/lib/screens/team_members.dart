import 'dart:convert';

import 'package:flutter/material.dart';
import '../../models/team.dart';
import '../../models/user.dart';
import '../providers/team_provider.dart';
import '../widgets/master_screen.dart';
import 'member.dart';

class TeamMembersScreen extends StatefulWidget {
  final int teamId;

  const TeamMembersScreen({super.key, required this.teamId});

  @override
  State<TeamMembersScreen> createState() => _TeamMembersScreenState();
}

class _TeamMembersScreenState extends State<TeamMembersScreen> {
  late Future<Team> _teamFuture;
  List<User> _members = [];

  @override
  void initState() {
    super.initState();
    _teamFuture = _loadTeam();
  }

  Future<Team> _loadTeam() async {
    final provider = TeamProvider();
    final rawJson = await provider.getByIdRaw(widget.teamId);

    final team = Team.fromJson(rawJson);

    final List<User> members =
        (rawJson['teamMembers'] as List<dynamic>?)
            ?.map((e) => User.fromJson(e as Map<String, dynamic>))
            .toList() ??
        [];

    setState(() {
      _members = members;
    });

    return team;
  }

  @override
  Widget build(BuildContext context) {
    return MobileMasterScreenWidget(
      title: 'Članovi tima',
      child: FutureBuilder<Team>(
        future: _teamFuture,
        builder: (context, snapshot) {
          if (snapshot.connectionState == ConnectionState.waiting) {
            return const Center(child: CircularProgressIndicator());
          }
          if (snapshot.hasError) {
            return Center(child: Text('Greška: ${snapshot.error}'));
          }
          if (!snapshot.hasData) {
            return const Center(child: Text('Tim nije pronađen'));
          }

          final team = snapshot.data!;
          final captainId = team.captainId;

          final members = List<User>.from(_members);
          members.sort((a, b) {
            if (a.id == captainId) return -1;
            if (b.id == captainId) return 1;
            return (a.firstName ?? '').compareTo(b.firstName ?? '');
          });

          return ListView.separated(
            itemCount: members.length,
            separatorBuilder: (_, __) => const Divider(color: Colors.white24),
            itemBuilder: (context, index) {
              final member = members[index];
              final isCaptain = member.id == captainId;

              return Padding(
                padding: const EdgeInsets.symmetric(horizontal: 16, vertical: 8),
                child: Row(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    Column(
                      children: [
                        member.profilePicture != null && member.profilePicture!.isNotEmpty
                            ? CircleAvatar(
                          radius: 24,
                          backgroundImage: MemoryImage(
                            base64Decode(member.profilePicture!),
                          ),
                        )
                            : const CircleAvatar(
                          radius: 24,
                          child: Icon(Icons.person),
                        ),
                        const SizedBox(height: 4),
                        Text(
                          isCaptain ? 'Kapiten' : 'Igrač',
                          style: TextStyle(
                            color: isCaptain ? Colors.amberAccent : Colors.white54,
                            fontStyle: FontStyle.italic,
                            fontSize: 12,
                          ),
                        ),
                      ],
                    ),
                    const SizedBox(width: 16),
                    Expanded(
                      child: Row(
                        children: [
                          Expanded(
                            child: Column(
                              crossAxisAlignment: CrossAxisAlignment.start,
                              children: [
                                Text(
                                  '${member.firstName ?? ''} ${member.lastName ?? ''}',
                                  style: TextStyle(
                                    color: isCaptain ? Colors.amberAccent : Colors.white,
                                    fontWeight: isCaptain ? FontWeight.bold : FontWeight.normal,
                                  ),
                                  overflow: TextOverflow.ellipsis,
                                ),
                                if (isCaptain)
                                  const Padding(
                                    padding: EdgeInsets.only(top: 2),
                                    child: Text(
                                      '(C)',
                                      style: TextStyle(
                                        color: Colors.amberAccent,
                                        fontSize: 12,
                                      ),
                                    ),
                                  ),
                              ],
                            ),
                          ),
                          IconButton(
                            icon: const Icon(Icons.info_outline,
                                color: Colors.white70, size: 24),
                            padding: EdgeInsets.zero,
                            constraints: const BoxConstraints(),
                            onPressed: () {
                              Navigator.push(
                                context,
                                MaterialPageRoute(
                                  builder: (_) => MemberScreen(userId: member.id!),
                                ),
                              );
                            },
                          ),
                        ],
                      ),
                    ),
                  ],
                ),
              );
            },
          );
        },
      ),
    );
  }
}
