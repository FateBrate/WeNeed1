// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'user.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

User _$UserFromJson(Map<String, dynamic> json) => User(
  id: (json['id'] as num?)?.toInt(),
  firstName: json['firstName'] as String?,
  lastName: json['lastName'] as String?,
  email: json['email'] as String?,
  userName: json['userName'] as String?,
  role: json['role'] as String?,
  phoneNumber: json['phoneNumber'] as String?,
  profilePicture: json['profilePicture'] as String?,
  sports: (json['sports'] as List<dynamic>?)?.map((e) => e as String).toList(),
);

Map<String, dynamic> _$UserToJson(User instance) => <String, dynamic>{
  'id': instance.id,
  'firstName': instance.firstName,
  'lastName': instance.lastName,
  'email': instance.email,
  'userName': instance.userName,
  'role': instance.role,
  'phoneNumber': instance.phoneNumber,
  'profilePicture': instance.profilePicture,
  'sports': instance.sports,
};
