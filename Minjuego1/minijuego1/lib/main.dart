import 'package:flutter/material.dart';
import 'package:minijuego1/Juegos/Minijuego1.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  // This widget is the root of your application.
 
   @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: "Clicker",
      initialRoute: "/Minijuego1",
      routes: {
        "/Minijuego1": (BuildContext context) => Minijuego1()
       
      },
    );
  }
}
    