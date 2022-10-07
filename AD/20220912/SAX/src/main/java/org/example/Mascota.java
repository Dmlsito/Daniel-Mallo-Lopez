package org.example;

public class Mascota {
     String nombre;
     String tipo ;
     String genero;
     String  edad;

    //Constructor
    public Mascota(String tipo, String  edad, String genero, String nombre){
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
    public String getEdad(){
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

    public void setNombre(String nombre){
        this.nombre = nombre;
    }

//Metodo toString para que funcione bien el ArrayList.
    @Override
    public String toString() {
        return "Mascota{" +
                "nombre='" + nombre + '\'' +
                ", tipo='" + tipo + '\'' +
                ", genero='" + genero + '\'' +
                ", edad='" + edad + '\'' +
                '}';
    }
}
