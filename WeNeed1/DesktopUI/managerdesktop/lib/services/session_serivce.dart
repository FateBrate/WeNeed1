class SessionService {
  static final SessionService _instance = SessionService._internal();

  factory SessionService() {
    return _instance;
  }

  SessionService._internal();

  int? sportsCenterId;

  void clear() {
    sportsCenterId = null;
  }
}
