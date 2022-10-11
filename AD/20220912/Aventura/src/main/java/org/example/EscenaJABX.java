package org.example;

import javax.xml.bind.annotation.XmlAttribute;
import javax.xml.bind.annotation.XmlElement;

public class EscenaJABX {

    int codigoEscena;
    String texto;
    String textoOpcion;
    int id;
    int resultado;
    String titulo;

    //Constructores
    public EscenaJABX(){}

    public EscenaJABX( String texto, String textoOpcion, int codigoEscena, int id, int resultado){
        this.texto = texto;
        this.textoOpcion = textoOpcion;
        this.codigoEscena = codigoEscena;
        this.id = id;
        this.resultado = resultado;
    }

    //Getters

    public int getCodigoEscena() {
        return codigoEscena;
    }

    public int getId() {
        return id;
    }

    public int getResultado() {
        return resultado;
    }

    public String getTexto() {
        return texto;
    }

    public String getTextoOpcion() {
        return textoOpcion;
    }


    //Setters
    @XmlAttribute(name = "codigo")
    public void setCodigoEscena(int codigoEscena) {
        this.codigoEscena = codigoEscena;
    }

    @XmlAttribute(name = "id")
    public void setId(int id) {
        this.id = id;
    }

    @XmlAttribute(name = "resultado")
    public void setResultado(int resultado) {
        this.resultado = resultado;
    }

    @XmlElement
    public void setTexto(String texto) {
        this.texto = texto;
    }

    @XmlAttribute(name = "texto")
    public void setTextoOpcion(String textoOpcion) {
        this.textoOpcion = textoOpcion;
    }



    //ToString

    @Override
    public String toString() {
       String resultado = this.codigoEscena + "\n " + this.texto ;
       return resultado;
    }
}
