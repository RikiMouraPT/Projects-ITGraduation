import 'dart:math';

import 'package:flutter/material.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Rock, Paper & Scissors',
      theme: ThemeData(
        colorScheme: ColorScheme.fromSeed(seedColor: Colors.tealAccent),
      ),
      home: const MyHomePage(title: 'Rock, Paper & Scissors'),
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
  String status = "Choose";
  String botImage = "assets/papel.jpg";

  void game(String userOption)
  {
    int botOption = Random().nextInt(3);
    String botOptionString = "";
    
    switch(botOption){
      case 0:
        botOptionString = 'rock';
        setState(() {
          botImage = "assets/pedra.jpg";
        });
        break;
      case 1:
        botOptionString = 'paper';
        setState(() {
          botImage = "assets/papel.jpg";
        });
        break;
      case 2:
        botOptionString = 'scissors';
        setState(() {
          botImage = "assets/tesoura.jpg";
        });
        break;
    }

    if (userOption == botOptionString) {
      setState(() {
        status = "Draw!";
      });
    }
    else if (userOption == 'rock' && botOptionString == 'scissors' ||
            userOption == 'paper' && botOptionString == 'rock' ||
            userOption == 'scissors' && botOptionString == 'paper') {
      setState(() {
        status = "You win!";
      });
    }
    else {
      setState(() {
        status = "You lose!";
      });
    }
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
          children: [
            SizedBox(height: 20),
            Text("The App Choice:", style: TextStyle(fontSize: 24)),
            SizedBox(height: 50),
            Image(
              image: AssetImage(botImage),
              height: 200,
              width: 200,
            ),
            SizedBox(height: 25),
            Text(status, style: TextStyle(fontSize: 22)),
            SizedBox(height: 25),
            Row(
              mainAxisAlignment: MainAxisAlignment.center,
              spacing: 50,
              children: [
                GestureDetector(
                  onTap: () {
                    setState(() {
                      game("rock");
                    });
                  },
                  child: Image(
                    image: AssetImage("assets/pedra.jpg"),
                    height: 75,
                    width: 75,
                  ),
                ),
                GestureDetector(
                  onTap: () {
                    setState(() {
                      game("paper");
                    });
                  },
                  child: Image(
                    image: AssetImage("assets/papel.jpg"),
                    height: 75,
                    width: 75,
                  ),
                ),
                GestureDetector(
                  onTap: () {
                    setState(() {
                      game("scissors");
                    });
                  },
                  child: Image(
                    image: AssetImage("assets/tesoura.jpg"),
                    height: 75,
                    width: 75,
                  ),
                ),
              ],
            ),
          ],
        ),
      ),
    );
  }
}
