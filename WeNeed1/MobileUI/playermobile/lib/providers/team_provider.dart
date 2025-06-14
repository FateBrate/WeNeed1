import '../models/team.dart';
import 'base_provider.dart';

class TeamProvider extends BaseProvider<Team> {
  TeamProvider() : super("Team");

  @override
  Team fromJson(data) {
    return Team.fromJson(data);
  }
}
