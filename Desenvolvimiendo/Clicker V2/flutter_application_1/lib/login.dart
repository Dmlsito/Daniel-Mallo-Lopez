// ignore_for_file: prefer_const_constructors, use_key_in_widget_constructors, unused_import, unnecessary_import

import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:matcher/matcher.dart';
// import 'package:mysql1/mysql1.dart';
// import 'package:http/http.dart' as http;

import 'datos.dart';
import 'main.dart';

class LoginStates extends StatefulWidget {
  @override
  LoginStatesState createState() => LoginStatesState();
  }

  class LoginStatesState extends State<LoginStates>{
   @override
  Widget build(Object context) {
    return Scaffold(
      drawer: Drawer(
          //Borde redondeado
          shape: RoundedRectangleBorder(
            borderRadius: BorderRadius.only(
                topRight: Radius.circular(20),
                bottomRight: Radius.circular(20)),
          ),
          child: ListView(children: [
            DrawerHeader(
              child: Container(
                  alignment: Alignment.center,
                  child: Icon(
                    Icons.home,
                    size: 70,
                  )),
            ),
            ListTile(
              title: Text("Ranking"),
              leading: Icon(Icons.integration_instructions),
            ),
            ListTile(
              title: Text("Contacto DEVS"),
              leading: Icon(Icons.integration_instructions),
            ),
          ])),
      body: Center(
        child: Column(
          children: [
            //Contenedor nombre
            Container(
              child: Form(
                //TextoFormField del nombre
                child: TextFormField(
                  validator:(value){
                    if(value!.isEmpty) {
                        return "Por favor introduzca un nombre";
                    }
                  }
                )
                ),
              ),
            
             Container(
              child: Form(
                child: TextFormField(
                  validator: (value){
                    if(value!.isEmpty){
                      return "introduzca una contraseña";
                    }
                  }
                ),
              ),
            ),
          ],
        ),
      ),

      floatingActionButton: FloatingActionButton(
          onPressed: () {
            //setNombre();
          
          },
          child: Icon(Icons.abc)),

      //Container(child: LoginStates()),
    );
  }

  // void comparaUsuario() {
  //   String nombreComparar;
  //   db.getConnection().then((conn) {
  //     String sqlConsulta = "select nombre from usuarios";
  //     conn.query(sqlConsulta).then((results) {
  //       for (var row in results) {
  //         for (int i = 0; i > results.length; i++) {
  //           nombreComparar = row[i];
  //           if (nombre == nombreComparar) {
  //             funcionLogin();
  //           } else {
  //             setState(() {
  //               nombre = row[i];
  //             });
  //             funcionRegistrar();
  //           }
  //         }
  //       }
  //     });
  //   });
  // }

  // void funcionLogin() {}

  // void funcionRegistrar() {
  //   db.getConnection().then((conn) {
  //     String sqlConsulta1 =
  //         "insert into usuarios (nombre) values ('esto es una prueba2')";
  //     conn.query(sqlConsulta1).then((results) {});
  //   });
  // }

}