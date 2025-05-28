import 'package:flutter/material.dart';
import 'mypl03app_widgetadd.dart';
import 'mypl03app_widgetlist.dart';
import 'mypl03app_widgetsettings.dart';

class MyPL03App extends StatefulWidget {
  final String title;
  const MyPL03App({super.key, required this.title});
  @override
  State<MyPL03App> createState() => _MyPL03AppState();
}

class _MyPL03AppState extends State<MyPL03App> {
  int _selectedIndex = 0;
  late final List<Widget> _screenOptions;
  @override
  void initState() {
    super.initState();
    _screenOptions = [
      buildWidgetAdd(),
      buildWidgetList(),
      buildWidgetSettings(),
    ];
  }

  void _onItemTapped(int index) {
    setState(() {
      _selectedIndex = index;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        backgroundColor: Theme.of(context).colorScheme.inversePrimary,
        title: Text(widget.title),
      ),
      body: IndexedStack(index: _selectedIndex, children: _screenOptions),
      bottomNavigationBar: BottomNavigationBar(
        items: const <BottomNavigationBarItem>[
          BottomNavigationBarItem(icon: Icon(Icons.add), label: 'Add'),
          BottomNavigationBarItem(icon: Icon(Icons.list), label: 'List'),
          BottomNavigationBarItem(
            icon: Icon(Icons.settings),
            label: 'Settings',
          ),
        ],
        currentIndex: _selectedIndex,
        selectedItemColor: const Color.fromARGB(255, 68, 91, 166),
        onTap: _onItemTapped,
      ),
    );
  }
}
