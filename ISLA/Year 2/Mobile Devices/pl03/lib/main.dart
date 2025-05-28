import 'package:flutter/material.dart';
import 'mypl03app.dart';
import 'package:firebase_core/firebase_core.dart';

Future<void> main() async {
  WidgetsFlutterBinding.ensureInitialized();
  await Firebase.initializeApp();
  runApp(const PL03App());
}

class PL03App extends StatelessWidget {
  const PL03App({super.key});
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'PL03App',
      theme: ThemeData(
        colorScheme: ColorScheme.fromSeed(
          seedColor: const Color.fromARGB(255, 68, 91, 166),
        ),
        useMaterial3: true,
      ),
      home: const MyPL03App(title: 'PL03App'),
    );
  }
}
