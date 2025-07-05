import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:flutter_stripe/flutter_stripe.dart';
import 'package:http/http.dart' as http;
import 'package:playermobile/screens/reservations.dart';
import '../providers/reservation_provider.dart';
import '../widgets/custom_snackbar.dart';
import '../widgets/master_screen.dart';

class StripePaymentScreen extends StatefulWidget {
  final int reservationId;
  final double amount;
  const StripePaymentScreen({super.key, required this.reservationId, required this.amount});

  @override
  State<StripePaymentScreen> createState() => _StripePaymentScreenState();
}

class _StripePaymentScreenState extends State<StripePaymentScreen> {
  bool _isLoading = false;

  @override
  void initState() {
    super.initState();
    _startPayment();
  }

  Future<void> _startPayment() async {
    setState(() => _isLoading = true);

    try {
      final amountInCents = (widget.amount * 100).toInt();

      final paymentIntent = await _createPaymentIntent(amountInCents, 'bam');
      if (paymentIntent == null) throw Exception("Neuspješno kreiranje paymentIntenta");

      await Stripe.instance.initPaymentSheet(
        paymentSheetParameters: SetupPaymentSheetParameters(
          paymentIntentClientSecret: paymentIntent['client_secret'],
          merchantDisplayName: 'Sportski Centar',
        ),
      );

      await Stripe.instance.presentPaymentSheet();

      final transactionId = paymentIntent['id'];
      await ReservationProvider().pay(widget.reservationId, transactionId);

      if (!mounted) return;
      CustomSnackbar.show(context, "Plaćanje uspješno!", SnackbarType.success);

      Navigator.pushReplacement(
        context,
        MaterialPageRoute(
          builder: (context) => MyReservationsScreen(),
        ),
      );
    } catch (e) {
      if (!mounted) return;
      CustomSnackbar.show(
        context,
        "Greška prilikom plaćanja: $e",
        SnackbarType.error,
      );
      Navigator.pop(context);
    } finally {
      setState(() => _isLoading = false);
    }
  }


  Future<Map<String, dynamic>?> _createPaymentIntent(int amount, String currency) async {
    try {
      final response = await http.post(
        Uri.parse('https://api.stripe.com/v1/payment_intents'),
        headers: {
          'Authorization': 'Bearer sk_test_51RZspNPxAmoaM21xwtQf4rl4wZ95Pv6UHaLSUEG1aZ3KjZS6PbPvv8jDQbIIXL25XWHTpINDeHCcYNycq72lTxII00MA4Q3tda',
          'Content-Type': 'application/x-www-form-urlencoded',
        },
        body: {
          'amount': amount.toString(),
          'currency': currency,
          'payment_method_types[]': 'card',
        },
      );
      return jsonDecode(response.body);
    } catch (e) {
      print("Stripe error: $e");
      return null;
    }
  }

  @override
  Widget build(BuildContext context) {
    return MobileMasterScreenWidget(
      title: "Plaćanje",
      child: Center(
        child: _isLoading
            ? const CircularProgressIndicator()
            : const Text("Priprema plaćanja..."),
      ),
    );
  }
}
