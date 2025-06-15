import 'package:json_annotation/json_annotation.dart';

part 'team.g.dart';

@JsonSerializable()
class Team {
  int? id;
  String? name;
  String? sport;
  String? description;
  bool? isPublic;
  String? joinCode;
  String? teamPicture;
  String? city;
  int? captainId;
  int? memberCount;
  bool isMember;

  Team({
    this.id,
    this.name,
    this.sport,
    this.description,
    this.isPublic,
    this.joinCode,
    this.teamPicture,
    this.city,
    this.captainId,
    this.memberCount,
    required this.isMember
  });

  factory Team.fromJson(Map<String, dynamic> json) => _$TeamFromJson(json);
  Map<String, dynamic> toJson() => _$TeamToJson(this);
}
