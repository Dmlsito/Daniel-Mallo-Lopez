package org.example;

import javax.xml.bind.annotation.XmlAttribute;
import javax.xml.bind.annotation.XmlElement;

public class AlumnosJAXB {

    private int id ;
    private String  nombre;
    private int edad;

    public int getID(){
        return id;
    }

    @XmlAttribute
    public void setId(int id){
        this.id = id;
    }
    public String getNombre(){
        return this.nombre;
    }
    @XmlElement
    public void setNombre(String nombre){
        this.nombre = nombre;
    }

    @XmlAttribute
    public void setNombreAttr(String nombre){
        this.nombre = nombre;
    }

    public int getEdad(){
        return this.edad;
    }
    @XmlElement
    public void setEdad(int edad){
        this.edad = edad;
    }








}
