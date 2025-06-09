import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import '../models/reservation.dart';
import '../providers/reservation_provider.dart';
import '../services/session_serivce.dart';
import '../widgets/cancellation_dialog.dart';
import '../widgets/confirmation_dialog.dart';
import '../widgets/custom_snackbar.dart';
import '../widgets/master_screen.dart';

class ReservationScreen extends StatefulWidget {
  const ReservationScreen({super.key});

  @override
  State<ReservationScreen> createState() => _ReservationScreenState();
}

class _ReservationScreenState extends State<ReservationScreen> {
  final ReservationProvider _provider = ReservationProvider();
  final List<Reservation> _reservations = [];
  String? _selectedStatus;
  final Map<String, String> statusTranslations = {
    "CREATED": "Kreirana",
    "PAYED": "Plaćena",
    "CANCELLED": "Otkazana",
    "FINISHED": "Završena",
  };

  final ScrollController _horizontalScrollController = ScrollController();
  final ScrollController _verticalScrollController = ScrollController();

  int _currentPage = 0;
  final int _pageSize = 10;
  int _totalCount = 0;
  bool _isLoading = false;

  @override
  void initState() {
    super.initState();
    _loadReservations();
  }

  @override
  void dispose() {
    _horizontalScrollController.dispose();
    _verticalScrollController.dispose();
    super.dispose();
  }

  Future<void> _loadReservations() async {
    setState(() {
      _isLoading = true;
    });

    var filter = <String, String>{};
    var sportsCenterId = SessionService().sportsCenterId;
    if (sportsCenterId != null) {
      filter['SportsCenterId'] = sportsCenterId.toString();
    }
    if (_selectedStatus != null && _selectedStatus != 'ALL') {
      filter['Status'] = _selectedStatus!;
    }

    try {
      var searchResult = await _provider.getPaged(
        filter: filter,
        page: _currentPage,
        pageSize: _pageSize,
      );

      setState(() {
        _reservations.clear();
        _reservations.addAll(searchResult.result);
        _totalCount = searchResult.count;
      });
    } catch (e) {
      CustomSnackbar.show(context, "Greška pri očitavanju rezervacija", SnackbarType.error);
    } finally {
      setState(() {
        _isLoading = false;
      });
    }
  }

