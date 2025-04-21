import 'package:flutter/cupertino.dart';
import 'package:managerdesktop/widgets/master_screen.dart';

class FieldsScreen  extends StatefulWidget {
  const FieldsScreen([Key? key]) : super(key: key);

  @override
  State<FieldsScreen> createState() => _FieldScreenState();
}

class _FieldScreenState extends State<FieldsScreen> {
  Widget build(BuildContext context){
    return MasterScreenWidget(
      child: Text("Tereni"),
    );
  }
}