package org.example;

public class Mascota {
     String nombre;
     String tipo ;
     String genero;
     int  edad;

    //Constructor
    public Mascota(String tipo, int  edad, String genero, String nombre){
        this.tipo = tipo;
        this.edad = edad;
        this.genero = genero;
        this.nombre = nombre;
    }
    public Mascota(){}

    //Getters y setters
    public String getNombre(){
        return this.nombre;
    }
    public String getTipo(){
        return this.tipo;
    }
    public String getGenero(){
        return this.genero;
    }
    public int getEdad(){
        return this.edad;
    }

    public void setTipo(String tipo){
        this.tipo = tipo;
    }
    public void setGenero(String genero){
        this.genero = genero;
    }
    public void setEdad(String edad){
        this.tipo = edad;
    }






}
