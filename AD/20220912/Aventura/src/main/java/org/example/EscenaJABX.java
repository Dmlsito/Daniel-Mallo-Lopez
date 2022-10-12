package org.example;

import javax.xml.bind.annotation.XmlAttribute;
import javax.xml.bind.annotation.XmlElement;
import java.util.ArrayList;

public class EscenaJABX {

    private int codigoEscena;
    private String texto;
    private ArrayList<OpcionJABX> listadoOpciones;




    //Constructores
    public EscenaJABX(){}

    public EscenaJABX( String texto, int codigoEscena, ArrayList<OpcionJABX> listadoOpciones){
        this.texto = texto;
        this.codigoEscena = codigoEscena;
        this.listadoOpciones = listadoOpciones;
    }

    //Getters
    public ArrayList<OpcionJABX> getListadoOpciones(){
        return listadoOpciones;
    }

    public int getCodigoEscena() {
        return codigoEscena;
    }

    public String getTexto() {
        return texto;
    }

    //Setters
    @XmlAttribute(name = "codigo")
    public void setCodigoEscena(int codigoEscena) {
        this.codigoEscena = codigoEscena;
    }

    @XmlElement
    public void setTexto(String texto) {
        this.texto = texto;
    }


    @XmlElement(name = "opcion")
    public void setListadoOpciones(ArrayList<OpcionJABX> listadoOpciones) {
        this.listadoOpciones = listadoOpciones;
    }


    //ToString

    @Override
    public String toString() {
       String resultado =  "\n Codigo escena: " +  this.codigoEscena + "\n " + this.texto + "\n " + this.listadoOpciones ;
       return resultado;
    }
}
