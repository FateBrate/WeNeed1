import 'dart:convert';
import 'package:http/http.dart' as http;

import '../models/team.dart';
import 'base_provider.dart';

class TeamRecommenderProvider extends BaseProvider<Team> {
  TeamRecommenderProvider() : super("TeamRecommender");

  @override
  Team fromJson(data) {
    return Team.fromJson(data);
  }

  Future<List<Team>> getRecommendations(int userId) async {
    final uri = Uri.parse(baseUrl).resolve('api/TeamRecommender/recommend/$userId');
    final headers = createHeaders();

    final response = await http.get(uri, headers: headers);

    if (isValidResponse(response)) {
      final List<dynamic> jsonList = jsonDecode(response.body);
      return jsonList.map((e) => fromJson(e)).toList();
    } else {
      throw Exception("Failed to fetch team recommendations");
    }
  }
}
