import 'package:flutter/material.dart';
import 'bill.dart';

class DessertPage extends StatefulWidget {
  const DessertPage({
    super.key, 
    required this.title,
    required this.billValue,
  });
  final String title;
  final int billValue;

  @override
  State<DessertPage> createState() => _DessertPageState();
}
class _DessertPageState extends State<DessertPage> {
  final _formKey = GlobalKey<FormState>();
  final TextEditingController inputController = TextEditingController();

  var billValue = 0;

  void submitForm() {
    if (_formKey.currentState!.validate()) {
      var billValue = widget.billValue + int.parse(inputController.text);

      Navigator.push(
        context,
        MaterialPageRoute(
          builder: (context) => BillPage(
            title: 'Bill',
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
