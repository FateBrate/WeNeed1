class SessionService {
  static final SessionService _instance = SessionService._internal();

  factory SessionService() {
    return _instance;
  }

  SessionService._internal();

  int? playerId;

  void clear() {
    playerId = null;
  }
}
