// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'manager_report.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

ManagerReport _$ManagerReportFromJson(Map<String, dynamic> json) =>
    ManagerReport(
      reservationCount: (json['reservationCount'] as num?)?.toInt(),
      totalAmount: (json['totalAmount'] as num?)?.toDouble(),
      reservations:
          (json['reservations'] as List<dynamic>?)
              ?.map((e) => Reservation.fromJson(e as Map<String, dynamic>))
              .toList(),
    );

Map<String, dynamic> _$ManagerReportToJson(ManagerReport instance) =>
    <String, dynamic>{
      'reservationCount': instance.reservationCount,
      'totalAmount': instance.totalAmount,
      'reservations': instance.reservations,
    };
