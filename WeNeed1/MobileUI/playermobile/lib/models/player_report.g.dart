// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'player_report.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

PlayerReport _$PlayerReportFromJson(Map<String, dynamic> json) => PlayerReport(
  userName: json['userName'] as String?,
  firstName: json['firstName'] as String?,
  lastName: json['lastName'] as String?,
  totalReservations: (json['totalReservations'] as num?)?.toInt(),
  totalAmount: (json['totalAmount'] as num?)?.toDouble(),
  reservations:
      (json['reservations'] as List<dynamic>?)
          ?.map((e) => Reservation.fromJson(e as Map<String, dynamic>))
          .toList(),
);

Map<String, dynamic> _$PlayerReportToJson(PlayerReport instance) =>
    <String, dynamic>{
      'userName': instance.userName,
      'firstName': instance.firstName,
      'lastName': instance.lastName,
      'totalReservations': instance.totalReservations,
      'totalAmount': instance.totalAmount,
      'reservations': instance.reservations,
    };
