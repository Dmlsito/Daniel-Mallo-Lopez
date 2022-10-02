package org.example;

public class Mascota {
    //Propiedades

    String Nombre ;
    String tipo;
    String genero;
    Integer edad ;


    //Constructor
    public Mascota(){}
    public Mascota(String Nombre, String tipo, int edad, String genero){
        this.Nombre = Nombre;
        this.tipo = tipo;
        this.edad = edad;
        this.genero = genero;
    }

    //Get y set
    String getNombre(){
        return Nombre;
    }

    void setNombre(String Nombre){
        this.Nombre = Nombre;
    }

    String getTipo(){
        return tipo;
    }

    void setTipo(String tipo){
        this.tipo = tipo;
    }

    int getEdad(){
        return this.edad;
    }

    void setEdad(int edad) {
        this.edad = edad;
    }

    String getGenero(){
        return this.genero;
    }
    void setGenero(String genero){
        this.genero = genero;
    }

@Override
    public String toString(){
        String resultado = this.Nombre + " " + this.edad + " " + this.genero + " " + this.tipo;
        return resultado;
    }
}
