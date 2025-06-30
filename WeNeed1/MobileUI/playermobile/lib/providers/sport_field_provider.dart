import 'dart:convert';

import 'package:http/http.dart' as http;

import '../models/sport_field.dart';
import 'base_provider.dart';

class SportFieldProvider extends BaseProvider<SportField> {

  SportFieldProvider(): super("SportField");
  @override
  SportField fromJson(data) {
    return SportField.fromJson(data);
  }

  Future<List<String>> getAvailableSlots(int sportsFieldId, DateTime date) async {
    final uri = Uri.parse(baseUrl).resolve(
        "/Reservation/available-slots?sportsFieldId=$sportsFieldId&date=${Uri.encodeComponent(date.toIso8601String())}");

    final headers = createHeaders();
    final response = await http.get(uri, headers: headers);

    if (response.statusCode == 200) {
      final List<dynamic> decoded = jsonDecode(response.body);
      return decoded.map((e) => e.toString().substring(0, 5)).toList();
    } else {
      throw Exception("Greška pri dohvaćanju termina: ${response.statusCode}");
    }
  }
}