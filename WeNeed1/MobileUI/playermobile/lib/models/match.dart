// game.dart
import 'package:playermobile/models/match_Status.dart';

class Game {
  final int id;
  final int? teamId;
  final DateTime? matchDate;
  final String? result;
  final MatchStatus? status;
  final int? attendingCount;
  final int? notAttendingCount;
  final bool? isCurrentUserAttending;

  Game({
    required this.id,
     this.teamId,
     this.matchDate,
     this.result,
     this.status,
     this.attendingCount,
     this.notAttendingCount,
    this.isCurrentUserAttending,
  });

  factory Game.fromJson(Map<String, dynamic> json) {
    return Game(
      id: json['id'],
      teamId: json['teamId'],
      matchDate: DateTime.parse(json['matchDate']),
      result: json['result'],
      status: MatchStatus.values.firstWhere(
              (e) => e.toString().split('.').last == json['status']),
      attendingCount: json['attendingCount'],
      notAttendingCount: json['notAttendingCount'],
      isCurrentUserAttending: json['isCurrentUserAttending'],
    );
  }
}
