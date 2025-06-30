import 'package:json_annotation/json_annotation.dart';

part 'review.g.dart';

@JsonSerializable()
class Review {
  final int? id;
  final int? userId;
  final int? sportsCenterId;
  final String? content;
  final double? rating;
  final DateTime? created;

  Review({
    this.id,
    this.userId,
    this.sportsCenterId,
    this.content,
    this.rating,
    this.created,
  });

  factory Review.fromJson(Map<String, dynamic> json) => _$ReviewFromJson(json);

  Map<String, dynamic> toJson() => _$ReviewToJson(this);
}
