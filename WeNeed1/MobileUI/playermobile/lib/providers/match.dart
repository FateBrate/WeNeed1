import 'dart:convert';

import 'package:http/http.dart' as http;
import '../models/match.dart';
import 'base_provider.dart';

class MatchProvider extends BaseProvider<Game> {
  MatchProvider() : super('Match');

  @override
  Game fromJson(data) {
    return Game.fromJson(data);
  }

  Future<void> setAttendance(int matchId, bool isAttending) async {
    final uri = Uri.parse(baseUrl).resolve('Match/$matchId/attendance');
    var headers = createHeaders();

    final response = await http.patch(
      uri,
      headers: headers,
      body: jsonEncode(isAttending),
    );

    if (!isValidResponse(response)) {
      throw Exception('Failed to update attendance');
    }
  }

  Future<Map<String, dynamic>> getMatchSummary() async {
    final uri = Uri.parse(baseUrl).resolve('Match/summary');
    var headers = createHeaders();

    final response = await http.get(uri, headers: headers);

    if (!isValidResponse(response)) {
      throw Exception('Failed to load match summary');
    }

    return jsonDecode(response.body);
  }
}
