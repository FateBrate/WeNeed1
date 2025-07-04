import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:pdf/widgets.dart' as pw;
import 'package:printing/printing.dart';

import '../models/manager_report.dart';
import '../models/user.dart';
import '../models/player_report.dart';
import '../providers/reservation_provider.dart';
import '../widgets/master_screen.dart';
import 'package:intl/date_symbol_data_local.dart';

class ReportScreen extends StatefulWidget {
  const ReportScreen({super.key});

  @override
  State<ReportScreen> createState() => _ReportScreenState();
}

class _ReportScreenState extends State<ReportScreen> {
  User? selectedUser;
  int? selectedReportType;
  int? selectedMonth;
  ManagerReport? managerReport;

  List<User> users = [];
  final provider = ReservationProvider();
  PlayerReport? report;

  @override
  void initState() {
    super.initState();
    initializeDateFormatting('bs_BA', null).then((_) {
      _fetchUsers();
      _loadManagerReport();
    });
  }

  Future<void> _fetchUsers() async {
    final data = await provider.getReservedUsers();
    setState(() {
      users = data;
    });
  }

  Future<void> _loadManagerReport() async {
    final result = await provider.getManagerReport();
    setState(() {
      managerReport = result;
    });
  }

  Future<void> _generateReport() async {
    if (selectedUser == null || selectedReportType == null) return;

    final filter = {
      'userId': selectedUser!.id,
      'reportType': selectedReportType,
      'year': DateTime.now().year,
    };

    if (selectedReportType == 1) {
      filter['month'] = selectedMonth ?? DateTime.now().month;
    }

    final result = await provider.getPlayerReport(filter);
    setState(() {
      report = result;
    });

    await _exportToPdf();
  }

  Future<void> _exportManagerReportToPdf() async {
    if (managerReport == null) return;

    final font = await PdfGoogleFonts.robotoRegular();
    final doc = pw.Document();

    doc.addPage(
      pw.MultiPage(
        theme: pw.ThemeData.withFont(base: font),
        build: (context) => [
          pw.Text('Izvještaj za Sportski Centar', style: pw.TextStyle(fontSize: 24)),
          pw.SizedBox(height: 12),
          pw.Text('Ukupan broj rezervacija: ${managerReport!.reservationCount}'),
          pw.Text('Ukupan prihod: ${managerReport!.totalAmount?.toStringAsFixed(2)} KM'),
          pw.SizedBox(height: 20),
          pw.Table.fromTextArray(
            headers: ['Datum', 'Vrijeme', 'Teren', 'Cijena (KM)'],
            data: managerReport!.reservations!.map((r) {
              final date = DateFormat('dd.MM.yyyy').format(r.startTime!);
              final time = '${DateFormat('HH:mm').format(r.startTime!)} - ${DateFormat('HH:mm').format(r.endTime!)}';
              return [
                date,
                time,
                r.sportsFieldName ?? '',
                r.totalPrice?.toStringAsFixed(2) ?? '',
              ];
            }).toList(),
          ),
        ],
      ),
    );

    await Printing.sharePdf(bytes: await doc.save(), filename: 'sportski_centar_izvjestaj.pdf');
  }

  Future<void> _exportToPdf() async {
    if (report == null) return;

    final font = await PdfGoogleFonts.robotoRegular();
    final doc = pw.Document();

    doc.addPage(
      pw.MultiPage(
        theme: pw.ThemeData.withFont(base: font),
        build: (context) => [
          pw.Text('${report!.firstName} ${report!.lastName}', style: pw.TextStyle(fontSize: 24)),
          pw.SizedBox(height: 8),
          pw.Text('Ukupan broj plaćenih rezervacija: ${report!.totalReservations}'),
          pw.Text('Ukupno potrošeno: ${report!.totalAmount} KM'),
          pw.SizedBox(height: 20),
          pw.Table.fromTextArray(
            headers: ['Datum', 'Vrijeme', 'Teren', 'Cijena (KM)'],
            data: report!.reservations!.map((r) {
              final date = DateFormat('dd.MM.yyyy').format(r.startTime!);
              final time =
                  '${DateFormat('HH:mm').format(r.startTime!)} - ${DateFormat('HH:mm').format(r.endTime!)}';
              return [
                date,
                time,
                r.sportsFieldName ?? '',
                r.totalPrice?.toStringAsFixed(2) ?? '',
              ];
            }).toList(),
          ),
        ],
      ),
    );

    await Printing.sharePdf(bytes: await doc.save(), filename: 'izvjestaj.pdf');
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
      title: "Izvještaji",
      child: Padding(
        padding: const EdgeInsets.all(16.0),
        child: SingleChildScrollView(
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              if (managerReport != null) ...[
                Row(
                  mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                  children: [
                    _buildKpiCard("Ukupan broj plaćenih rezervacija", managerReport!.reservationCount.toString()),
                    _buildKpiCard("Ukupan prihod", "${managerReport!.totalAmount?.toStringAsFixed(2)} KM"),
                    _buildKpiCard("Korisnici", users.length.toString()),
                  ],
                ),
                SizedBox(height: 16),
                ElevatedButton.icon(
                  onPressed: _exportManagerReportToPdf,
                  icon: Icon(Icons.print),
                  label: Text("Printaj izvještaj za sportski centar"),
                ),
                SizedBox(height: 24),
              ],
              DropdownButton<User>(
                hint: Text("Odaberite korisnika"),
                value: selectedUser,
                isExpanded: true,
                items: users.map((u) {
                  return DropdownMenuItem(value: u, child: Text('${u.firstName} ${u.lastName}'));
                }).toList(),
                onChanged: (value) => setState(() => selectedUser = value),
              ),
              SizedBox(height: 16),
              DropdownButton<int>(
                hint: Text("Odaberite tip izvještaja"),
                value: selectedReportType,
                isExpanded: true,
                items: [
                  DropdownMenuItem(value: 1, child: Text("Mjesečni")),
                  DropdownMenuItem(value: 2, child: Text("Godišnji")),
                ],
                onChanged: (value) => setState(() => selectedReportType = value),
              ),
              if (selectedReportType == 1) ...[
                SizedBox(height: 16),
                DropdownButton<int>(
                  hint: Text("Odaberite mjesec"),
                  value: selectedMonth,
                  isExpanded: true,
                  items: List.generate(12, (i) {
                    final month = i + 1;
                    return DropdownMenuItem(
                        value: month, child: Text(DateFormat.MMMM('bs_BA').format(DateTime(0, month))));
                  }),
                  onChanged: (value) => setState(() => selectedMonth = value),
                ),
              ],
              SizedBox(height: 24),
              ElevatedButton(
                onPressed: (selectedUser != null && selectedReportType != null)
                    ? _generateReport
                    : null,
                child: Text("Generiši izvještaj"),
              ),
            ],
          ),
        ),
      ),

    );
  }
}

Widget _buildKpiCard(String title, String value) {
  return Card(
    elevation: 3,
    child: Padding(
      padding: const EdgeInsets.all(16.0),
      child: Column(
        children: [
          Text(title, style: TextStyle(fontSize: 16, fontWeight: FontWeight.bold)),
          SizedBox(height: 8),
          Text(value, style: TextStyle(fontSize: 20, color: Colors.blueAccent)),
        ],
      ),
    ),
  );
}
