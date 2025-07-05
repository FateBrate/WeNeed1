import 'package:flutter/material.dart';
import 'package:playermobile/models/match.dart';
import 'package:playermobile/models/match_Status.dart';
import 'package:playermobile/providers/match.dart';
import 'package:playermobile/widgets/master_screen.dart';

import '../widgets/custom_snackbar.dart';
import 'comments.dart';
import 'finish_cancel_game.dart';
import 'new_match.dart';

class GamesScreen extends StatefulWidget {
  final int teamId;
  const GamesScreen({super.key, required this.teamId});

  @override
  State<GamesScreen> createState() => _GamesScreenState();
}

class _GamesScreenState extends State<GamesScreen> {
  List<Game> games = [];
  MatchStatus? selectedStatus;
  bool showAll = true;
  final MatchProvider _gameProvider = MatchProvider();

  @override
  void initState() {
    super.initState();
    _fetchGames();
  }

  Future<void> _fetchGames() async {
    Map<String, String> filters = {
      'teamId': widget.teamId.toString(),
    };

    if (!showAll && selectedStatus != null) {
      filters['status'] = matchStatusToString(selectedStatus!);
    }

    final data = await _gameProvider.get(filter: filters);
    setState(() {
      games = data.result;
    });
  }

  void _setAttendance(Game game, bool isAttending) async {
    try {
      await _gameProvider.setAttendance(game.id, isAttending);
      CustomSnackbar.show(
        context,
        isAttending ? "Dolazak potvrđen." : "Dolazak otkazan.",
        SnackbarType.success,
      );
      _fetchGames();
    } catch (e) {
      CustomSnackbar.show(
        context,
        isAttending ? "Greška prilikom potvrde." : "Greška prilikom otkazivanja.",
        SnackbarType.error,
      );
    }
  }

  Color _getStatusColor(MatchStatus status) {
    switch (status) {
      case MatchStatus.CREATED:
        return Colors.green;
      case MatchStatus.FINISHED:
        return Colors.blue;
      case MatchStatus.CANCELLED:
        return Colors.red;
    }
  }

