import 'package:json_annotation/json_annotation.dart';

part 'reservation.g.dart';

@JsonSerializable()
class Reservation {
  final int? id;
  final DateTime? startTime;
  final DateTime? endTime;
  final double? totalPrice;
  final int? sportsFieldId;
  final String? status;
  final String? cancellationReason;
  final String? sportsFieldName;
  final String? userFirstName;
  final String? userLastName;

  Reservation({
    this.id,
    this.startTime,
    this.endTime,
    this.totalPrice,
    this.sportsFieldId,
    this.status,
    this.cancellationReason,
    this.sportsFieldName,
    this.userFirstName,
    this.userLastName,
  });

  factory Reservation.fromJson(Map<String, dynamic> json) =>
      _$ReservationFromJson(json);

  Map<String, dynamic> toJson() => _$ReservationToJson(this);
}
