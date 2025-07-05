import 'dart:convert';

import 'package:flutter/material.dart';
import 'package:playermobile/screens/payment.dart';
import 'package:playermobile/screens/reservations.dart';

import '../models/sport_field.dart';
import '../providers/reservation_provider.dart';
import '../providers/sport_field_provider.dart';
import '../widgets/custom_snackbar.dart';
import '../widgets/master_screen.dart';

class CheckoutScreen extends StatefulWidget {
  final int sportFieldId;
  final DateTime selectedDate;
  final String selectedTime;

  const CheckoutScreen({
    super.key,
    required this.sportFieldId,
    required this.selectedDate,
    required this.selectedTime,
  });

  @override
  State<CheckoutScreen> createState() => _CheckoutScreenState();
}

class _CheckoutScreenState extends State<CheckoutScreen> {
  SportField? _field;
  bool _isLoading = true;

  @override
  void initState() {
    super.initState();
    _loadField();
  }

  Future<void> _loadField() async {
    final result = await SportFieldProvider().getById(widget.sportFieldId);
    setState(() {
      _field = result;
      _isLoading = false;
    });
  }

  Future<void> _createReservation() async {
    final startTime = DateTime.parse(
        "${widget.selectedDate.toLocal().toIso8601String().split('T')[0]}T${widget.selectedTime}"
    );

    final request = {
      "sportsFieldId": widget.sportFieldId,
      "startTime": startTime.toIso8601String(),
    };

    try {
      final response = await ReservationProvider().insert(request);

      if (response != null) {
        if (!mounted) return;

        CustomSnackbar.show(context, "Rezervacija je uspješno kreirana.", SnackbarType.success);

        final payNow = await showDialog<bool>(
          context: context,
          builder: (context) => AlertDialog(
            title: const Text("Rezervacija uspješna"),
            content: const Text("Želite li odmah platiti rezervaciju?"),
            actions: [
              TextButton(
                onPressed: () => Navigator.pop(context, false),
                child: const Text("Ne"),
              ),
              ElevatedButton(
                onPressed: () => Navigator.pop(context, true),
                child: const Text("Da"),
              ),
            ],
          ),
        );

        if (!mounted) return;

        if (payNow == true) {
          Navigator.pushReplacement(
            context,
            MaterialPageRoute(
              builder: (context) => StripePaymentScreen(
                reservationId: response.id!,
                amount: _field?.pricePerHour ?? 0.0,
              ),
            ),
          );
        } else {
          Navigator.pushReplacement(
            context,
            MaterialPageRoute(
              builder: (context) => MyReservationsScreen(),
            ),
          );
        }
      } else {
        if (!mounted) return;
        CustomSnackbar.show(context, "Greška prilikom rezervacije. Pokušajte ponovo.", SnackbarType.error);
        // ništa dalje se ne dešava
      }
    } catch (e) {
      if (!mounted) return;
      CustomSnackbar.show(context, "Došlo je do greške: $e", SnackbarType.error);
    }
  }

  @override
  Widget build(BuildContext context) {
    return MobileMasterScreenWidget(
      title: "Potvrda rezervacije",
      child: _isLoading
          ? const Center(child: CircularProgressIndicator())
          : Padding(
        padding: const EdgeInsets.all(16),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            if (_field?.image != null)
              ClipRRect(
                borderRadius: BorderRadius.circular(12),
                child: Image.memory(
                  base64Decode(_field!.image!),
                  height: 180,
                  width: double.infinity,
                  fit: BoxFit.cover,
                ),
              ),
            const SizedBox(height: 20),
            Text(
              _field?.name ?? "-",
              style: const TextStyle(
                fontSize: 24,
                fontWeight: FontWeight.bold,
              ),
            ),
            const SizedBox(height: 20),
            Row(
              children: [
                const Icon(Icons.calendar_today, color: Colors.blue),
                const SizedBox(width: 8),
                Text(
                  "Datum: ${widget.selectedDate.toLocal().toString().split(' ')[0]}",
                  style: const TextStyle(fontSize: 16),
                ),
              ],
            ),
            const SizedBox(height: 12),
            Row(
              children: [
                const Icon(Icons.access_time, color: Colors.blue),
                const SizedBox(width: 8),
                Text(
                  "Vrijeme: ${widget.selectedTime}",
                  style: const TextStyle(fontSize: 16),
                ),
              ],
            ),
            const SizedBox(height: 12),
            Row(
              children: [
                const Icon(Icons.attach_money, color: Colors.blue),
                const SizedBox(width: 8),
                Text(
                  "Cijena: ${_field?.pricePerHour?.toStringAsFixed(2) ?? "-"} KM",
                  style: const TextStyle(fontSize: 16),
                ),
              ],
            ),
            const SizedBox(height: 30),
            Center(
              child: ElevatedButton.icon(
                icon: const Icon(Icons.check),
                label: const Text("Rezerviši"),
                style: ElevatedButton.styleFrom(
                  padding: const EdgeInsets.symmetric(horizontal: 40, vertical: 14),
                  textStyle: const TextStyle(fontSize: 18),
                ),
                onPressed: _createReservation,
              ),
            ),
          ],
        ),
      ),
    );
  }

}
