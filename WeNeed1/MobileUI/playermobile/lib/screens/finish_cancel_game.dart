import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:playermobile/models/match.dart';
import 'package:playermobile/widgets/master_screen.dart';

import '../providers/match.dart';

class EditorCancelScreen extends StatefulWidget {
  final int matchId;
  final int teamId;
  const EditorCancelScreen({super.key, required this.matchId, required this.teamId});

  @override
  State<EditorCancelScreen> createState() => _EditorCancelScreenState();
}

class _EditorCancelScreenState extends State<EditorCancelScreen> {
  final _formKey = GlobalKey<FormState>();
  String? _result;
  late Game _match;

  bool isLoading = true;

  @override
  void initState() {
    super.initState();
    _loadMatch();
  }


  Future<void> _loadMatch() async {
    try {
      final data = await MatchProvider().getById(widget.matchId);
      setState(() {
        _match = data;
        isLoading = false;
      });
    } catch (e) {
      setState(() {
        isLoading = false;
      });
      _showError("Greška pri učitavanju meča: ${e.toString()}");
    }
  }

  Future<void> _finishMatch() async {
    if (_formKey.currentState!.validate()) {
      _formKey.currentState!.save();

      try {
        await MatchProvider().update(widget.matchId, {
          "teamId": widget.teamId,
          "status": "FINISHED",
          "result": _result,
          "matchDate": _match.matchDate?.toIso8601String(),
        });

        if (mounted) {
          ScaffoldMessenger.of(context).showSnackBar(
            const SnackBar(content: Text("Meč je uspješno završen.")),
          );
          Navigator.pop(context, true);
        }
      } catch (e) {
        _showError("Greška pri završavanju meča: ${e.toString()}");
      }
    }
  }

  Future<void> _cancelMatch() async {
    try {
      await MatchProvider().update(widget.matchId, {
        "teamId": widget.teamId,
        "status": "CANCELLED",
        "matchDate": _match.matchDate?.toIso8601String(),
        "result": "0:0"
      });

      if (mounted) {
        ScaffoldMessenger.of(context).showSnackBar(
          const SnackBar(content: Text("Meč je uspješno otkazan.")),
        );
        Navigator.pop(context, true);
      }
    } catch (e) {
      _showError("Greška pri otkazivanju meča: ${e.toString()}");
    }
  }

  void _showError(String message) {
    ScaffoldMessenger.of(context).showSnackBar(
      SnackBar(content: Text(message), backgroundColor: Colors.red),
    );
  }


  @override
  Widget build(BuildContext context) {
    return MobileMasterScreenWidget(
      title: "Završi ili otkaži meč",
      child: isLoading
          ? const Center(child: CircularProgressIndicator())
          : Padding(
        padding: const EdgeInsets.all(16),
        child: Form(
          key: _formKey,
          child: Column(
            children: [
              TextFormField(
                decoration: const InputDecoration(labelText: "Rezultat"),
                onSaved: (value) => _result = value,
                validator: (value) {
                  if (value == null || value.isEmpty) {
                    return "Unesite rezultat";
                  }
                  return null;
                },
                initialValue: _match.result,
              ),
              const SizedBox(height: 20),
              ElevatedButton.icon(
                icon: const Icon(Icons.check, color: Colors.white),
                label: const Text("Završi meč", style: TextStyle(color: Colors.white)),
                onPressed: _finishMatch,
                style: ElevatedButton.styleFrom(
                  backgroundColor: Colors.green,
                  foregroundColor: Colors.white,
                ),
              ),
              const SizedBox(height: 12),
              ElevatedButton.icon(
                icon: const Icon(Icons.cancel, color: Colors.white),
                label: const Text("Otkaži meč", style: TextStyle(color: Colors.white)),
                onPressed: _cancelMatch,
                style: ElevatedButton.styleFrom(
                  backgroundColor: Colors.red,
                  foregroundColor: Colors.white,
                ),
              ),
            ],
          ),
        ),
      ),
    );
  }

}
