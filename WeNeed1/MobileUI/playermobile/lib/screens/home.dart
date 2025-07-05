import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:playermobile/screens/team.dart' show TeamScreen;
import '../models/user.dart';
import '../providers/match.dart';
import '../providers/user_provider.dart';
import '../widgets/master_screen.dart';

class HomePage extends StatefulWidget {
  const HomePage({super.key});

  @override
  State<HomePage> createState() => _HomePageState();
}

class _HomePageState extends State<HomePage> {
  User? _user;
  int _playedMatches = 0;
  Map<String, dynamic>? _lastMatch;
  @override
  void initState() {
    super.initState();
    _loadProfile();
    _loadMatchSummary();
  }

  Future<void> _loadProfile() async {
    var user = await UserProvider().getProfile();
    setState(() {
      _user = user;
    });
  }

  Future<void> _loadMatchSummary() async {
    try {
      final summary = await MatchProvider().getMatchSummary();
      setState(() {
        _playedMatches = summary['playedMatches'];
        _lastMatch = summary['lastMatch'];
      });
    } catch (e) {
      // Optional: show a snackbar or silently fail
    }
  }

  @override
  Widget build(BuildContext context) {
    return MobileMasterScreenWidget(
      title: "Početna",
      child:
          _user == null
              ? const Center(child: CircularProgressIndicator())
              : SingleChildScrollView(
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    Row(
                      children: [
                        ClipRRect(
                          borderRadius: BorderRadius.circular(30),
                          child:
                              _user!.profilePicture != null &&
                                      _user!.profilePicture!.isNotEmpty
                                  ? Image.memory(
                                    base64Decode(_user!.profilePicture!),
                                    width: 60,
                                    height: 60,
                                    fit: BoxFit.cover,
                                  )
                                  : Image.asset(
                                    "assets/images/placeholder_field.jpg",
                                    width: 60,
                                    height: 60,
                                    fit: BoxFit.cover,
                                  ),
                        ),
                        const SizedBox(width: 12),
                        Expanded(
                          child: RichText(
                            text: TextSpan(
                              style: Theme.of(context).textTheme.titleLarge!
                                  .copyWith(color: Colors.white),
                              children: [
                                const TextSpan(text: "Dobrodošli, "),
                                TextSpan(
                                  text:
                                      "${_user!.firstName} ${_user!.lastName}",
                                  style: const TextStyle(
                                    color: Colors.blueAccent,
                                  ),
                                ),
                              ],
                            ),
                          ),
                        ),
                      ],
                    ),
                    const SizedBox(height: 20),

                    Text("Broj odigranih termina",
                        style: TextStyle(fontSize: 16, color: Colors.white70)),
                    SizedBox(height: 4),
                    Text("$_playedMatches",
                        style: TextStyle(
                            fontSize: 28,
                            fontWeight: FontWeight.bold,
                            color: Colors.white)),

                    const SizedBox(height: 20),

                    Container(
                      width: double.infinity,
                      padding: EdgeInsets.all(16),
                      decoration: BoxDecoration(
                        color: Colors.deepOrange[200],
                        borderRadius: BorderRadius.circular(12),
                      ),
                      child:
                          _lastMatch == null
                              ? Text(
                                "Niste odigrali još nijedan meč.",
                                style: TextStyle(
                                  color: Colors.black87,
                                  fontSize: 16,
                                ),
                              )
                              : Column(
                                crossAxisAlignment: CrossAxisAlignment.start,
                                children: [
                                  Text(
                                    "Rezultat posljednjeg termina",
                                    style: TextStyle(
                                      fontSize: 14,
                                      fontWeight: FontWeight.w600,
                                    ),
                                  ),
                                  SizedBox(height: 4),
                                  Text(
                                    _lastMatch!['result'] ?? '',
                                    style: TextStyle(
                                      fontSize: 20,
                                      fontWeight: FontWeight.bold,
                                    ),
                                  ),
                                  SizedBox(height: 4),
                                  Text(
                                    "Na datum\n${DateTime.parse(_lastMatch!['matchDate']).toLocal().toString().split(' ')[0]}",
                                    style: TextStyle(fontSize: 14),
                                  ),
                                ],
                              ),
                    ),
                    const SizedBox(height: 30),

                    GestureDetector(
                      onTap: () {
                        Navigator.of(context).push(
                          MaterialPageRoute(
                            builder: (context) => const TeamScreen(),
                          ),
                        );
                      },
                      child: Container(
                        padding: const EdgeInsets.all(16),
                        decoration: BoxDecoration(
                          color: Colors.black87,
                          borderRadius: BorderRadius.circular(12),
                        ),
                        child: Row(
                          mainAxisAlignment: MainAxisAlignment.spaceBetween,
                          children: const [
                            Expanded(
                              child: Text(
                                "Pronađi novi team",
                                style: TextStyle(
                                  fontSize: 16,
                                  color: Colors.white70,
                                ),
                                overflow: TextOverflow.ellipsis,
                              ),
                            ),
                            SizedBox(width: 8),
                            Icon(
                              Icons.play_arrow,
                              color: Colors.blueAccent,
                              size: 32,
                            ),
                          ],
                        ),
                      ),
                    ),
                  ],
                ),
              ),
    );
  }
}
