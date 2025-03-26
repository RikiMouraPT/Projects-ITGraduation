import 'package:flutter/material.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'BMI Calculator',
      theme: ThemeData(
        colorScheme: ColorScheme.fromSeed(seedColor: Colors.green.shade300),
      ),
      home: const MyHomePage(title: 'BMI Calculator'),
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
  final GlobalKey<FormState> _formKey = GlobalKey<FormState>();

  final TextEditingController heightController = TextEditingController();
  final TextEditingController weightController = TextEditingController();

  var result = "Result";

  void submitForm() {
    if (_formKey.currentState!.validate()) {

      var height = heightController.text;
      var weight = weightController.text;

      double heightDouble = double.tryParse(height) ?? 0;
      double weightDouble = double.tryParse(weight) ?? 0;
      
      double heightM = heightDouble * 0.01;

      //Weight.kg/(Height.m^2)
      var bmi = weightDouble/(heightM * heightM);
      var bmiString = bmi.toStringAsFixed(2);

      setState(() {
        if (bmi <= 18.5) {
          result = "Under Weight ($bmiString)";
        }
        else if(bmi <= 24.9) {
          result = "Normal ($bmiString)";
        }
        else if(bmi <= 29.9) {
          result = "Overweight ($bmiString)";
        }
        else if(bmi <= 34.9) {
          result = "Obese ($bmiString)";
        }
        else {
          result = "Extreme Obese ($bmiString)";
        }
      });
    }
  }
  void clearForm() {
    heightController.clear();
    weightController.clear();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        backgroundColor: Theme.of(context).colorScheme.inversePrimary,
        title: Text(widget.title),
        centerTitle: true,
      ),
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.start,
          crossAxisAlignment: CrossAxisAlignment.center,
          children: <Widget>[
            SizedBox(height: 100),
            Image(image: AssetImage("assets/BMI.png"), width: 300),
            SizedBox(height: 50),
            Form(
              key: _formKey,
              child: Padding(
                padding: EdgeInsets.symmetric(horizontal: 50),
                child: Column(
                  children: [
                    TextFormField(
                      controller: heightController,
                      decoration: InputDecoration(
                        label: Text("Height (cm)"),
                        suffix: Text("cm"),
                      ),
                      validator: (value) {
                        if (value == null || value.isEmpty) {
                          return "Missing Data";
                        }
                        var parsedInt = int.tryParse(value);
                        if (parsedInt == null) {
                          return "Enter valid numeric values.";
                        }

                        if (parsedInt < 0 || parsedInt > 250) {
                          return "Enter a number between 0 and 250.";
                        }

                        return null;
                      },
                    ),
                    TextFormField(
                      controller: weightController,
                      keyboardType: TextInputType.number,
                      decoration: InputDecoration(
                        label: Text("Weight (kg)"),
                        suffix: Text("kg"),
                      ),
                      validator: (value) {
                        if (value == null || value.isEmpty) {
                          return "Missing Data";
                        }
                        var parsedInt = int.tryParse(value);
                        if (parsedInt == null) {
                          return "Enter valid numeric values.";
                        }

                        if (parsedInt < 0 || parsedInt > 200) {
                          return "Enter a number between 0 and 200.";
                        }

                        return null;
                      },
                    ),
                    SizedBox(height: 15),
                    Row(
                      mainAxisAlignment: MainAxisAlignment.center,
                      children: [
                        TextButton(
                          onPressed: () {
                            setState(() {
                              clearForm();
                            });
                          },
                          child: Container(
                            padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
                            decoration: BoxDecoration(
                              color: Colors.green.shade400,
                              borderRadius: BorderRadius.circular(100),
                            ),
                            child: Text(
                              "Clear",
                              style: TextStyle(
                                fontSize: 16,
                                color: Colors.white,
                              ),
                            ),
                          )
                        ),
                        TextButton(
                          onPressed: () {
                            setState(() {
                              submitForm();
                            });
                          },
                          child: Container(
                            padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
                            decoration: BoxDecoration(
                              color: Colors.green.shade400,
                              borderRadius: BorderRadius.circular(100),
                            ),
                            child: Text(
                              "BMI Calc",
                              style: TextStyle(
                                fontSize: 16,
                                color: Colors.white,
                              ),
                            ),
                          )
                        ),
                      ],
                    ),
                  ],
                ),
              ),
            ),
            SizedBox(height: 15),
            Text(
              result,
              style: TextStyle(
                fontSize: 22,
                fontWeight: FontWeight.bold
              ),
            ),
          ],
        ),
      ),
    );
  }
}
