package org.example;

public class Libro {

    private String autor;
    private String titulo;
    private int edicion;

    Libro(){}


    Libro(String autor, String titulo, int edicion){
        autor = this.autor;
        titulo = this.titulo;
        edicion = this.edicion;

    }

    //Setters y getters

    String getAutor(){
        return this.autor;
    }

    String getTitulo(){
        return this.titulo;
    }

    int getEdicion(){
        return this.edicion;
    }

    void setTitulo(String titulo){
        titulo = this.titulo;
    }

    void setAutor(String autor){
        autor = this.autor;
    }

    void setEdicion(int edicion){
        edicion = this.edicion;
    }

    //SuperString

    @Override
    public String toString() {
        return "Libro{" +
                "autor='" + autor + '\'' +
                ", titulo='" + titulo + '\'' +
                ", edicion=" + edicion +
                '}';
    }
}