  @override
  Widget build(BuildContext context) {
    return MobileMasterScreenWidget(
      title: "Mečevi",

      child: Column(
        children: [
          Padding(
            padding: const EdgeInsets.symmetric(horizontal: 16, vertical: 8),
            child: Container(
              padding: const EdgeInsets.symmetric(horizontal: 12),
              decoration: BoxDecoration(
                color: Colors.grey[100],
                borderRadius: BorderRadius.circular(12),
                border: Border.all(color: Colors.grey),
              ),
              child: DropdownButton<MatchStatus?>(
                isExpanded: true,
                value: selectedStatus,
                underline: const SizedBox(),
                hint: const Text(
                  "Status meča",
                  style: TextStyle(color: Colors.black87),
                ),
                style: const TextStyle(
                  color: Colors.green,
                  fontSize: 16,
                ),
                items: [
                  const DropdownMenuItem<MatchStatus?>(
                    value: null,
                    child: Text("Svi mečevi"),
                  ),
                  ...MatchStatus.values.map((status) {
                    return DropdownMenuItem<MatchStatus?>(
                      value: status,
                      child: Text(status.bosanski),
                    );
                  }).toList(),
                ],
                onChanged: (value) {
                  setState(() {
                    selectedStatus = value;
                    showAll = value == null;
                  });
                  _fetchGames();
                },
              ),
            ),
          ),
          const SizedBox(height: 16),
          Padding(
            padding: const EdgeInsets.symmetric(horizontal: 16),
            child: ElevatedButton.icon(
              icon: const Icon(Icons.add),
              label: const Text("Novi meč"),
              onPressed: () {
                Navigator.push(
                  context,
                  MaterialPageRoute(
                    builder: (context) => NewMatchScreen(teamId: widget.teamId),
                  ),
                ).then((value) {
                  if (value == true) {
                    _fetchGames();
                  }
                });
              },
            ),
          ),

          const SizedBox(height: 16),
          Expanded(
            child: games.isEmpty
                ? const Center(
              child: Text(
                "Nema mečeva.",
                style: TextStyle(fontSize: 16, color: Colors.grey),
              ),
            )
                : ListView.separated(
              padding: const EdgeInsets.symmetric(horizontal: 16),
              itemCount: games.length,
              separatorBuilder: (context, index) => const SizedBox(height: 12),
              itemBuilder: (context, index) {
                final game = games[index];
                return Card(
                  elevation: 2,
                  shape: RoundedRectangleBorder(
                    borderRadius: BorderRadius.circular(12),
                  ),
                  child: Padding(
                    padding: const EdgeInsets.all(16),
                    child: Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        Row(
                          mainAxisAlignment: MainAxisAlignment.spaceBetween,
                          children: [
                            Expanded(
                              child: Text(
                                '${game.matchDate?.day}.${game.matchDate?.month}.${game.matchDate?.year} u ${game.matchDate?.hour}:${game.matchDate?.minute.toString().padLeft(2, '0')}',
                                style: const TextStyle(
                                  fontSize: 16,
                                  fontWeight: FontWeight.bold,
                                ),
                              ),
                            ),
                            Container(
                              padding: const EdgeInsets.symmetric(horizontal: 12, vertical: 4),
                              decoration: BoxDecoration(
                                color: _getStatusColor(game.status!).withOpacity(0.2),
                                borderRadius: BorderRadius.circular(20),
                                border: Border.all(
                                  color: _getStatusColor(game.status!),
                                  width: 1,
                                ),
                              ),
                              child: Text(
                                game.status!.bosanski,
                                style: TextStyle(
                                  color: _getStatusColor(game.status!),
                                  fontWeight: FontWeight.bold,
                                ),
                              ),
                            ),
                          ],
                        ),
                        const SizedBox(height: 12),
                        if (game.status == MatchStatus.FINISHED)
                          Padding(
                            padding: const EdgeInsets.only(bottom: 8),
                            child: Text(
                              'Rezultat: ${game.result ?? "Nije unesen"}',
                              style: const TextStyle(
                                fontSize: 15,
                                fontWeight: FontWeight.w500,
                              ),
                            ),
                          ),
                        if (game.attendingCount != null)
                          Padding(
                            padding: const EdgeInsets.only(bottom: 4),
                            child: Row(
                              children: [
                                const Icon(Icons.check_circle, color: Colors.green, size: 16),
                                const SizedBox(width: 4),
                                Text(
                                  '${game.attendingCount} potvrdili dolazak',
                                  style: const TextStyle(
                                    color: Colors.green,
                                    fontSize: 14,
                                  ),
                                ),
                              ],
                            ),
                          ),
                        if (game.notAttendingCount != null)
                          Padding(
                            padding: const EdgeInsets.only(bottom: 8),
                            child: Row(
                              children: [
                                const Icon(Icons.cancel, color: Colors.red, size: 16),
                                const SizedBox(width: 4),
                                Text(
                                  '${game.notAttendingCount} odbili dolazak',
                                  style: const TextStyle(
                                    color: Colors.red,
                                    fontSize: 14,
                                  ),
                                ),
                              ],
                            ),
                          ),
                        Row(
                          mainAxisAlignment: MainAxisAlignment.end,
                          children: [
                            if (game.status == MatchStatus.CREATED)
                              if (game.isCurrentUserAttending == null) ...[
                                IconButton(
                                  icon: const Icon(Icons.check, color: Colors.green),
                                  tooltip: "Potvrdi dolazak",
                                  onPressed: () => _setAttendance(game, true),
                                ),
                                IconButton(
                                  icon: const Icon(Icons.close, color: Colors.red),
                                  tooltip: "Otkaži dolazak",
                                  onPressed: () => _setAttendance(game, false),
                                ),
                              ] else if (game.isCurrentUserAttending == true) ...[
                                IconButton(
                                  icon: const Icon(Icons.close, color: Colors.red),
                                  tooltip: "Otkaži dolazak",
                                  onPressed: () => _setAttendance(game, false),
                                ),
                              ] else if (game.isCurrentUserAttending == false) ...[
                                IconButton(
                                  icon: const Icon(Icons.check, color: Colors.green),
                                  tooltip: "Potvrdi dolazak",
                                  onPressed: () => _setAttendance(game, true),
                                ),
                              ],
                            if (game.status == MatchStatus.CREATED)
                              IconButton(
                                icon: const Icon(Icons.edit, color: Colors.blue),
                                tooltip: "Uredi meč",
                                onPressed: () async {
                                  final updated = await Navigator.push(
                                    context,
                                    MaterialPageRoute(
                                      builder: (context) => EditorCancelScreen(matchId: game.id!, teamId: widget.teamId,),
                                    ),
                                  );
                                  if (updated == true) _fetchGames();
                                },
                              ),
                            IconButton(
                              icon: const Icon(Icons.comment, color: Colors.orange),
                              tooltip: "Komentari",
                              onPressed: () {
                                Navigator.push(
                                  context,
                                  MaterialPageRoute(
                                    builder: (context) => CommentsScreen(matchId: game.id!),
                                  ),
                                );
                              },
                            ),
                          ],
                        )


                      ],
                    ),
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