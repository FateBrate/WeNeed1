// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'squad.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Squad _$SquadFromJson(Map<String, dynamic> json) => Squad(
  id: (json['id'] as num?)?.toInt(),
  name: json['name'] as String?,
  teamId: (json['teamId'] as num?)?.toInt(),
  team:
      json['team'] == null
          ? null
          : Team.fromJson(json['team'] as Map<String, dynamic>),
  userSquads:
      (json['userSquads'] as List<dynamic>?)
          ?.map((e) => User.fromJson(e as Map<String, dynamic>))
          .toList(),
);

Map<String, dynamic> _$SquadToJson(Squad instance) => <String, dynamic>{
  'id': instance.id,
  'name': instance.name,
  'teamId': instance.teamId,
  'team': instance.team,
  'userSquads': instance.userSquads,
};
