package org.example;

import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import java.util.ArrayList;
@XmlRootElement(name= "listAlumnos")
public class Alumno {

    private ArrayList <AlumnosJAXB> listaAlumnos;

    //Constructor
    public void setListaAlumnos(ArrayList<AlumnosJAXB> listaAlumno){
        this.listaAlumnos = listaAlumno;
    }

    @XmlElement
    public ArrayList<AlumnosJAXB> getListaAlumnos(){
        return this.listaAlumnos;
    }
}
