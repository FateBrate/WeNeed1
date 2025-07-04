import 'package:json_annotation/json_annotation.dart';
import 'package:playermobile/models/team.dart';
import 'package:playermobile/models/user.dart';

part 'squad.g.dart';
@JsonSerializable()
class Squad {
  int? id;
  String? name;
  int? teamId;
  Team? team;
  List<User>? userSquads;

  Squad({
    this.id,
    this.name,
    this.teamId,
    this.team,
    this.userSquads,
  });

  factory Squad.fromJson(Map<String, dynamic> json) => _$SquadFromJson(json);
  Map<String, dynamic> toJson() => _$SquadToJson(this);
}