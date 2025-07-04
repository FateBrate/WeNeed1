import 'package:http/http.dart' as http;

import '../models/squad.dart';
import 'base_provider.dart';

class SquadProvider extends BaseProvider<Squad> {
  SquadProvider() : super("Squad");

  @override
  Squad fromJson(data) {
    return Squad.fromJson(data);
  }

  Future<void> joinSquad(int squadId) async {
    final uri = Uri.parse(baseUrl).resolve('Squad/$squadId/join');
    var headers = createHeaders();

    final response = await http.post(uri, headers: headers);
    if (!isValidResponse(response)) {
      throw Exception("Failed to join the squad");
    }
  }

  Future<void> leaveSquad(int squadId) async {
    final uri = Uri.parse(baseUrl).resolve('Squad/$squadId/leave');
    var headers = createHeaders();

    final response = await http.delete(uri, headers: headers);
    if (!isValidResponse(response)) {
      throw Exception("Failed to leave the squad");
    }
  }
}
