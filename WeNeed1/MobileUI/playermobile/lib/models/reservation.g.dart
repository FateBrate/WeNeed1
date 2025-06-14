// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'reservation.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Reservation _$ReservationFromJson(Map<String, dynamic> json) => Reservation(
  id: (json['id'] as num?)?.toInt(),
  startTime:
      json['startTime'] == null
          ? null
          : DateTime.parse(json['startTime'] as String),
  endTime:
      json['endTime'] == null
          ? null
          : DateTime.parse(json['endTime'] as String),
  totalPrice: (json['totalPrice'] as num?)?.toDouble(),
  sportsFieldId: (json['sportsFieldId'] as num?)?.toInt(),
  status: json['status'] as String?,
  cancellationReason: json['cancellationReason'] as String?,
  sportsFieldName: json['sportsFieldName'] as String?,
  userFirstName: json['userFirstName'] as String?,
  userLastName: json['userLastName'] as String?,
);

Map<String, dynamic> _$ReservationToJson(Reservation instance) =>
    <String, dynamic>{
      'id': instance.id,
      'startTime': instance.startTime?.toIso8601String(),
      'endTime': instance.endTime?.toIso8601String(),
      'totalPrice': instance.totalPrice,
      'sportsFieldId': instance.sportsFieldId,
      'status': instance.status,
      'cancellationReason': instance.cancellationReason,
      'sportsFieldName': instance.sportsFieldName,
      'userFirstName': instance.userFirstName,
      'userLastName': instance.userLastName,
    };
