import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:playermobile/screens/team_details.dart';
import 'package:playermobile/screens/team_form.dart';
import 'package:playermobile/widgets/master_screen.dart';
import '../../models/team.dart';
import '../../providers/team_provider.dart';
import '../providers/team_recommender_provider.dart';
import '../services/session_serivce.dart';
import '../utils/cities.dart';

class TeamScreen extends StatefulWidget {
  const TeamScreen({super.key});

  @override
  State<TeamScreen> createState() => _TeamScreenState();
}

class _TeamScreenState extends State<TeamScreen>
    with SingleTickerProviderStateMixin, AutomaticKeepAliveClientMixin {
  @override
  bool get wantKeepAlive => true;

  late TabController _tabController;
  List<Team> myTeams = [];
  List<Team> searchResults = [];
  List<Team> recommendedTeams = [];
  bool isLoadingRecommended = true;
  bool isLoading = true;
  bool isSearchLoading = true;
  String? selectedCity;
  final TextEditingController nameController = TextEditingController();
  final joinCodeController = TextEditingController();
  bool showJoinCodeInput = false;
  String? selectedSport;

  final GlobalKey<FormFieldState<String>> _nameFieldKey = GlobalKey();
  final FocusNode _nameFocusNode = FocusNode();
  final FocusNode _cityFocusNode = FocusNode();

  final Map<String, String> sportTranslations = {
    'FOOTBALL': 'Fudbal',
    'BASKETBALL': 'Košarka',
    'FUTSAL': 'Futsal',
    'VOLLEYBALL': 'Odbojka',
    'BEACH_VOLLEYBALL': 'Odbojka na pijesku',
    'MINI_FOOTBALL': 'Mini fudbal',
    'HANDBALL': 'Rukomet',
    'TENNIS': 'Tenis',
  };

  @override
  void initState() {
    super.initState();
    _tabController = TabController(length: 3, vsync: this);
    loadMyTeams();
    loadInitialSearch();
    loadRecommendedTeams();
  }

  @override
  void dispose() {
    _tabController.dispose();
    nameController.dispose();
    _nameFocusNode.dispose();
    _cityFocusNode.dispose();
    super.dispose();
  }

  Future<void> loadMyTeams() async {
    try {
      final teamProvider = TeamProvider();
      final userId = SessionService().playerId;

      var data = await teamProvider.get(filter: {
        'userId': userId,
        'notMember': 'false',
      });

      setState(() {
        myTeams = data.result ?? [];
        isLoading = false;
      });
    } catch (e) {
      setState(() {
        isLoading = false;
      });
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(content: Text('Greška pri učitavanju timova: ${e.toString()}')),
      );
    }
  }


  Future<void> loadInitialSearch() async {
    try {
      final teamProvider = TeamProvider();

      var data = await teamProvider.get(filter: {
        'notMember': 'true',
        'isPublic': 'true',
        'userId': SessionService().playerId,
      });

      setState(() {
        searchResults = data.result ?? [];
        isSearchLoading = false;
      });
    } catch (e) {
      setState(() {
        isSearchLoading = false;
      });
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(content: Text('Greška pri učitavanju pretrage: ${e.toString()}')),
      );
    }
  }

  Future<void> loadRecommendedTeams() async {
    try {
      final provider = TeamRecommenderProvider();
      final userId = SessionService().playerId;

      var data = await provider.getRecommendations(userId!);

      setState(() {
        recommendedTeams = data;
        isLoadingRecommended = false;
      });
    } catch (e) {
      setState(() {
        isLoadingRecommended = false;
      });
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(content: Text('Greška pri učitavanju preporuka: ${e.toString()}')),
      );
    }
  }

  Future<void> performSearch() async {
    try {
      setState(() {
        isSearchLoading = true;
      });

      final teamProvider = TeamProvider();

      Map<String, dynamic> filters = {
        'notMember': 'true',
        'isPublic': 'true',
        'userId': SessionService().playerId,
      };

      if (nameController.text.trim().isNotEmpty) {
        filters['name'] = nameController.text.trim();
      }
      if (selectedCity != null && selectedCity!.isNotEmpty) {
        filters['city'] = selectedCity!;
      }
      if (selectedSport != null && selectedSport!.isNotEmpty) {
        filters['sport'] = selectedSport!;
      }

      var data = await teamProvider.get(filter: filters);

      setState(() {
        searchResults = data.result ?? [];
        isSearchLoading = false;
      });
    } catch (e) {
      setState(() {
        isSearchLoading = false;
      });
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(content: Text('Greška pri pretrazi: ${e.toString()}')),
      );
    }
  }

  void resetFilters() {
    nameController.clear();
    selectedCity = null;
    setState(() {
      selectedSport = null;
      isSearchLoading = true;
    });
    loadInitialSearch();
  }

  Widget teamCard(Team team) {
    return Card(
      shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(12)),
      margin: const EdgeInsets.symmetric(vertical: 8),
      child: ListTile(
        leading: ClipRRect(
          borderRadius: BorderRadius.circular(8),
          child: team.teamPicture != null && team.teamPicture!.isNotEmpty
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
          "Sport: ${sportTranslations[team.sport ?? ''] ?? 'N/A'}\nČlanova: ${team.memberCount ?? 0}",
        ),
        onTap: () {
          Navigator.push(
            context,
            MaterialPageRoute(
              builder: (context) => TeamDetailsScreen(teamId: team.id!),
            ),
          );
        },
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    super.build(context);
    return MobileMasterScreenWidget(
      title: "Timovi",
      child: Column(
        children: [
          TabBar(
            controller: _tabController,
            labelColor: Colors.blue.shade900,
            tabs: const [
              Tab(text: "Moji"),
              Tab(text: "Traži"),
              Tab(text: "Za vas"),
            ],
          ),
          Expanded(
            child: TabBarView(
              controller: _tabController,
              key: const PageStorageKey<String>('teamTabs'),
              children: [
                // Tab 1 - Moji timovi
                isLoading
                    ? const Center(child: CircularProgressIndicator())
                    : Padding(
                  padding: const EdgeInsets.all(12.0),
                  child: Column(
                    children: [
                      Row(
                        mainAxisAlignment: MainAxisAlignment.end,
                        children: [
                          ElevatedButton(
                            onPressed: () {
                              setState(() {
                                showJoinCodeInput = !showJoinCodeInput;
                              });
                            },
                            child: const Text("Unesi kod"),
                          ),
                          const SizedBox(width: 12),
                          ElevatedButton(
                            onPressed: () {
                              Navigator.of(context).push(
                                MaterialPageRoute(
                                    builder: (_) => const TeamFormScreen()),
                              );
                            },
                            child: const Text("Dodaj novi"),
                          ),
                        ],
                      ),
                      if (showJoinCodeInput) ...[
                        const SizedBox(height: 12),
                        TextField(
                          controller: joinCodeController,
                          decoration: const InputDecoration(
                            labelText: "Kod tima",
                            border: OutlineInputBorder(),
                          ),
                        ),
                        const SizedBox(height: 8),
                        Align(
                          alignment: Alignment.centerRight,
                          child: ElevatedButton(
                            onPressed: () async {
                              final code = joinCodeController.text.trim();
                              if (code.isEmpty) return;

                              setState(() => isSearchLoading = true);

                              try {
                                final results = await TeamProvider()
                                    .get(filter: {'JoinCode': code});
                                setState(() {
                                  searchResults = results.result;
                                  _tabController.animateTo(1);
                                  showJoinCodeInput = false;
                                  joinCodeController.clear();
                                });
                              } catch (e) {
                                print(e.toString());
                                showDialog(
                                  context: context,
                                  builder: (_) => AlertDialog(
                                    title: const Text("Greška"),
                                    content: const Text(
                                        "Tim s tim kodom nije pronađen."),
                                    actions: [
                                      TextButton(
                                        onPressed: () =>
                                            Navigator.pop(context),
                                        child: const Text("U redu"),
                                      ),
                                    ],
                                  ),
                                );
                              } finally {
                                setState(() => isSearchLoading = false);
                              }
                            },
                            child: const Text("Traži tim"),
                          ),
                        ),
                      ],
                      const SizedBox(height: 12),
                      Expanded(
                        child: ListView.builder(
                          itemCount: myTeams.length,
                          itemBuilder: (context, index) =>
                              teamCard(myTeams[index]),
                        ),
                      ),
                    ],
                  ),
                ),

                // Tab 2 - Pretraga
                Padding(
                  padding: const EdgeInsets.all(12.0),
                  child: Column(
                    children: [
                      Expanded(
                        child: ListView(
                          children: [
                            TextField(
                              key: _nameFieldKey,
                              controller: nameController,
                              focusNode: _nameFocusNode,
                              decoration: const InputDecoration(
                                labelText: "Ime tima",
                                border: OutlineInputBorder(),
                              ),
                            ),
                            const SizedBox(height: 12),
                            DropdownButtonFormField<String>(
                              decoration: const InputDecoration(
                                labelText: "Grad",
                                border: OutlineInputBorder(),
                              ),
                              items: bosniaCities.map((city) => DropdownMenuItem(
                                value: city,
                                child: Text(city),
                              )).toList(),
                              value: selectedCity,
                              onChanged: (value) {
                                setState(() {
                                  selectedCity = value;
                                });
                              },
                            ),
                            const SizedBox(height: 12),
                            DropdownButtonFormField<String>(
                              decoration: const InputDecoration(
                                labelText: "Sport",
                                border: OutlineInputBorder(),
                              ),
                              items: sportTranslations.entries
                                  .map((entry) => DropdownMenuItem(
                                value: entry.key,
                                child: Text(entry.value),
                              ))
                                  .toList(),
                              value: selectedSport,
                              onChanged: (value) {
                                setState(() {
                                  selectedSport = value;
                                });
                              },
                            ),
                            const SizedBox(height: 12),
                            Row(
                              mainAxisAlignment: MainAxisAlignment.end,
                              children: [
                                ElevatedButton(
                                  onPressed: performSearch,
                                  child: const Text("Pretraži"),
                                ),
                                const SizedBox(width: 12),
                                OutlinedButton(
                                  onPressed: resetFilters,
                                  child: const Text("Resetuj filtere"),
                                ),
                              ],
                            ),
                            const SizedBox(height: 12),
                            if (isSearchLoading)
                              const Center(child: CircularProgressIndicator())
                            else if (searchResults.isEmpty)
                              const Center(
                                  child:
                                  Text("Nema rezultata za zadate filtere."))
                            else
                              ListView.builder(
                                shrinkWrap: true,
                                physics: const NeverScrollableScrollPhysics(),
                                itemCount: searchResults.length,
                                itemBuilder: (context, index) =>
                                    teamCard(searchResults[index]),
                              ),
                          ],
                        ),
                      ),
                    ],
                  ),
                ),
                Padding(
                  padding: const EdgeInsets.all(12.0),
                  child: isLoadingRecommended
                      ? const Center(child: CircularProgressIndicator())
                      : recommendedTeams.isEmpty
                      ? const Center(child: Text("Nema preporučenih timova."))
                      : Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      const Text(
                        "Timovi koje biste mogli voljeti",
                        style: TextStyle(fontSize: 18, fontWeight: FontWeight.bold),
                      ),
                      const SizedBox(height: 12),
                      Expanded(
                        child: ListView.builder(
                          itemCount: recommendedTeams.length,
                          itemBuilder: (context, index) =>
                              teamCard(recommendedTeams[index]),
                        ),
                      ),
                    ],
                  ),
                ),
              ],
            ),
          ),
        ],
      ),
    );

  }
}