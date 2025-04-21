import 'package:json_annotation/json_annotation.dart';
part 'sport_field.g.dart';
@JsonSerializable()
class SportField {
  final int? id;
  final String? name;
  final String? sportType;
  final double? pricePerHour;
  final String? description;
  final int? sportsCenterId;

  SportField({
    this.id,
    this.name,
    this.sportType,
    this.pricePerHour,
    this.description,
    this.sportsCenterId,
  });

  factory SportField.fromJson(Map<String, dynamic> json) => _$SportFieldFromJson(json);
  Map<String, dynamic> toJson() => _$SportFieldToJson(this);
}