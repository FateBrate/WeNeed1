import 'dart:convert';

import 'package:http/http.dart' as http;

import '../models/review.dart';
import 'base_provider.dart';

class ReviewProvider extends BaseProvider<Review> {
  ReviewProvider() : super("Review");

  @override
  Review fromJson(data) {
    return Review.fromJson(data);
  }

  Future<Review> insertToSportsCenter(int sportsCenterId, Review review) async {
    final uri = Uri.parse(baseUrl).resolve('/Review/sportCenter/$sportsCenterId');
    final headers = createHeaders();
    final body = jsonEncode(review.toJson());
    final response = await http.post(uri, headers: headers, body: body);

    if (response.statusCode == 200) {
      final Map<String, dynamic> decoded = jsonDecode(response.body);
      return Review.fromJson(decoded);
    } else {
      throw Exception("Failed to create review: ${response.statusCode}");
    }
  }
}
