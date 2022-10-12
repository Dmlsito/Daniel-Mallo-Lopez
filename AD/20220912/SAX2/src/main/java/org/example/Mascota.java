package org.example;

public class Mascota {
     private String nombre;
    private String edad;
    private String genero;
    private String tipo;

    public Mascota(){}

    public Mascota(String edad, String nombre, String genero, String tipo) {
        this.edad = edad;
        this.genero = genero;
        this.nombre = nombre;
        this.tipo = tipo;
    }

    public String getEdad() {
        return this.edad;
    }

    public String getGenero() {
        return this.genero;
    }

    public String getNombre() {
        return this.nombre;
    }

    public String getTipo() {
        return this.tipo;
    }

    public void setEdad(String edad) {
        this.edad = edad;
    }

    public void setGenero(String genero) {
        this.genero = genero;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    @Override
    public String toString() {
        return "Mascota{" +
                "nombre='" + nombre + '\'' +
                ", edad='" + edad + '\'' +
                ", genero='" + genero + '\'' +
                ", tipo='" + tipo + '\'' +
                '}';
    }
}
