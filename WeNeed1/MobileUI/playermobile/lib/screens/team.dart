import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:playermobile/widgets/master_screen.dart';
import 'package:provider/provider.dart';
import '../../models/team.dart';
import '../../providers/team_provider.dart';
import '../services/session_serivce.dart';

class TeamScreen extends StatefulWidget {
  const TeamScreen({super.key});

  @override
  State<TeamScreen> createState() => _TeamScreenState();
}

class _TeamScreenState extends State<TeamScreen> {
  List<Team> teams = [];
  bool isLoading = true;

  @override
  void initState() {
    super.initState();
    loadTeams();
  }

  Future<void> loadTeams() async {
    final teamProvider = context.read<TeamProvider>();
    final userId = SessionService().playerId;

    var data = await teamProvider.get(filter: {
      'userId': userId,
      'notMember': false,
    });

    setState(() {
       teams = data.result;
      isLoading = false;
    });
  }

  @override
  Widget build(BuildContext context) {
    return MobileMasterScreenWidget(
      title: "Timovi",
      child: isLoading
          ? const Center(child: CircularProgressIndicator())
          : Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          const SizedBox(height: 16),
          Row(
            children: [
              ElevatedButton(
                onPressed: () {
                  // TODO: Implement search
                },
                child: const Text("Pretraga"),
              ),
              const SizedBox(width: 16),
              ElevatedButton(
                onPressed: () {
                  // TODO: Implement create team
                },
                child: const Text("Kreiraj tim"),
              ),
            ],
          ),
          const SizedBox(height: 16),
          Expanded(
            child: ListView.builder(
              itemCount: teams.length,
              itemBuilder: (context, index) {
                final team = teams[index];
                return Card(
                  shape: RoundedRectangleBorder(
                    borderRadius: BorderRadius.circular(12),
                  ),
                  margin: const EdgeInsets.symmetric(vertical: 8),
                  child: ListTile(
                    leading: ClipRRect(
                      borderRadius: BorderRadius.circular(8),
                      child: team.teamPicture != null &&
                          team.teamPicture!.isNotEmpty
                          ? Image.memory(
                        base64Decode(team.teamPicture!),
                        width: 50,
                        height: 50,
                        fit: BoxFit.cover,
                      )
                          : Image.asset(
                        "assets/images/placeholder_field.jpg",
                        width: 50,
                        height: 50,
                        fit: BoxFit.cover,
                      ),
                    ),
                    title: Text(team.name ?? 'N/A'),
                    subtitle: Text(
                        "Sport: ${team.sport ?? 'N/A'}\nČlanova: ${team.memberCount ?? 0}"),
                    onTap: () {
                      // TODO: Show team details
                    },
                  ),
                );
              },
            ),
          ),
        ],
      ),
    );
  }
}
