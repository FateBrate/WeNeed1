import 'dart:convert';

import 'package:http/http.dart' as http;

import '../models/sport_center.dart';
import 'base_provider.dart';

class SportsCenterProvider extends BaseProvider<SportsCenter> {
  SportsCenterProvider() : super("SportsCenter");

  @override
  SportsCenter fromJson(data) {
    return SportsCenter.fromJson(data);
  }

  Future<SportsCenter> getMySportsCenter() async {
    final uri = Uri.parse(baseUrl).resolve('SportsCenter/my');
    final headers = createHeaders();

    final response = await http.get(uri,headers: headers);
    if(response.statusCode == 200) {
      return SportsCenter.fromJson(jsonDecode(response.body));
    }else {
      throw Exception("Failed to load sports center details: ${response.statusCode}");
    }
  }
}