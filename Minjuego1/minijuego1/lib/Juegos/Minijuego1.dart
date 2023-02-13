// ignore_for_file: avoid_unnecessary_containers, prefer_const_constructors, use_key_in_widget_constructors, camel_case_types, curly_braces_in_flow_control_structures


import 'dart:async';
import 'dart:math';

import 'package:flutter/material.dart';

class Minijuego1 extends StatelessWidget{
  @override
  Widget build(BuildContext context) {
   return Scaffold(body: Container(child: StatesMinijuego1()));
  }
}

var size;
var alturaPantalla;
var anchoPantalla;
double top1 = 50;
double top2 = 50;
double top3 = 50;
double top4 = 50;
double top5 = 50;
double top6 = 50;
double top7 = 50;
double top8 = 50;
double top9 = 50;
int contadorTimerCaida = 0;
bool vueltaEmpezarObjeto1 = true;
bool vueltaEmpezarObjeto2 = true;
bool vueltaEmpezarObjeto3 = true;
bool vueltaEmpezarObjeto4 = true;
bool vueltaEmpezarObjeto5 = true;
bool vueltaEmpezarObjeto6 = true;
bool vueltaEmpezarObjeto7 = true;
bool vueltaEmpezarObjeto8 = true;
bool vueltaEmpezarObjeto9 = true;

Timer? timerCaida;

class StatesMinijuego1 extends StatefulWidget{
  @override
  juego createState() => juego();
}

