import 'package:flutter/material.dart';
import '../providers/sport_field_provider.dart';
import '../widgets/master_screen.dart';
import 'checkout.dart';

class AvailableSlotsScreen extends StatefulWidget {
  final int sportFieldId;

  const AvailableSlotsScreen({super.key, required this.sportFieldId});

  @override
  State<AvailableSlotsScreen> createState() => _AvailableSlotsScreenState();
}

class _AvailableSlotsScreenState extends State<AvailableSlotsScreen> {
  final SportFieldProvider _provider = SportFieldProvider();
  DateTime _selectedDate = DateTime.now().add(const Duration(days: 1));
  List<String> _slots = [];
  bool _isLoading = false;

  @override
  void initState() {
    super.initState();
    _loadSlots();
  }

  Future<void> _loadSlots() async {
    setState(() => _isLoading = true);
    try {
      final result = await _provider.getAvailableSlots(widget.sportFieldId, _selectedDate);
      setState(() {
        _slots = result;
      });
    } catch (e) {
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(content: Text("Greška: $e")),
      );
    } finally {
      setState(() => _isLoading = false);
    }
  }

  Future<void> _pickDate() async {
    final DateTime? picked = await showDatePicker(
      context: context,
      initialDate: _selectedDate,
      firstDate: DateTime.now().add(const Duration(days: 1)),
      lastDate: DateTime.now().add(const Duration(days: 60)),
    );
    if (picked != null && picked != _selectedDate) {
      setState(() => _selectedDate = picked);
      await _loadSlots();
    }
  }

  @override
  Widget build(BuildContext context) {
    return MobileMasterScreenWidget(
      title: "Slobodni termini",
      child: Padding(
        padding: const EdgeInsets.all(16),
        child: Column(
          children: [
            ElevatedButton.icon(
              onPressed: _pickDate,
              icon: const Icon(Icons.calendar_today),
              label: Text(
                "Odabrani datum: ${_selectedDate.toLocal().toString().split(' ')[0]}",
              ),
            ),
            const SizedBox(height: 16),
            _isLoading
                ? const Expanded(child: Center(child: CircularProgressIndicator()))
                : _slots.isEmpty
                ? const Expanded(child: Center(child: Text("Nema dostupnih termina za odabrani datum.")))
                : Expanded(
              child: GridView.count(
                crossAxisCount: 3,
                crossAxisSpacing: 10,
                mainAxisSpacing: 10,
                children: _slots.map((slot) {
                  return ElevatedButton(
                    onPressed: () {
                      Navigator.push(
                        context,
                        MaterialPageRoute(
                          builder: (context) => CheckoutScreen(
                            sportFieldId: widget.sportFieldId,
                            selectedDate: _selectedDate,
                            selectedTime: slot,
                          ),
                        ),
                      );
                    },
                    style: ElevatedButton.styleFrom(
                      padding: const EdgeInsets.symmetric(vertical: 16),
                    ),
                    child: Text(
                      slot,
                      style: const TextStyle(fontSize: 16),
                    ),
                  );
                }).toList(),
              ),
            ),
          ],
        ),
      ),
    );
  }

}