  @override
  Widget build(BuildContext context) {
    final totalPages = (_totalCount / _pageSize).ceil();

    return MasterScreenWidget(
      child: Padding(
        padding: const EdgeInsets.all(16.0),
        child: Align(
          alignment: Alignment.topCenter,
          child: ConstrainedBox(
            constraints: const BoxConstraints(maxWidth: 1200),
            child: SingleChildScrollView(
              controller: _verticalScrollController,
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  const Text(
                    "Tereni",
                    style: TextStyle(fontSize: 32, fontWeight: FontWeight.bold),
                  ),
                  const SizedBox(height: 8),
                  const Text(
                    'Korisnici / Rezervacije',
                    style: TextStyle(fontSize: 16, color: Colors.grey),
                  ),
                  const SizedBox(height: 24),
                  Wrap(
                    spacing: 16,
                    runSpacing: 8,
                    crossAxisAlignment: WrapCrossAlignment.center,
                    alignment: WrapAlignment.center,
                    children: [
                      SizedBox(
                        width: 200,
                        child: DropdownButtonFormField<String>(
                          value: _selectedStatus ?? 'ALL',
                          decoration: const InputDecoration(
                            labelText: "Status",
                            border: OutlineInputBorder(),
                          ),
                          items: const [
                            DropdownMenuItem(value: 'ALL', child: Text("Svi")),
                            DropdownMenuItem(
                              value: 'CREATED',
                              child: Text("Kreirana"),
                            ),
                            DropdownMenuItem(
                              value: 'PAYED',
                              child: Text("Plaćena"),
                            ),
                            DropdownMenuItem(
                              value: 'CANCELLED',
                              child: Text("Otkazana"),
                            ),
                            DropdownMenuItem(
                              value: 'FINISHED',
                              child: Text("Završena"),
                            ),
                          ],
                          onChanged: (value) {
                            setState(() {
                              _selectedStatus = value;
                              _currentPage = 0;
                              _loadReservations();
                            });
                          },
                        ),
                      ),
                      SizedBox(
                        height: 60,
                        child: ElevatedButton.icon(
                          onPressed: () {
                            _currentPage = 0;
                            _loadReservations();
                          },
                          icon: const Icon(Icons.search),
                          label: const Text("Pretraga"),
                          style: ElevatedButton.styleFrom(
                            minimumSize: const Size(200, 60),
                          ),
                        ),
                      ),
                    ],
                  ),
                  const SizedBox(height: 24),
                  _isLoading
                      ? const Center(child: CircularProgressIndicator())
                      : Column(
                    children: [
                      Scrollbar(
                        controller: _horizontalScrollController,
                        thumbVisibility: true,
                        trackVisibility: true,
                        child: SingleChildScrollView(
                          controller: _horizontalScrollController,
                          scrollDirection: Axis.horizontal,
                          child: DataTable(
                            headingRowColor:
                            WidgetStateProperty.resolveWith<Color>(
                                  (Set<WidgetState> states) =>
                              Colors.blue.shade300,
                            ),
                            columns: const [
                              DataColumn(label: Text('Ime')),
                              DataColumn(label: Text('Prezime')),
                              DataColumn(label: Text('Datum')),
                              DataColumn(label: Text('Početak')),
                              DataColumn(label: Text('Kraj')),
                              DataColumn(label: Text('Cena')),
                              DataColumn(label: Text('Status')),
                              DataColumn(label: Text('Teren')),
                              DataColumn(label: Text('Akcija')),
                            ],
                            rows: _reservations.map((r) {
                              final dateFormat = DateFormat('dd.MM.yyyy');
                              final timeFormat = DateFormat('HH:mm');
                              return DataRow(
                                cells: [
                                  DataCell(Text(r.userFirstName ?? "")),
                                  DataCell(Text(r.userLastName ?? "")),
                                  DataCell(Text(dateFormat.format(
                                      r.startTime ?? DateTime(0)))),
                                  DataCell(Text(timeFormat.format(
                                      r.startTime ?? DateTime(0)))),
                                  DataCell(Text(timeFormat.format(
                                      r.endTime ?? DateTime(0)))),
                                  DataCell(Text("${r.totalPrice} KM")),
                                  DataCell(Text(statusTranslations[
                                  r.status] ??
                                      r.status ??
                                      "")),
                                  DataCell(Text(r.sportsFieldName ?? "")),
                                  DataCell(
                                    Row(
                                      mainAxisSize: MainAxisSize.min,
                                      children: [
                                        if (r.status == 'CREATED')
                                          IconButton(
                                            icon: const Icon(Icons.cancel,
                                                color: Colors.orange),
                                            tooltip: 'Otkaži',
                                            onPressed: () =>
                                                _showCancellationDialog(
                                                    r.id!),
                                          ),
                                        if (r.status == 'PAYED' ||
                                            r.status == 'CREATED')
                                          IconButton(
                                            icon: const Icon(
                                                Icons.check_circle,
                                                color: Colors.green),
                                            tooltip: 'Završi',
                                            onPressed: () => showDialog(
                                              context: context,
                                              builder: (context) =>
                                                  ConfirmationDialog(
                                                    title: "Potvrda završetka",
                                                    content:
                                                    "Da li ste sigurni da želite završiti ovu rezervaciju?",
                                                    confirmButtonText:
                                                    "Završi",
                                                    cancelButtonText: "Otkaži",
                                                    onConfirm: () =>
                                                        _finishReservation(
                                                            r.id!),
                                                  ),
                                            ),
                                          ),
                                        if (r.status == 'CANCELLED' ||
                                            r.status == 'FINISHED')
                                          IconButton(
                                            icon: const Icon(Icons.delete,
                                                color: Colors.red),
                                            tooltip: 'Obriši',
                                            onPressed: () => showDialog(
                                              context: context,
                                              builder: (context) =>
                                                  ConfirmationDialog(
                                                    title: "Potvrda brisanja",
                                                    content:
                                                    "Da li ste sigurni da želite obrisati ovu rezervaciju?",
                                                    confirmButtonText:
                                                    "Obriši",
                                                    cancelButtonText: "Otkaži",
                                                    onConfirm: () =>
                                                        _deleteReservation(
                                                            r.id!),
                                                  ),
                                            ),
                                          ),
                                      ],
                                    ),
                                  ),
                                ],
                              );
                            }).toList(),
                          ),
                        ),
                      ),
                      const SizedBox(height: 16),
                      Row(
                        mainAxisAlignment: MainAxisAlignment.center,
                        children: [
                          IconButton(
                            icon: const Icon(Icons.arrow_back),
                            onPressed: _currentPage > 0 && !_isLoading
                                ? () {
                              setState(() {
                                _currentPage--;
                              });
                              _loadReservations();
                            }
                                : null,
                          ),
                          Text('Strana ${_currentPage + 1} od $totalPages'),
                          IconButton(
                            icon: const Icon(Icons.arrow_forward),
                            onPressed: ((_currentPage + 1) * _pageSize <
                                _totalCount) &&
                                !_isLoading
                                ? () {
                              setState(() {
                                _currentPage++;
                              });
                              _loadReservations();
                            }
                                : null,
                          ),
                        ],
                      ),
                    ],
                  ),
                ],
              ),
            ),
          ),
        ),
      ),
    );
  }

  Future<void> _cancelReservation(int reservationId, String reason) async {
    try {
      await _provider.cancelReservation(reservationId, reason);
      CustomSnackbar.show(
        context,
        "Rezervacija uspešno otkazana.",
        SnackbarType.success,
      );
      await _loadReservations();
    } catch (e) {
      CustomSnackbar.show(
        context,
        "Greška prilikom otkazivanja: ${e.toString()}",
        SnackbarType.error,
      );
    }
  }

  void _showCancellationDialog(int reservationId) {
    showDialog(
      context: context,
      builder: (context) => CancellationDialog(
        title: "Otkazivanje rezervacije",
        confirmButtonText: "Potvrdi",
        cancelButtonText: "Odustani",
        onConfirm: (reason) {
          _cancelReservation(reservationId, reason);
        },
      ),
    );
  }

  Future<void> _finishReservation(int reservationId) async {
    try {
      await _provider.finishReservation(reservationId);
      CustomSnackbar.show(
        context,
        "Rezervacija uspješno kompletirana.",
        SnackbarType.success,
      );
      await _loadReservations();
    } catch (e) {
      CustomSnackbar.show(
        context,
        "Greška prilikom završetka: ${e.toString()}",
        SnackbarType.error,
      );
    }
  }

  Future<void> _deleteReservation(int reservationId) async {
    try {
      await _provider.delete(reservationId);
      CustomSnackbar.show(
        context,
        "Rezervacija uspešno obrisana.",
        SnackbarType.success,
      );
      await _loadReservations();
    } catch (e) {
      CustomSnackbar.show(
        context,
        "Greška prilikom brisanja: ${e.toString()}",
        SnackbarType.error,
      );
    }
  }
}