class juego extends State<StatesMinijuego1>{
  @override
  Widget build(BuildContext context) {

     //Recogemos las medidas de la pantalla 
     setState(() {
      size = MediaQuery.of(context).size;
      alturaPantalla = size.height;
      anchoPantalla = size.width;
    });
   
   return Scaffold(
    body: Center(

       child: Stack(
        children: [
          Container(
          height: 20,
        width: 20,
          margin: EdgeInsets.only(top : top1 ),
      
        decoration: BoxDecoration(
           color: Colors.blue,
          
        )
        ),
        
          Container(
          height: 20,
        width: 20,
          margin: EdgeInsets.only(top : top2, left: anchoPantalla * 0.7 ),
      
        decoration: BoxDecoration(
           color: Colors.blue,
          
        )
        ),
        Container(
          height: 20,
        width: 20,
          margin: EdgeInsets.only(top : top3, left: anchoPantalla * 0.8 ),
      
        decoration: BoxDecoration(
           color: Colors.blue,
          
        )
        ),
        Container(
          height: 20,
        width: 20,
          margin: EdgeInsets.only(top : top4, left: anchoPantalla * 0.6 ),
      
        decoration: BoxDecoration(
           color: Colors.blue,
          
        )
        ),
        Container(
          height: 20,
        width: 20,
          margin: EdgeInsets.only(top : top5, left: anchoPantalla * 0.5 ),
      
        decoration: BoxDecoration(
           color: Colors.blue,
          
        )
        ),
        Container(
          height: 20,
        width: 20,
          margin: EdgeInsets.only(top : top6, left: anchoPantalla * 0.4 ),
      
        decoration: BoxDecoration(
           color: Colors.blue,
          
        )
        ),
        Container(
          height: 20,
        width: 20,
          margin: EdgeInsets.only(top : top7, left: anchoPantalla * 0.3 ),
      
        decoration: BoxDecoration(
           color: Colors.blue,
          
        )
        ),
        Container(
          height: 20,
        width: 20,
          margin: EdgeInsets.only(top : top8, left: anchoPantalla * 0.2 ),
      
        decoration: BoxDecoration(
           color: Colors.blue,
          
        )
        ),
        Container(
          height: 20,
        width: 20,
          margin: EdgeInsets.only(top : top9, left: anchoPantalla * 0.1 ),
      
        decoration: BoxDecoration(
           color: Colors.blue,
          
        )
        ),
        Container(
          margin: EdgeInsets.only(top: alturaPantalla * 0.8),
          child: IconButton(icon: Icon(Icons.abc), onPressed: () {
          caidaObjeto1();
          caidaObjeto2();
          caidaObjeto3();
          caidaObjeto4();
          caidaObjeto5();
          caidaObjeto6();
          caidaObjeto7();
          caidaObjeto8();
          caidaObjeto9();
           
          
        },))

        ],
        
      )));
  }
double caidaObjeto1(){
  if(vueltaEmpezarObjeto1){
   timerCaida = Timer.periodic(Duration(milliseconds: 400), (timer) {
    contadorTimerCaida ++;
    setState(() {
      top1 += 50;
    });

    if(top1 > alturaPantalla * 0.7){
    
   
    top1 = 50;
    }
    
    });
    }
    
  return top1;

}

double caidaObjeto2(){
  if(vueltaEmpezarObjeto2){
   timerCaida = Timer.periodic(Duration(milliseconds: 400), (timer) {
    
    Random random = Random();
    int caida = random.nextInt(100) + 50;
    contadorTimerCaida ++;
    setState(() {
      top2 += caida;
    });

    if(top2 >  alturaPantalla * 0.7){
    
   
    top2 = 50;
    }
    

    });
    }
    
  return top2;
}

double caidaObjeto3(){
  if(vueltaEmpezarObjeto3){
   timerCaida = Timer.periodic(Duration(milliseconds: 400), (timer) {
    
    Random random = Random();
    int caida = random.nextInt(100) + 50;
    contadorTimerCaida ++;
    setState(() {
      top3 += caida;
    });

    if(top3 >  alturaPantalla * 0.7){
    
    
    top3 = 50;
    }
    

    });
    }
    
  return top3;
}
double caidaObjeto4(){
  if(vueltaEmpezarObjeto4){
   timerCaida = Timer.periodic(Duration(milliseconds: 400), (timer) {
    
    Random random = Random();
    int caida = random.nextInt(100) + 50;
    contadorTimerCaida ++;
    setState(() {
      top4 += caida;
    });

    if(top4 >  alturaPantalla * 0.7){
 
    top4 = 50;
    }
    

    });
    }
    
  return top4;
}
double caidaObjeto5(){
  if(vueltaEmpezarObjeto5){
   timerCaida = Timer.periodic(Duration(milliseconds: 400), (timer) {
    
    Random random = Random();
    int caida = random.nextInt(100) + 50;
    contadorTimerCaida ++;
    setState(() {
      top5 += caida;
    });

    if(top5 >  alturaPantalla * 0.7){
    
    
    top5 = 50;
    }
    

    });
    }
    
  return top5;
}
double caidaObjeto6(){
  if(vueltaEmpezarObjeto6){
   timerCaida = Timer.periodic(Duration(milliseconds: 400), (timer) {
    
    Random random = Random();
    int caida = random.nextInt(100) + 50;
    contadorTimerCaida ++;
    setState(() {
      top6 += caida;
    });

    if(top6 >  alturaPantalla * 0.7){
   
   
    top6 = 50;
    }
    

    });
    }
    
  return top6;
}
double caidaObjeto7(){
  if(vueltaEmpezarObjeto7){
   timerCaida = Timer.periodic(Duration(milliseconds: 400), (timer) {
    
    Random random = Random();
    int caida = random.nextInt(100) + 50;
    contadorTimerCaida ++;
    setState(() {
      top7 += caida;
    });

    if(top7 >  alturaPantalla * 0.7){
    
    
    top7 = 50;
    }
    

    });
    }
    
  return top7;
}
double caidaObjeto8(){
  
  if(vueltaEmpezarObjeto8){
    
    
    timerCaida = Timer.periodic(Duration(milliseconds: 400), (timer) {
   
    Random random = Random();
    int caida = random.nextInt(100) + 50;
    contadorTimerCaida ++;
    setState(() {
      top8 += caida;
      print(vueltaEmpezarObjeto8);
    });

    if(top8 > alturaPantalla * 0.7){
      top8 = 50;
    }
    });
    
    
    }
  return top8;
}
double caidaObjeto9(){
  if(vueltaEmpezarObjeto9){
   timerCaida = Timer.periodic(Duration(milliseconds: 400), (timer) {
    
    Random random = Random();
    int caida = random.nextInt(100) + 50;
    contadorTimerCaida ++;
    setState(() {
      top9 += caida;
    });

    if(top9 >  alturaPantalla * 0.7){
    
    
    top9 = 50;
    }
    

    });
    }
    
  return top9;
}

}
