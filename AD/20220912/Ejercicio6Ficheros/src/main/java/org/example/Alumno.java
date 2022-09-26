package org.example;

public class Alumno {
    //Atributos de la clase alumno
    String Nombre ;
    int edadAlumno;
    double notaMediaAlumno;




    //Constructor
    public Alumno(String NombreAlumno, int edad, double notaMedia) {

        Nombre = NombreAlumno;
        edadAlumno = edad;
        notaMediaAlumno  = notaMedia;
    }

    //Metodo get
    String getName(){

        return Nombre;
    }

    int getEdad(){
        return edadAlumno;
    }

    double getNotaMedia(){
        return notaMediaAlumno;
    }
}
