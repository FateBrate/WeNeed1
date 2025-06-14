// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'sport_center.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

SportsCenter _$SportsCenterFromJson(Map<String, dynamic> json) => SportsCenter(
  id: (json['id'] as num?)?.toInt(),
  name: json['name'] as String?,
  address: json['address'] as String?,
  description: json['description'] as String?,
  startTime: json['startTime'] as String?,
  endTime: json['endTime'] as String?,
  image: json['image'] as String?,
);

Map<String, dynamic> _$SportsCenterToJson(SportsCenter instance) =>
    <String, dynamic>{
      'id': instance.id,
      'name': instance.name,
      'address': instance.address,
      'description': instance.description,
      'startTime': instance.startTime,
      'endTime': instance.endTime,
      'image': instance.image,
    };
