package org.example;

import javax.xml.bind.annotation.XmlAttribute;

public class OpcionJABX {
    //Atributos

    public int id;
    public int resultado;
    public String textoOpcion;

    public OpcionJABX(int id, int resultado, String textoOpcion){
        this.id = id;
        this.resultado = resultado;
        this.textoOpcion = textoOpcion;
    }
    //Getters
    public int getId() {
        return id;
    }

    public int getResultado() {
        return resultado;
    }

    public String getTextoOpcion() {
        return textoOpcion;
    }

    //Setters
    @XmlAttribute(name = "id")
    public void setId(int id) {
        this.id = id;
    }

    @XmlAttribute(name = "resultado")
    public void setResultado(int resultado) {
        this.resultado = resultado;
    }

    @XmlAttribute(name = "texto")
    public void setTextoOpcion(String textoOpcion) {
        this.textoOpcion = textoOpcion;
    }

    //Getters
    @Override
    public String toString() {
        String resultado = this.id + "," + this.textoOpcion + "," + this.resultado;
        return resultado;
    }
}
