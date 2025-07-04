import 'package:flutter/material.dart';
import 'package:flutter_stripe/flutter_stripe.dart';
import 'package:playermobile/providers/user_provider.dart';
import 'package:playermobile/screens/login.dart';
import 'package:provider/provider.dart';

void main() async {
  WidgetsFlutterBinding.ensureInitialized();
  Stripe.publishableKey="pk_test_51RZspNPxAmoaM21xXeLBdVCpKN8CcQpf1QSGUJ4nbQla9GNAJQSJHrfHov0xhBzzf9OMjvM8Fyb6VB6EowJqO1bM00ong8kgTF";
  await Stripe.instance.applySettings();
  runApp(MultiProvider(
    providers: [ChangeNotifierProvider(create: (_) => UserProvider()),
    ],
    child: const MyMaterialApp(),
  ));
}
final RouteObserver<PageRoute> routeObserver = RouteObserver<PageRoute>();
class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Flutter Demo',
      theme: ThemeData(
        colorScheme: ColorScheme.fromSeed(seedColor: Colors.blue),
      ),
      home: const MyHomePage(title: 'Hello'),
    );
  }
}

class MyHomePage extends StatefulWidget {
  const MyHomePage({super.key, required this.title});
  final String title;

  @override
  State<MyHomePage> createState() => _MyHomePageState();
}

class _MyHomePageState extends State<MyHomePage> {
  int _counter = 0;

  void _incrementCounter() {
    setState(() {
      _counter++;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        backgroundColor: Theme.of(context).colorScheme.inversePrimary,
        title: Text(widget.title),
      ),
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: <Widget>[
            const Text('You have pushed the  this many times:'),
            Text(
              '$_counter',
              style: Theme.of(context).textTheme.headlineMedium,
            ),
          ],
        ),
      ),
      floatingActionButton: FloatingActionButton(
        onPressed: _incrementCounter,
        tooltip: 'Increment',
        child: const Icon(Icons.add),
      ), // This trailing comma makes auto-formatting nicer for build methods.
    );
  }
}


class MyMaterialApp extends StatelessWidget {
  const MyMaterialApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: "We need 1",
      theme: ThemeData(
        scaffoldBackgroundColor: const Color(0xFF000000),
        colorScheme: ColorScheme.fromSeed(
          seedColor: Color(0xFF115DFB),
          brightness: Brightness.dark,
          primary: Color(0xFF115DFB),
        ),
        appBarTheme: const AppBarTheme(
          backgroundColor: Color(0xFF115DFB),
          foregroundColor: Colors.white,
        ),
        textSelectionTheme: const TextSelectionThemeData(
          cursorColor: Colors.white,
          selectionColor: Color(0xFF115DFB),
          selectionHandleColor: Color(0xFF115DFB),
        ),
      ),


      home: const LoginPage(),
      navigatorObservers: [routeObserver],
    );
  }
}