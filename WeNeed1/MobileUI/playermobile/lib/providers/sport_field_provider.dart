import '../models/sport_field.dart';
import 'base_provider.dart';

class SportFieldProvider extends BaseProvider<SportField> {

  SportFieldProvider(): super("SportField");
  @override
  SportField fromJson(data) {
    return SportField.fromJson(data);
  }

}