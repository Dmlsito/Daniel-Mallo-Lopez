package model;

public class Libro {

    private String titulo;
    private String autor;
    private int edicion;


    public Libro(String autor,String titulo, int edicion) {
        this.autor = autor;
        this.titulo = titulo;
        this.edicion = edicion;
    }

    public Libro() {}

    public String getTitulo() {
        return titulo;
    }

    public String getAutor() {
        return autor;
    }

    public int getEdicion() {
        return edicion;
    }

    public void setTitulo(String titulo) {
        this.titulo = titulo;
    }

    public void setAutor(String autor) {
        this.autor = autor;
    }

    public void setEdicion(int edicion) {
        this.edicion = edicion;
    }

    @Override
    public String toString() {
        return "Libro{" +
                "titulo='" + titulo + '\'' +
                ", autor='" + autor + '\'' +
                ", edicion=" + edicion +
                '}';
    }
}
