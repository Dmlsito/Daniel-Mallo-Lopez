package org.example;

public class Mascota {
    //Atributos
    private String Nombre ;
    private String Tipo;
    private String Genero;
    public int Edad;

    //Constructores
    public Mascota(){}
    public Mascota(String Nombre, String Tipo, String Genero, int Edad){
        this.Nombre = Nombre;
        this.Tipo = Tipo;
        this.Genero = Genero;
        this.Edad = Edad;
    }
    //Getters y setters
    public void setNombre(String Nombre){
        this.Nombre = Nombre;
    }
    public String getNombre(){
        return this.Nombre;
    }
    public void setTipo(String Tipo){
        this.Tipo = Tipo;
    }
    public String getTipo(){
        return this.Tipo;
    }
    public void setGenero(String Genero){
        this.Genero = Genero;
    }
    public String getGenero(){
        return this.Genero;
    }
    public void setEdad(int Edad){
        this.Edad = Edad;
    }
    public int getEdad(){
        return this.Edad;
    }
}
