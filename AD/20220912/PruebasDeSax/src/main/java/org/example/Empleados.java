package org.example;

public class Empleados {
    String genero ;
    String edad;
    String altura:

    //Construtores

    public Empleados(){}

    public Empleados(String genero, String edad, String altura){
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

}
