// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'sport_field.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

SportField _$SportFieldFromJson(Map<String, dynamic> json) => SportField(
  id: (json['id'] as num?)?.toInt(),
  name: json['name'] as String?,
  sportType: json['sportType'] as String?,
  pricePerHour: (json['pricePerHour'] as num?)?.toDouble(),
  description: json['description'] as String?,
  sportsCenterId: (json['sportsCenterId'] as num?)?.toInt(),
);

Map<String, dynamic> _$SportFieldToJson(SportField instance) =>
    <String, dynamic>{
      'id': instance.id,
      'name': instance.name,
      'sportType': instance.sportType,
      'pricePerHour': instance.pricePerHour,
      'description': instance.description,
      'sportsCenterId': instance.sportsCenterId,
    };
