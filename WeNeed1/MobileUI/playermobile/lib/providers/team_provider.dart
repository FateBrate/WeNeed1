import 'dart:convert';

import 'package:http/http.dart' as http;

import '../models/team.dart';
import 'base_provider.dart';

class TeamProvider extends BaseProvider<Team> {
  TeamProvider() : super("Team");

  @override
  Team fromJson(data) {
    return Team.fromJson(data);
  }

  Future<Map<String, dynamic>> getByIdRaw(int id) async {
    final uri = Uri.parse(baseUrl).resolve('Team/$id');
    var headers = createHeaders();

    final response = await http.get(uri,headers: headers);
    if (isValidResponse(response)) {
      var data = jsonDecode(response.body);
      return data as Map<String, dynamic>;
    } else {
      throw Exception("Failed to load team with id $id");
    }
  }

  Future<void> joinTeam(int teamId) async {
    final uri = Uri.parse(baseUrl).resolve('Team/$teamId/join');
    var headers = createHeaders();

    final response = await http.post(uri, headers: headers);
    if (!isValidResponse(response)) {
      throw Exception('Failed to join the team');
    }
  }

  Future<void> leaveTeam(int teamId) async {
    final uri = Uri.parse(baseUrl).resolve('Team/$teamId/leave');
    var headers = createHeaders();

    final response = await http.delete(uri, headers: headers);
    if (!isValidResponse(response)) {
      throw Exception('Failed to leave the team');
    }
  }
}
