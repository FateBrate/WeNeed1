import 'package:json_annotation/json_annotation.dart';
import 'package:managerdesktop/models/reservation.dart';
part 'manager_report.g.dart';
@JsonSerializable()
class ManagerReport {
  final int? reservationCount;
  final double? totalAmount;
  final List<Reservation>? reservations;

  ManagerReport({
     this.reservationCount,
     this.totalAmount,
     this.reservations,
  });

  factory ManagerReport.fromJson(Map<String, dynamic> json) =>
      _$ManagerReportFromJson(json);

  Map<String, dynamic> toJson() => _$ManagerReportToJson(this);
}