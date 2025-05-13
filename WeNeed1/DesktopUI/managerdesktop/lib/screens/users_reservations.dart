import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import '../models/reservation.dart';
import '../providers/reservation_provider.dart';
import '../services/session_serivce.dart';
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
    "FINISHED": "Završena"
  };

  @override
  void initState() {
    super.initState();
    _loadReservations();
  }

  Future<void> _loadReservations() async {
    var filter = <String, String>{};
    var sportsCenterId = SessionService().sportsCenterId;

    if (sportsCenterId != null) {
      filter['SportsCenterId'] = sportsCenterId.toString();
    }
    if (_selectedStatus != null && _selectedStatus != 'ALL') {
      filter['Status'] = _selectedStatus!;
    }

    var searchResult = await _provider.get(filter: filter);

    setState(() {
      _reservations.clear();
      _reservations.addAll(searchResult.result);
    });
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
      child: Padding(
        padding: const EdgeInsets.all(16.0),
        child: Align(
          alignment: Alignment.topCenter,
          child: ConstrainedBox(
            constraints: const BoxConstraints(maxWidth: 1200),
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
                        value: _selectedStatus,
                        decoration: const InputDecoration(
                          labelText: "Status",
                          border: OutlineInputBorder(),
                        ),
                        items: const [
                          DropdownMenuItem(value: 'ALL', child: Text("Svi")),
                          DropdownMenuItem(value: 'CREATED', child: Text("Kreirana")),
                          DropdownMenuItem(value: 'PAYED', child: Text("Plaćena")),
                          DropdownMenuItem(value: 'CANCELLED', child: Text("Otkazana")),
                          DropdownMenuItem(value: 'FINISHED', child: Text("Završena")),
                        ],
                        onChanged: (value) {
                          setState(() {
                            _selectedStatus = value;
                          });
                        },
                      ),
                    ),
                    SizedBox(
                      height: 60,
                      child: ElevatedButton.icon(
                        onPressed: _loadReservations,
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
                SingleChildScrollView(
                  scrollDirection: Axis.horizontal,
                  child: DataTable(
                    headingRowColor: MaterialStateProperty.resolveWith<Color>(
                          (Set<MaterialState> states) => Colors.blue.shade300,
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
                      return DataRow(cells: [
                        DataCell(Text(r.userFirstName ?? "")),
                        DataCell(Text(r.userLastName ?? "")),
                        DataCell(Text(dateFormat.format(r.startTime ?? DateTime(0)))),

                        DataCell(Text(timeFormat.format(r.startTime ?? DateTime(0)))),

                        DataCell(Text(timeFormat.format(r.endTime ?? DateTime(0)))),

                        DataCell(Text("${r.totalPrice} KM")),
                        DataCell(Text(statusTranslations[r.status] ?? r.status ?? "")),
                        DataCell(Text(r.sportsFieldName ?? "")),
                        DataCell(
                          IconButton(
                            icon: const Icon(Icons.edit),
                            onPressed: () {
                              // implement edit logic
                            },
                          ),
                        ),
                      ]);
                    }).toList(),
                  ),
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }



}