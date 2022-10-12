package org.example;

import javax.xml.bind.annotation.XmlAttribute;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import java.util.ArrayList;

@XmlRootElement(name = "aventura")
public class Aventura {
    //Atributos
    private ArrayList<EscenaJABX> listaEscenas ;
    private String titulo;

    public Aventura(String titulo, ArrayList<EscenaJABX> listaEscenas){
        this.titulo = titulo;
        this.listaEscenas = listaEscenas;
    }
    public Aventura() {}

    public ArrayList<EscenaJABX> getListaEscenas(){
        return listaEscenas;
    }
    @XmlElement(name = "escena")
    public void setListaEscenas(ArrayList<EscenaJABX> listaEscenas){
        this.listaEscenas = listaEscenas;
    }

    public String titulo(){
        return titulo;
    }
    @XmlAttribute(name = "titulo")
    public void setTitulo(String titulo){
        this.titulo = titulo;
    }
    //ToString

    @Override
    public String toString() {
        return "Titulo historia: " +  this.titulo + "\n" + this.listaEscenas;
    }
}