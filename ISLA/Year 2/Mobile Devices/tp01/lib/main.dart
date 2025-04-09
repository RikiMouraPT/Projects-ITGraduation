import 'package:flutter/material.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Flutter Demo',
      theme: ThemeData(
        colorScheme: ColorScheme.fromSeed(seedColor: Colors.deepPurple),
      ),
      home: const MyHomePage(title: 'Flutter Demo Home Page'),
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
  final GlobalKey<FormState> fromFormKey = GlobalKey<FormState>();
  final TextEditingController fromController = TextEditingController();


  int fromBase = 10;
  int toBase = 10;
  String fromValue = "";
  String result = "";

  void fromButton(String base) {
    setState(() {
      if (base == "Bin") {
        fromBase = 2;
      } else if (base == "Oct") {
        fromBase = 8;
      } else if (base == "Dec") {
        fromBase = 10;
      } else if (base == "Hex") {
        fromBase = 16;
      }
    });
  }

  void toButton(String base) {
    setState(() {
      if (base == "Bin") {
        toBase = 2;
      } else if (base == "Oct") {
        toBase = 8;
      } else if (base == "Dec") {
        toBase = 10;
      } else if (base == "Hex") {
        toBase = 16;
      }
      calculateResult(fromBase, toBase);
    });
  }

  void calculateResult(int fromBase, int toBase) {
    setState(() {
      if (fromFormKey.currentState!.validate()) {
        fromValue = fromController.text;

        int decimalValue = int.parse(fromValue, radix: fromBase);

        result = decimalValue.toRadixString(toBase).toUpperCase();
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
          mainAxisAlignment: MainAxisAlignment.start,
          crossAxisAlignment: CrossAxisAlignment.center,
          children: <Widget>[
            SizedBox(height: 50,),
            Row(
              mainAxisAlignment: MainAxisAlignment.center,
              children: [
                Text(
                  "Convert from:", 
                  style: TextStyle(fontSize: 20),
                  textAlign: TextAlign.left,
                ),
                TextButton(
                  onPressed: () => fromButton("Bin"), 
                  child: Text(
                    "Bin",
                    style: TextStyle(
                      backgroundColor: fromBase == 2 ? Colors.yellowAccent : Colors.transparent,
                      fontSize: 20
                    ),
                  )),
                TextButton(
                  onPressed: () => fromButton("Oct"), 
                  child: Text(
                    "Oct",
                    style: TextStyle(
                      backgroundColor: fromBase == 8 ? Colors.yellowAccent : Colors.transparent,
                      fontSize: 20
                    ),
                  ),
                ),
                TextButton(
                  onPressed: () => fromButton("Dec"), 
                  child: Text(
                    "Dec",
                    style: TextStyle(
                      backgroundColor: fromBase == 10 ? Colors.yellowAccent : Colors.transparent,
                      fontSize: 20
                    ),
                  )
                ),
                TextButton(
                  onPressed: () => fromButton("Hex"), 
                  child: Text(
                    "Hex",
                    style: TextStyle(
                      backgroundColor: fromBase == 16 ? Colors.yellowAccent : Colors.transparent,
                      fontSize: 20
                    ),
                  )
                ),
              ],
            ),
            Form(
              key: fromFormKey,
              child: Padding(
                padding: EdgeInsets.symmetric(horizontal: 25), 
                child: TextFormField(
                  controller: fromController,
                  decoration: InputDecoration(
                    label: Text("Number"),
                    suffix: Text(
                      fromBase == 2 ? "bin" 
                      : fromBase == 8 ? "oct" 
                      : fromBase == 10 ? "dec" 
                      : "hex"
                    ),
                  ),
                  validator: (value) {
                    if (value == null || value.isEmpty) {
                      return "Missing Data";
                    }
                    var parsedInt = int.tryParse(value, radix: fromBase);
                    if (parsedInt == null) {
                      if (fromBase == 2) {
                        result = "Enter valid binary values.";
                        return "Enter valid binary values.";
                      } else if (fromBase == 8){
                        result = "Enter valid octal values.";
                        return "Enter valid octal values.";
                      }
                      else if (fromBase == 10) {
                        result = "Enter valid decimal values.";
                        return "Enter valid decimal values.";
                      }
                      else if (fromBase == 16) {
                        result = "Enter valid hexadecimal values.";
                        return "Enter valid hexadecimal values.";
                      }
                      else {
                        result = "Enter valid values.";
                        return "Enter valid values.";
                      }
                    }
                    if (parsedInt < 0) {
                      return "Enter a value >= 0";
                    }

                    return null;
                  },
                ),
              ),
            ),
            SizedBox(height: 50,),
            Row(
              mainAxisAlignment: MainAxisAlignment.center,
              children: [
                Text(
                  "Convert to:", 
                  style: TextStyle(fontSize: 20),
                ),
                TextButton(
                  onPressed: () {
                    toButton("Bin");
                    calculateResult(fromBase, toBase);
                  }, 
                  child: Text(
                    "Bin",
                    style: TextStyle(
                      backgroundColor: toBase == 2 ? Colors.yellowAccent : Colors.transparent,
                      fontSize: 20
                    ),
                  )),
                TextButton(
                  onPressed: () {
                    toButton("Oct");
                    calculateResult(fromBase, toBase);
                  },
                  child: Text(
                    "Oct",
                    style: TextStyle(
                      backgroundColor: toBase == 8 ? Colors.yellowAccent : Colors.transparent,
                      fontSize: 20
                    ),
                  ),
                ),
                TextButton(
                  onPressed: () {
                    toButton("Dec");
                    calculateResult(fromBase, toBase);
                  }, 
                  child: Text(
                    "Dec",
                    style: TextStyle(
                      backgroundColor: toBase == 10 ? Colors.yellowAccent : Colors.transparent,
                      fontSize: 20
                    ),
                  )
                ),
                TextButton(
                  onPressed: () {
                    toButton("Hex");
                    calculateResult(fromBase, toBase);
                  },
                  child: Text(
                    "Hex",
                    style: TextStyle(
                      backgroundColor: toBase == 16 ? Colors.yellowAccent : Colors.transparent,
                      fontSize: 20
                    ),
                  )
                ),
              ],
            ),
            SizedBox(height: 25),
            Text(
              "Result\n $result",
              textAlign: TextAlign.center,
              style: TextStyle(
                fontSize: 24
              ),
            ),
          ],
        ),
      ),
    );
  }
}
