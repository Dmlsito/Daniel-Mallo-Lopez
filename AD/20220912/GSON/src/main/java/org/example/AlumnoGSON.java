package org.example;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class AlumnoGSON {
@Expose(serialize = false, deserialize = true)
    private int id;
@SerializedName("nombre")
@Expose
private String nombre;
@Expose
private int edad;

    public AlumnoGSON() {}
    public AlumnoGSON(int id, String nombre, int edad){
        this.id = id;
        this.nombre = nombre;
        this.edad = edad;
    }

    public int getId() {
        return id;
    }

    public String getNombre() {
        return nombre;
    }

    public int getEdad() {
        return edad;
    }

    public void setId(int id) {
        this.id = id;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public void setEdad(int edad) {
        this.edad = edad;
    }

    @Override
    public String toString() {
        return "AlumnoGSON{" +
                "id=" + id +
                ", nombre='" + nombre + '\'' +
                ", edad=" + edad +
                '}';
    }
}
