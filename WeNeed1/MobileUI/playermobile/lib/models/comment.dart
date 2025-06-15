class Comment {
  final int id;
  final String? content;
  final DateTime? created;
  final int? matchId;
  final int? userId;
  final String? userName;
  final String? profilePicture;

  Comment({
     required this.id,
     this.content,
     this.created,
     this.matchId,
     this.userId,
     this.userName,
    this.profilePicture,
  });

  factory Comment.fromJson(Map<String, dynamic> json) {
    final user = json['user'] ?? {};
    return Comment(
      id: json['id'],
      content: json['content'],
      created: DateTime.parse(json['created']),
      matchId: json['matchId'],
      userId: json['userId'],
      userName: user['userName'] ?? '',
      profilePicture: user['profilePicture'],
    );
  }
}
