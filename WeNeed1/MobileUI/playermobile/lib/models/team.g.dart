// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'team.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Team _$TeamFromJson(Map<String, dynamic> json) => Team(
  id: (json['id'] as num?)?.toInt(),
  name: json['name'] as String?,
  sport: json['sport'] as String?,
  description: json['description'] as String?,
  isPublic: json['isPublic'] as bool?,
  joinCode: json['joinCode'] as String?,
  teamPicture: json['teamPicture'] as String?,
  captainId: (json['captainId'] as num?)?.toInt(),
  memberCount: (json['memberCount'] as num?)?.toInt(),
);

Map<String, dynamic> _$TeamToJson(Team instance) => <String, dynamic>{
  'id': instance.id,
  'name': instance.name,
  'sport': instance.sport,
  'description': instance.description,
  'isPublic': instance.isPublic,
  'joinCode': instance.joinCode,
  'teamPicture': instance.teamPicture,
  'captainId': instance.captainId,
  'memberCount': instance.memberCount,
};
