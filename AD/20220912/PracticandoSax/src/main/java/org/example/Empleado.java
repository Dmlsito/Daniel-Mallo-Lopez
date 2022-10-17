package org.example;

public class Empleado {
    String genero ;
    String edad;
    String altura;
    String nombre;

    //Construtores

    public Empleado(){}

    public Empleado(String genero, String edad, String altura, String nombre){
        this.nombre = nombre;
        this.genero = genero;
        this.edad = edad;
        this.altura = altura;
    }

    //Getters y setter

    public String getGenero(){
        return this.genero;
    }

    public void setGenero(String genero){
        this.genero = genero;
    }
    public String getAltura(){
        return this.altura;
    }

    public void setAltura(String altura){
        this.altura = altura;
    }
    public String getEdad(){
        return this.edad;
    }

    public void setEdad(String edad){
        this.edad = edad;
    }
    public String getNombre(){
        return this.nombre;
    }

    public void setNombre(String nombre){
        this.nombre = nombre;
    }

    @Override
    public String toString() {
        return "Empleado{" +
                "genero='" + genero + '\'' +
                ", edad='" + edad + '\'' +
                ", altura='" + altura + '\'' +
                ", nombre='" + nombre + '\'' +
                '}';
    }
}
