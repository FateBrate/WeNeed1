// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'review.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Review _$ReviewFromJson(Map<String, dynamic> json) => Review(
  id: (json['id'] as num?)?.toInt(),
  userId: (json['userId'] as num?)?.toInt(),
  sportsCenterId: (json['sportsCenterId'] as num?)?.toInt(),
  content: json['content'] as String?,
  rating: (json['rating'] as num?)?.toDouble(),
  created:
      json['created'] == null
          ? null
          : DateTime.parse(json['created'] as String),
);

Map<String, dynamic> _$ReviewToJson(Review instance) => <String, dynamic>{
  'id': instance.id,
  'userId': instance.userId,
  'sportsCenterId': instance.sportsCenterId,
  'content': instance.content,
  'rating': instance.rating,
  'created': instance.created?.toIso8601String(),
};
