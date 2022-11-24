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

    //Getters y setters

    String getTitulo(){
        return this.titulo;
    }
    String getAutor(){
        return this.autor;
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

    //ToString

    @Override
    public String toString() {
        return "Libro{" +
                "autor='" + autor + '\'' +
                ", titulo='" + titulo + '\'' +
                ", edicion=" + edicion +
                '}';
    }
}
