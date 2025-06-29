import 'package:flutter/material.dart';
import 'package:intl/intl.dart';

import '../models/reservation.dart';
import '../providers/reservation_provider.dart';
import '../services/session_serivce.dart';
import '../widgets/master_screen.dart';

class MyReservationsScreen extends StatefulWidget {
  const MyReservationsScreen({super.key});

  @override
  State<MyReservationsScreen> createState() => _MyReservationsScreenState();
}

class _MyReservationsScreenState extends State<MyReservationsScreen> {
  final ReservationProvider _reservationProvider = ReservationProvider();
  final ScrollController _scrollController = ScrollController();

  List<Reservation> _reservations = [];
  int _page = 0;
  final int _pageSize = 10;
  bool _isLoading = true;
  bool _hasMore = true;
  bool _showLoadMoreButton = false;

  @override
  void initState() {
    super.initState();
    _scrollController.addListener(_onScroll);
    _loadReservations();
  }

  @override
  void dispose() {
    _scrollController.dispose();
    super.dispose();
  }

  void _onScroll() {
    if (_scrollController.position.pixels >=
        _scrollController.position.maxScrollExtent - 100 &&
        !_isLoading &&
        _hasMore) {
      setState(() {
        _showLoadMoreButton = true;
      });
    }
  }

  Future<void> _loadReservations({bool loadMore = false}) async {
    setState(() => _isLoading = true);
    final userId = SessionService().playerId;

    try {
      final result = await _reservationProvider.getPaged(
        filter: {"userId": userId},
        page: _page,
        pageSize: _pageSize,
      );

      setState(() {
        if (loadMore) {
          _reservations.addAll(result.result);
        } else {
          _reservations = result.result;
        }

        _hasMore = _reservations.length < result.count;
        _showLoadMoreButton = false;
        _isLoading = false;
      });
    } catch (e) {
      setState(() => _isLoading = false);
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(content: Text("Greška prilikom učitavanja: $e")),
      );
    }
  }

  @override
  Widget build(BuildContext context) {
    return MobileMasterScreenWidget(
      title: "Moje rezervacije",
      child: _isLoading && _reservations.isEmpty
          ? const Center(child: CircularProgressIndicator())
          : _reservations.isEmpty
          ? const Center(child: Text("Nemate nijednu rezervaciju."))
          : Column(
        children: [
          Expanded(
            child: ListView.separated(
              controller: _scrollController,
              itemCount: _reservations.length,
              separatorBuilder: (_, __) => const Divider(),
              itemBuilder: (context, index) {
                final res = _reservations[index];
                final formattedDate =
                DateFormat('dd.MM.yyyy').format(res.startTime!.toLocal());
                final formattedTime =
                DateFormat('HH:mm').format(res.startTime!.toLocal());

                return ListTile(
                  leading: const Icon(Icons.calendar_month, color: Colors.white),
                  title: Text(res.sportsFieldName ?? "Nepoznato"),
                  subtitle: Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      Text("Datum: $formattedDate"),
                      Text("Vrijeme početka: $formattedTime"),
                      Text("Cijena: ${res.totalPrice?.toStringAsFixed(2)} KM"),
                      Text(
                        "Status: ${translateReservationStatus(res.status ?? '')}",
                        style: TextStyle(
                          color: getStatusColor(res.status ?? ''),
                          fontWeight: FontWeight.bold,
                        ),
                      ),
                      if (res.cancellationReason != null)
                        Text("Razlog otkazivanja: ${res.cancellationReason}",
                            style: const TextStyle(color: Colors.red)),
                    ],
                  ),
                );
              },
            ),
          ),
          if (_hasMore && _showLoadMoreButton)
            Padding(
              padding: const EdgeInsets.symmetric(vertical: 10),
              child: ElevatedButton(
                onPressed: () {
                  _page++;
                  _loadReservations(loadMore: true);
                },
                child: const Text("Učitaj još"),
              ),
            ),
        ],
      ),
    );
  }
}

String translateReservationStatus(String status) {
  switch (status) {
    case 'CREATED':
      return 'Kreirano';
    case 'CANCELLED':
      return 'Otkazano';
    case 'PAYED':
      return 'Plaćeno';
    case 'FINISHED':
      return 'Završeno';
    default:
      return 'Nepoznato';
  }
}

Color getStatusColor(String status) {
  switch (status) {
    case 'CREATED':
      return Colors.blueAccent;
    case 'CANCELLED':
      return Colors.red;
    case 'PAYED':
      return Colors.green;
    case 'FINISHED':
      return Colors.grey;
    default:
      return Colors.white;
  }
}
