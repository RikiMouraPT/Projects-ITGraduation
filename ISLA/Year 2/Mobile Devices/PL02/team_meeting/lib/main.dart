import 'package:flutter/material.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Team Meeting',
      theme: ThemeData(
        colorScheme: ColorScheme.fromSeed(seedColor: Colors.deepOrangeAccent),
      ),
      home: const MyHomePage(title: 'Team Meeting'),
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
  int _participants = 0;

  void _incrementParticipants() {
    setState(() {
      if (_participants < 20)
      {
        _participants++;
      }
    });
  }
    void _decrementParticipants() {
      setState(() {
        if (_participants > 0)
        {
          _participants--;
        }
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
            Text(
              'Team Meeting',
              style: TextStyle(
                color: Colors.deepOrange[500],
                fontSize: 36,
                fontWeight: FontWeight.bold
              ),
            ),
            SizedBox(
              height: 40,
            ),
            Text(
              '$_participants',
              style: TextStyle(
                color: Colors.deepOrange[200],
                fontSize: 82,
                fontWeight: FontWeight.bold
              )
            ),
            SizedBox(
              height: 40,
            ),
            Row(
              mainAxisAlignment: MainAxisAlignment.center,
              spacing: 10,
              children: [
                TextButton(
                  onPressed: _participants == 0 ? null : _decrementParticipants,
                  style: TextButton.styleFrom(
                    fixedSize: Size(100,100),
                    shape: RoundedRectangleBorder(
                      borderRadius: BorderRadius.circular(10)
                    ),
                    backgroundColor: Colors.amber,
                    disabledBackgroundColor: Colors.grey[400],
                    disabledForegroundColor: Colors.grey[600],
                  ),
                  child: const Text(
                    "Leave",
                    style: TextStyle(
                      fontSize: 24.0
                    ),
                  ),
                ),
                TextButton(
                  onPressed: _participants == 20 ? null : _incrementParticipants,
                  style: TextButton.styleFrom(
                    fixedSize: Size(100,100),
                    shape: RoundedRectangleBorder(
                      borderRadius: BorderRadius.circular(10)
                    ),
                    backgroundColor: Colors.amber,
                    disabledBackgroundColor: Colors.grey[400],
                    disabledForegroundColor: Colors.grey[600],
                  ),
                  child: const Text(
                    "Join",
                    style: TextStyle(
                      fontSize: 24.0
                    ),
                  ),
                ),
              ],
            )
          ],
        ),
      ),
    );
  }
}
