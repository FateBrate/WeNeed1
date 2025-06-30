import 'package:json_annotation/json_annotation.dart';
part 'sport_center.g.dart';
@JsonSerializable()
class SportsCenter {
  int? id;
  String? name;
  String? address;
  String? description;
  String? startTime;
  String? endTime;
  String? image;

  SportsCenter({
    this.id,
    this.name,
    this.address,
    this.description,
    this.startTime,
    this.endTime,
    this.image,
  });
  factory SportsCenter.fromJson(Map<String, dynamic> json) => _$SportsCenterFromJson(json);
  Map<String, dynamic> toJson() => _$SportsCenterToJson(this);
}