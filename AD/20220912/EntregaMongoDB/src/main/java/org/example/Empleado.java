package org.example;

import java.time.LocalDateTime;
import java.util.Date;

public class Empleado {
    private String nombre;
    private int edad;
    private boolean contratoFijo;
    private Date alta;
    private double sueldo;

    Empleado(){}
    Empleado(String nombre, int edad, boolean contratoFijo, Date alta, double sueldo){
        nombre = this.nombre;
        edad = this.edad;
        contratoFijo = this.contratoFijo;
        alta = this.alta;
        sueldo = this.sueldo;
    }

    String getNombre(){
        return this.nombre;
    }
    int getEdad(){
        return this.edad;
    }

    boolean getContratoFijo(){
        return this.contratoFijo;
    }
    Date getAlta(){
        return this.alta;
    }
    double getSueldo(){
        return this.sueldo;
    }
    void setNombre(String nombre){
        nombre = this.nombre;
    }
    void setEdad(int edad){
        edad = this.edad;
    }
    void setAlta(Date alta){
        alta = this.alta;
    }
    void setSueldo(double sueldo){
        sueldo = this.sueldo;
    }
    void setContratoFijo(boolean contratoFijo){
        contratoFijo = this.contratoFijo;
    }

}
