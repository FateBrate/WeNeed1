import 'dart:convert';

import 'package:http/http.dart' as http;

import '../models/player_report.dart';
import '../models/reservation.dart';
import '../models/user.dart';
import 'base_provider.dart';

class ReservationProvider extends BaseProvider<Reservation> {
  ReservationProvider() : super("Reservation");

  @override
  Reservation fromJson(data) {
    return Reservation.fromJson(data);
  }

  Future<Reservation> cancelReservation(int id, String? reason) async {
    return await patch(id, pathSuffix: "cancel", body: reason);
  }

  Future<Reservation> finishReservation(int id) async {
    return await patch(id, pathSuffix: "finish");
  }

  Future<List<User>> getReservedUsers() async {
    final uri = Uri.parse(baseUrl).resolve('/Reservation/reserved-users');
    final headers = createHeaders();

    final response = await http.get(uri, headers: headers);

    if (response.statusCode == 200) {
      final List decoded = jsonDecode(response.body);
      return decoded.map((item) => User.fromJson(item)).toList();
    } else {
      throw Exception("Failed to fetch reserved users: ${response.statusCode}");
    }
  }

  Future<PlayerReport> getPlayerReport(Map<String, dynamic> filter) async {
    final uri = Uri.parse(baseUrl).resolve('/Reservation/report/player');
    final headers = createHeaders();
    final body = jsonEncode(filter);

    final response = await http.post(uri, headers: headers, body: body);

    if (response.statusCode == 200) {
      final Map<String, dynamic> decoded = jsonDecode(response.body);
      return PlayerReport.fromJson(decoded);
    } else {
      throw Exception("Failed to get player report: ${response.statusCode}");
    }
  }

}