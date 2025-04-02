import 'package:flutter/material.dart';
import 'main.dart';

class StartersPage extends StatefulWidget {
  const StartersPage({
    super.key, 
    required this.title
  });
  final String title;

  @override
  State<StartersPage> createState() => _StartersPageState();
}

class _StartersPageState extends State<StartersPage> {
  final _formKey = GlobalKey<FormState>();
  final TextEditingController inputController = TextEditingController();

  var billValue = 0;

  void submitForm() {
    if (_formKey.currentState!.validate()) {
      billValue = int.parse(inputController.text);

      Navigator.push(
        context,
        MaterialPageRoute(
          builder: (context) => MainPage(
            title: 'Main',
            billValue: billValue,
          ),
        ),
      );
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text(widget.title), centerTitle: true),
      body: Center(
        child: Column(
          children: [
            SizedBox(height: 50),
            Form(
              key: _formKey,
              child: Padding(
                padding: EdgeInsets.symmetric(horizontal: 50),
                child: Column(
                  children: [
                    TextFormField(
                      controller: inputController,
                      decoration: InputDecoration(
                        label: Text("Price (€)"),
                        suffix: Text("€"),
                      ),
                      validator: (value) {
                        if (value == null || value.isEmpty) {
                          return "Missing Data";
                        }
                        var parsedInt = int.tryParse(value);
                        if (parsedInt == null) {
                          return "Enter valid numeric values.";
                        }

                        if (parsedInt < 0) {
                          return "Enter a value >= 0";
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
                              inputController.clear();
                            });
                          },
                          child: Container(
                            padding: EdgeInsets.symmetric(
                              horizontal: 20,
                              vertical: 10,
                            ),
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
                          ),
                        ),
                        TextButton(
                          onPressed: () {
                            submitForm();
                          },
                          child: Container(
                            padding: EdgeInsets.symmetric(
                              horizontal: 20,
                              vertical: 10,
                            ),
                            decoration: BoxDecoration(
                              color: Colors.green.shade400,
                              borderRadius: BorderRadius.circular(100),
                            ),
                            child: Text(
                              "Next",
                              style: TextStyle(
                                fontSize: 16,
                                color: Colors.white,
                              ),
                            ),
                          ),
                        ),
                      ],
                    ),
                  ],
                ),
              ),
            ),
          ],
        ),
      ),
    );
  }
}
