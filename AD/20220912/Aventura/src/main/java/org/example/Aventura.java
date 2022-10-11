package org.example;


import javax.xml.bind.annotation.XmlAttribute;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import java.util.ArrayList;

@XmlRootElement(name = "aventura")
public class Aventura {
    //Atributos
    public ArrayList<EscenaJABX> listaEscenas ;
    public String titulo;


    //Constructores

    public Aventura(String titulo, ArrayList<EscenaJABX> listaEscenas){
        this.titulo = titulo;
        this.listaEscenas = listaEscenas;
    }
    public Aventura(){}

    //Getters y setters
    public ArrayList<EscenaJABX> getListaEscenas(){
        return listaEscenas;
    }

    @XmlElement(name = "escena")
    public void setListaEscenas(ArrayList<EscenaJABX> listaEscenas){
        this.listaEscenas = listaEscenas;
    }

    public String getTitulo() {
        return titulo;
    }

    @XmlAttribute(name = "titulo")
    public void setTitulo(String titulo){
        this.titulo = titulo;
    }



    @Override
    public String toString() {
       return this.titulo + "\n" + this.listaEscenas;
    }
}
