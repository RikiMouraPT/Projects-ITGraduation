import 'package:flutter/material.dart';

class BillPage extends StatefulWidget {
  const BillPage({
    super.key, 
    required this.title,
    required this.billValue,
  });
  final String title;
  final int billValue;

  @override
  State<BillPage> createState() => _BillPageState();
}
class _BillPageState extends State<BillPage> {
  final _formKey = GlobalKey<FormState>();
  final TextEditingController inputController = TextEditingController();

  void submitForm() {
    if (_formKey.currentState!.validate()) {
      Navigator.pushNamed(context, '/home');
    }
  }
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text(widget.title), centerTitle: true),
      body: Center(
        child: Column(
          children:[
            //Show the total bill
            SizedBox(height: 50),
            Text(
              "Total Bill \n ${widget.billValue} €",
              style: TextStyle(
                fontSize: 30,
                fontWeight: FontWeight.bold,
              ),
              textAlign: TextAlign.center,
            ),
            SizedBox(height: 20),
            TextButton(
              onPressed:() {
                Navigator.pushNamed(context, '/starters' );
              },
              child: Container(
                padding: EdgeInsets.symmetric(
                  horizontal: 30,
                  vertical: 10,
                ),
                decoration: BoxDecoration(
                  color: Colors.green.shade400,
                  borderRadius: BorderRadius.circular(100),
                ),
                child: Text(
                  "Restart",
                  style: TextStyle(
                    fontSize: 16,
                    color: Colors.white,
                  ),
                ),
              ),
            ),
          ]
        ),
      ),
    );
  }
}
