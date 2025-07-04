
import 'package:flutter/material.dart';
import 'package:playermobile/screens/squad_members.dart';
import '../models/squad.dart';
import '../providers/squad_provider.dart';
import '../widgets/master_screen.dart';
import '../widgets/custom_snackbar.dart';

class SquadScreen extends StatefulWidget {
  final int teamId;

  const SquadScreen({super.key, required this.teamId});

  @override
  State<SquadScreen> createState() => _SquadScreenState();
}

class _SquadScreenState extends State<SquadScreen> {
  final SquadProvider _squadProvider = SquadProvider();

  bool _isLoading = false;
  List<Squad> _squads = [];

  @override
  void initState() {
    super.initState();
    _loadSquads();
  }

  Future<void> _loadSquads() async {
    setState(() => _isLoading = true);
    try {
      final data = await _squadProvider.get(filter: {'teamId': widget.teamId.toString()});
      setState(() {
        _squads = data.result;
        _isLoading = false;
      });
    } catch (e) {
      setState(() => _isLoading = false);
      CustomSnackbar.show(context, "Greška pri učitavanju ekipa: $e", SnackbarType.error);
    }
  }

  Future<void> _addSquad(String name) async {
    if (name.trim().isEmpty) {
      CustomSnackbar.show(context, "Ime ekipe je obavezno", SnackbarType.error);
      return;
    }

    try {
      await _squadProvider.insert({'name': name.trim(), 'teamId': widget.teamId});
      CustomSnackbar.show(context, "Ekipa '$name' je uspješno dodana", SnackbarType.success);
      Navigator.of(context).pop();
      _loadSquads();
    } catch (e) {
      CustomSnackbar.show(context, "Greška prilikom dodavanja ekipe: $e", SnackbarType.error);
    }
  }

  Future<void> _editSquad(int id, String currentName) async {
    final _nameController = TextEditingController(text: currentName);

    await showDialog(
      context: context,
      builder: (ctx) => AlertDialog(
        title: const Text('Uredi ime ekipe'),
        content: TextField(
          controller: _nameController,
          decoration: const InputDecoration(
            labelText: 'Ime ekipe',
            border: OutlineInputBorder(),
          ),
          autofocus: true,
        ),
        actions: [
          TextButton(onPressed: () => Navigator.of(ctx).pop(), child: const Text('Otkaži')),
          ElevatedButton(
            onPressed: () async {
              final newName = _nameController.text.trim();
              if (newName.isEmpty) {
                CustomSnackbar.show(context, "Ime ekipe je obavezno", SnackbarType.error);
                return;
              }
              try {
                await _squadProvider.update(id, {'name': newName, 'teamId': widget.teamId });
                CustomSnackbar.show(context, "Ekipa je uspješno ažurirana", SnackbarType.success);
                Navigator.of(ctx).pop();
                _loadSquads();
              } catch (e) {
                CustomSnackbar.show(context, "Greška prilikom uređivanja ekipe: $e", SnackbarType.error);
              }
            },
            child: const Text('Sačuvaj'),
          ),
        ],
      ),
    );
  }

  Future<void> _deleteSquad(int id, String name) async {
    final confirmed = await showDialog<bool>(
      context: context,
      builder: (ctx) => AlertDialog(
        title: const Text('Potvrda brisanja'),
        content: Text('Da li ste sigurni da želite obrisati ekipu "$name"?'),
        actions: [
          TextButton(onPressed: () => Navigator.of(ctx).pop(false), child: const Text('Ne')),
          TextButton(onPressed: () => Navigator.of(ctx).pop(true), child: const Text('Da')),
        ],
      ),
    );

    if (confirmed == true) {
      try {
        await _squadProvider.delete(id);
        CustomSnackbar.show(context, "Ekipa '$name' je obrisana", SnackbarType.success);
        _loadSquads();
      } catch (e) {
        CustomSnackbar.show(context, "Greška prilikom brisanja ekipe: $e", SnackbarType.error);
      }
    }
  }

  void _showAddSquadDialog() {
    final _nameController = TextEditingController();

    showDialog(
      context: context,
      builder: (ctx) => AlertDialog(
        title: const Text('Dodaj novu ekipu'),
        content: TextField(
          controller: _nameController,
          decoration: const InputDecoration(
            labelText: 'Ime ekipe',
            border: OutlineInputBorder(),
          ),
          autofocus: true,
        ),
        actions: [
          TextButton(onPressed: () => Navigator.of(ctx).pop(), child: const Text('Otkaži')),
          ElevatedButton(
            onPressed: () {
              _addSquad(_nameController.text);
            },
            child: const Text('Dodaj'),
          ),
        ],
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    return MobileMasterScreenWidget(
      title: 'Ekipe',
      child: _isLoading
          ? const Center(child: CircularProgressIndicator())
          : _squads.isEmpty
          ? const Center(child: Text('Nema dostupnih ekipa'))
          : Stack(
        children: [
          ListView.separated(
            itemCount: _squads.length,
            separatorBuilder: (_, __) => const Divider(color: Colors.white24),
            itemBuilder: (context, index) {
              final squad = _squads[index];
              final memberCount = squad.userSquads?.length ?? 0;

              return ListTile(
                title: Text(
                  squad.name ?? 'Bez imena',
                  style: const TextStyle(color: Colors.white),
                ),
                subtitle: Text(
                  'Broj igrača: $memberCount',
                  style: const TextStyle(color: Colors.white70),
                ),
                trailing: Row(
                  mainAxisSize: MainAxisSize.min,
                  children: [
                    IconButton(
                      icon: const Icon(Icons.remove_red_eye, color: Colors.blueAccent),
                      tooltip: 'Pogledaj članove',
                      onPressed: () async {
                        await Navigator.push(
                          context,
                          MaterialPageRoute(
                            builder: (_) => SquadMembersScreen(squadId: squad.id!),
                          ),
                        );
                        _loadSquads();
                      },
                    ),
                    IconButton(
                      icon: const Icon(Icons.edit, color: Colors.orangeAccent),
                      tooltip: 'Uredi ime ekipe',
                      onPressed: () => _editSquad(squad.id!, squad.name ?? ''),
                    ),
                    IconButton(
                      icon: const Icon(Icons.delete, color: Colors.redAccent),
                      tooltip: 'Obriši ekipu',
                      onPressed: () => _deleteSquad(squad.id!, squad.name ?? ''),
                    ),
                  ],
                ),
              );
            },
          ),
          Positioned(
            bottom: 16,
            right: 16,
            child: FloatingActionButton(
              backgroundColor: Colors.blueAccent,
              child: const Icon(Icons.add),
              onPressed: _showAddSquadDialog,
            ),
          ),
        ],
      ),
    );
  }
}
