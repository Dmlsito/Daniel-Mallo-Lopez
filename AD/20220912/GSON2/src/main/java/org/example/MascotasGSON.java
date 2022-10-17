package org.example;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

import java.io.Serializable;

public class MascotasGSON {
@Expose(serialize = false, deserialize = true)
@SerializedName("nombre")
private String nombre;
@SerializedName("genero")
@Expose
private String genero;
@SerializedName("edad")
@Expose
private int edad;
@SerializedName("tipo")
@Expose
private String tipo;

    //Constructores
    public MascotasGSON(){}

    public MascotasGSON(String nombre, String genero, int edad, String tipo){
        this.nombre = nombre;
        this.genero = genero;
        this.edad = edad;
        this.tipo = tipo;
    }

    //Getters y setters


    public String getNombre() {
        return nombre;
    }

    public String getGenero() {
        return genero;
    }

    public int getEdad() {
        return edad;
    }

    public String getTipo() {
        return tipo;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public void setGenero(String genero) {
        this.genero = genero;
    }

    public void setEdad(int edad) {
        this.edad = edad;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    //ToString


    @Override
    public String toString() {
        return "MascotasGSON{" +
                "nombre='" + nombre + '\'' +
                ", genero='" + genero + '\'' +
                ", edad=" + edad +
                ", tipo='" + tipo + '\'' +
                '}';
    }
}
