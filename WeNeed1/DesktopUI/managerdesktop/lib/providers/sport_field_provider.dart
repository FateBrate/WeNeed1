import 'package:managerdesktop/models/sport_field.dart';
import 'package:managerdesktop/providers/base_provider.dart';

class SportFieldProvider extends BaseProvider<SportField> {

  SportFieldProvider(): super("SportField");
  @override
  SportField fromJson(data) {
    return SportField.fromJson(data);
  }

}