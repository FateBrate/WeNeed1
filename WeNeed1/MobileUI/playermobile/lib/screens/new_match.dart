import 'package:flutter/material.dart';
import 'package:playermobile/screens/game.dart';
import '../providers/match.dart';
import '../widgets/master_screen.dart';

class NewMatchScreen extends StatefulWidget {
  final int teamId;

  const NewMatchScreen({super.key, required this.teamId});

  @override
  State<NewMatchScreen> createState() => _NewMatchScreenState();
}

class _NewMatchScreenState extends State<NewMatchScreen> {
  DateTime? selectedDate;
  TimeOfDay? selectedTime;
  bool _isLoading = false;

  final MatchProvider _matchProvider = MatchProvider();

  Future<void> _pickDate() async {
    final now = DateTime.now();
    final today = DateTime(now.year, now.month, now.day);
    final date = await showDatePicker(
      context: context,
      initialDate: today,
      firstDate: today,
      lastDate: today.add(const Duration(days: 365)),
    );
    if (date != null) {
      setState(() {
        selectedDate = date;
      });
    }
  }

  Future<void> _pickTime() async {
    final time = await showTimePicker(
      context: context,
      initialTime: TimeOfDay.now(),
    );
    if (time != null) {
      setState(() {
        selectedTime = time;
      });
    }
  }


  DateTime? get _combinedDateTime {
    if (selectedDate == null || selectedTime == null) return null;
    return DateTime(
      selectedDate!.year,
      selectedDate!.month,
      selectedDate!.day,
      selectedTime!.hour,
      selectedTime!.minute,
    );
  }

  Future<void> _submit() async {
    if (_combinedDateTime == null) {
      ScaffoldMessenger.of(context).showSnackBar(
        const SnackBar(content: Text("Molimo odaberite datum i vrijeme.")),
      );
      return;
    }

    final nowPlusOneHour = DateTime.now().add(const Duration(hours: 1));

    if (_combinedDateTime!.isBefore(nowPlusOneHour)) {
      ScaffoldMessenger.of(context).showSnackBar(
        const SnackBar(
            content: Text("Vrijeme meča mora biti barem 1 sat od sada.")),
      );
      return;
    }

    setState(() {
      _isLoading = true;
    });

    try {
      await _matchProvider.insert({
        'teamId': widget.teamId,
        'matchDate': _combinedDateTime!.toIso8601String(),
        'status': 'CREATED',
        'result': '0:0',
      });

      ScaffoldMessenger.of(context).showSnackBar(
        const SnackBar(content: Text("Meč uspješno kreiran.")),
      );

      Navigator.of(context).pushReplacement(
        MaterialPageRoute(
          builder: (context) => GamesScreen(teamId: widget.teamId),
        ),
      );
    } catch (e) {
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(content: Text("Greška prilikom kreiranja meča: $e")),
      );
    } finally {
      setState(() {
        _isLoading = false;
      });
    }
  }


  @override
  Widget build(BuildContext context) {
    return MobileMasterScreenWidget(
      title: "Novi meč",
      child: Padding(
        padding: const EdgeInsets.all(16),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            ListTile(
              title: const Text("Datum"),
              subtitle: Text(selectedDate == null
                  ? "Nije odabrano"
                  : "${selectedDate!.day}.${selectedDate!.month}.${selectedDate!.year}"),
              trailing: IconButton(
                icon: const Icon(Icons.calendar_today),
                onPressed: _pickDate,
              ),
            ),
            const Divider(thickness: 1, height: 32),
            ListTile(
              title: const Text("Vrijeme"),
              subtitle: Text(selectedTime == null
                  ? "Nije odabrano"
                  : selectedTime!.format(context)),
              trailing: IconButton(
                icon: const Icon(Icons.access_time),
                onPressed: _pickTime,
              ),
            ),
            const SizedBox(height: 24),
            Center(
              child: ElevatedButton(
                onPressed: _isLoading ? null : _submit,
                child: _isLoading
                    ? const CircularProgressIndicator(color: Colors.white)
                    : const Text("Kreiraj meč"),
              ),
            ),
          ],
        ),
      ),
    );
  }
}
