import 'package:flutter/material.dart';

Widget buildWidgetSettings() {
  return const Scaffold(
    body: SingleChildScrollView(
      child: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [Text("Settings")],
        ),
      ),
    ),
  );
}
