class SportTranslationService {
  static final Map<String, String> _sportTranslations = {
    'FOOTBALL': 'Fudbal',
    'BASKETBALL': 'Košarka',
    'FUTSAL': 'Futsal',
    'VOLLEYBALL': 'Odbojka',
    'BEACH_VOLLEYBALL': 'Odbojka na pijesku',
    'MINI_FOOTBALL': 'Mini fudbal',
    'HANDBALL': 'Rukomet',
    'TENNIS': 'Tenis',
  };

  static String translate(String? sportKey) {
    if (sportKey == null) return 'N/A';
    return _sportTranslations[sportKey] ?? sportKey;
  }
  static Map<String, String> get allTranslations => Map.unmodifiable(_sportTranslations);
}
