import 'dart:convert';
import 'package:http/http.dart' as http;

import '../models/sport_center.dart';
import 'base_provider.dart';

class SportsCenterRecommenderProvider extends BaseProvider<SportsCenter> {
  SportsCenterRecommenderProvider() : super("SportsCenterRecommender");

  @override
  SportsCenter fromJson(data) {
    return SportsCenter.fromJson(data);
  }

  Future<List<SportsCenter>> getRecommendations(int userId) async {
    final uri = Uri.parse(baseUrl).resolve('api/SportCenterRecommender/recommend/$userId');
    final headers = createHeaders();

    final response = await http.get(uri, headers: headers);

    if (isValidResponse(response)) {
      final List<dynamic> jsonList = jsonDecode(response.body);
      return jsonList.map((e) => fromJson(e)).toList();
    } else {
      throw Exception("Failed to fetch sports center recommendations");
    }
  }
}
