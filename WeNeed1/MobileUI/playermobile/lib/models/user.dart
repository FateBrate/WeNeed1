import 'package:json_annotation/json_annotation.dart';
part 'user.g.dart';
@JsonSerializable()
class User {
  int? id;
  String? firstName;
  String? lastName;
  String? email;
  String? userName;
  String? role;
  String? phoneNumber;
  String? profilePicture;
  List<String>? sports;

  User({
    this.id,
    this.firstName,
    this.lastName,
    this.email,
    this.userName,
    this.role,
    this.phoneNumber,
    this.profilePicture,
    this.sports,
  });


  factory User.fromJson(Map<String, dynamic> json) => _$UserFromJson(json);

  Map<String, dynamic> toJson() => _$UserToJson(this);
}