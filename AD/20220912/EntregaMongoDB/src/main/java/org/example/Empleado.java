package org.example;

import java.time.LocalDateTime;
import java.util.Date;

public class Empleado {
    private String nombre;
    private int edad;
    private boolean contratoFijo;
    private String alta;
    private double sueldo;

    Empleado(){}
    Empleado(String nombre, int edad, boolean contratoFijo, String alta, double sueldo){
        this.nombre = nombre;
        this.edad = edad;
        this.contratoFijo = contratoFijo;
        this.alta = alta;
        this.sueldo = sueldo;
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
    String getAlta(){
        return this.alta;
    }
    double getSueldo(){
        return this.sueldo;
    }
    void setNombre(String nombre){
        this.nombre = nombre;
    }
    void setEdad(int edad){
        this.edad = edad;
    }
    void setAlta(String alta){
        this.alta = alta;
    }
    void setSueldo(double sueldo){
        this.sueldo = sueldo;
    }
    void setContratoFijo(boolean contratoFijo){
        this.contratoFijo = contratoFijo;
    }

    @Override
    public String toString() {
        return "Empleado{" +
                "nombre='" + nombre + '\'' +
                ", edad=" + edad +
                ", contratoFijo=" + contratoFijo +
                ", alta='" + alta + '\'' +
                ", sueldo=" + sueldo +
                '}';
    }
}
