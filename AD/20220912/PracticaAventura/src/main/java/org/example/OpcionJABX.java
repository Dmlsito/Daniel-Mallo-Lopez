package org.example;

import javax.xml.bind.annotation.XmlAttribute;

public class OpcionJABX {

    //Atributos
    private int id;
    private String textoOpcion;
    private int resultado;

    //Constructores
    public OpcionJABX(){}
    public OpcionJABX(int id, String textoOpcion, int resultado){
        this.id = id;
        this.textoOpcion = textoOpcion;
        this.resultado = resultado;
    }

    //Getters

    public String getTextoOpcion(){
        return textoOpcion;
    }
    public int getId(){
        return id;
    }
    public int getResultado(){
        return resultado;
    }

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

    //ToString

    @Override
    public String toString() {
        return "Id: " + this.id + ", Texto: " + this.textoOpcion + ", Resultado: " + this.resultado + " || ";
    }
}