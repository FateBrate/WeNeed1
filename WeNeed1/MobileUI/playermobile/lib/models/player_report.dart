import 'package:json_annotation/json_annotation.dart';
import 'reservation.dart';

part 'player_report.g.dart';

@JsonSerializable()
class PlayerReport {
  final String? userName;
  final String? firstName;
  final String? lastName;
  final int? totalReservations;
  final double? totalAmount;
  final List<Reservation>? reservations;

  PlayerReport({
    this.userName,
    this.firstName,
    this.lastName,
    this.totalReservations,
    this.totalAmount,
    this.reservations,
  });

  factory PlayerReport.fromJson(Map<String, dynamic> json) =>
      _$PlayerReportFromJson(json);

  Map<String, dynamic> toJson() => _$PlayerReportToJson(this);
}
