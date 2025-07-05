import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:playermobile/screens/sport_center_details.dart';
import '../../models/sport_center.dart';
import '../providers/sport_center_provider.dart';
import '../providers/sport_center_recommnder_provider.dart';
import '../services/session_serivce.dart';
import '../widgets/master_screen.dart';

class SportsCentersScreen extends StatefulWidget {
  const SportsCentersScreen({super.key});

  @override
  State<SportsCentersScreen> createState() => _SportsCentersScreenState();
}

class _SportsCentersScreenState extends State<SportsCentersScreen> with SingleTickerProviderStateMixin {
  final _searchController = TextEditingController();
  List<SportsCenter> _searchResults = [];
  List<SportsCenter> _recommended = [];

  bool _isLoadingSearch = false;
  bool _isLoadingRecommended = false;

  late final TabController _tabController;

  @override
  void initState() {
    super.initState();
    _tabController = TabController(length: 2, vsync: this);
    _fetchCenters();
    _fetchRecommendations();
  }

  Future<void> _fetchCenters({String? name}) async {
    setState(() => _isLoadingSearch = true);
    try {
      final data = await SportsCenterProvider().get(filter: name != null ? {'name': name} : null);
      setState(() {
        _searchResults = data.result;
      });
    } catch (e) {
      ScaffoldMessenger.of(context).showSnackBar(const SnackBar(content: Text("Greška pri učitavanju centara")));
    } finally {
      setState(() => _isLoadingSearch = false);
    }
  }

  Future<void> _fetchRecommendations() async {
    setState(() => _isLoadingRecommended = true);
    try {
      final userId = SessionService().playerId;
      final result = await SportsCenterRecommenderProvider().getRecommendations(userId!);
      setState(() {
        _recommended = result;
      });
    } catch (e) {
      ScaffoldMessenger.of(context).showSnackBar(const SnackBar(content: Text("Greška pri učitavanju preporuka")));
    } finally {
      setState(() => _isLoadingRecommended = false);
    }
  }

  Widget _buildCenterList(List<SportsCenter> centers, bool isLoading) {
    if (isLoading) return const Center(child: CircularProgressIndicator());
    if (centers.isEmpty) return const Center(child: Text("Nema dostupnih centara"));

    return ListView.builder(
      itemCount: centers.length,
      itemBuilder: (context, index) {
        final center = centers[index];
        return Card(
          margin: const EdgeInsets.symmetric(vertical: 8),
          shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(12)),
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.stretch,
            children: [
              ClipRRect(
                borderRadius: const BorderRadius.vertical(top: Radius.circular(12)),
                child: center.image != null
                    ? Image.memory(base64Decode(center.image!), height: 150, fit: BoxFit.cover)
                    : Container(
                  height: 150,
                  color: Colors.grey[300],
                  child: const Icon(Icons.image_not_supported, size: 50),
                ),
              ),
              Padding(
                padding: const EdgeInsets.all(12),
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    Text(center.name ?? "Nepoznat centar",
                        style: const TextStyle(fontSize: 18, fontWeight: FontWeight.bold)),
                    const SizedBox(height: 6),
                    Row(
                      children: [
                        const Icon(Icons.access_time, size: 18, color: Colors.grey),
                        const SizedBox(width: 6),
                        Text("${center.startTime ?? "?"} - ${center.endTime ?? "?"}"),
                      ],
                    ),
                    Align(
                      alignment: Alignment.centerRight,
                      child: IconButton(
                        icon: const Icon(Icons.info_outline, color: Colors.blue),
                        tooltip: "Detalji",
                        onPressed: () {
                          Navigator.push(
                            context,
                            MaterialPageRoute(
                              builder: (_) => SportCenterDetailsScreen(sportsCenterId: center.id!),
                            ),
                          );
                        },
                      ),
                    ),
                  ],
                ),
              ),
            ],
          ),
        );
      },
    );
  }

  @override
  Widget build(BuildContext context) {
    return MobileMasterScreenWidget(
      title: "Sportski Centri",
      child: Column(
        children: [
          TabBar(
            controller: _tabController,
            labelColor: Colors.blueAccent,
            unselectedLabelColor: Colors.grey,
            indicatorColor: Colors.blueAccent,
            tabs: const [
              Tab(text: "Pretraga"),
              Tab(text: "Za vas"),
            ],
          ),
          const SizedBox(height: 12),
          Expanded(
            child: TabBarView(
              controller: _tabController,
              children: [
                // Tab 1: Pretraga
                Padding(
                  padding: const EdgeInsets.all(16),
                  child: Column(
                    children: [
                      Row(
                        children: [
                          Expanded(
                            child: TextField(
                              controller: _searchController,
                              decoration: const InputDecoration(
                                labelText: "Pretraga po imenu",
                              ),
                            ),
                          ),
                          const SizedBox(width: 8),
                          ElevatedButton(
                            onPressed: () {
                              _fetchCenters(name: _searchController.text.trim());
                            },
                            child: const Text("Pretraži"),
                          ),
                        ],
                      ),
                      const SizedBox(height: 16),
                      Expanded(child: _buildCenterList(_searchResults, _isLoadingSearch)),
                    ],
                  ),
                ),

                Padding(
                  padding: const EdgeInsets.all(16),
                  child: Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      const Text(
                        "Ovi centri bi vam se mogli svidjeti",
                        style: TextStyle(fontSize: 18, fontWeight: FontWeight.bold),
                      ),
                      const SizedBox(height: 12),
                      Expanded(child: _buildCenterList(_recommended, _isLoadingRecommended)),
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
