import 'dart:convert';

import 'package:http/http.dart' as http;

import '../models/user.dart';
import 'base_provider.dart';

class UserProvider extends BaseProvider<User> {
  UserProvider() : super("User");

  @override
  User fromJson(data) {
    return User.fromJson(data);
  }

  Future<User> getProfile() async {
    final uri = Uri.parse(baseUrl).resolve('/User/profile');
    final headers = createHeaders();

    final response = await http.get(uri, headers: headers);

    if (response.statusCode == 200) {
      return User.fromJson(jsonDecode(response.body));
    } else {
      throw Exception("Failed to load user profile: ${response.statusCode}");
    }
  }

  Future<void> changePassword({
    required int id,
    required String password,
    required String newPassword,
  }) async {
    final uri = Uri.parse(baseUrl).resolve('/User/change-password');
    final headers = createHeaders();
    final body = jsonEncode({
      'id': id,
      'password': password,
      'newPassword': newPassword,
    });

    final response = await http.put(uri, headers: headers, body: body);

    if (response.statusCode != 200) {
      print('Change password failed!');
      print('Status code: ${response.statusCode}');
      print('Response body: ${response.body}');
      throw Exception("Greška u promijeni lozinke: ${response.body}");
    }
  }
}