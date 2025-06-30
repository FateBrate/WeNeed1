enum MatchStatus {
  CREATED,
  FINISHED,
  CANCELLED,
}

MatchStatus matchStatusFromString(String value) =>
    MatchStatus.values.firstWhere((e) => e.toString().split('.').last == value);

String matchStatusToString(MatchStatus status) =>
    status.toString().split('.').last;

extension MatchStatusExtension on MatchStatus {
  String get bosanski {
    switch (this) {
      case MatchStatus.CREATED:
        return 'Kreiran';
      case MatchStatus.FINISHED:
        return 'Završen';
      case MatchStatus.CANCELLED:
        return 'Otkazan';
      default:
        return '';
    }
  }
}