package org.example;

import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import java.util.ArrayList;
@XmlRootElement(name= "listAlumnos")
public class Alumno {

    private ArrayList <AlumnosJAXB> listAlumnos;


    public void setListAlumnos(ArrayList<AlumnosJAXB> listaAlumno){
        this.listAlumnos = listaAlumno;
    }

    @XmlElement(name = "alumno")
    public ArrayList<AlumnosJAXB> getListAlumnos(){
        return this.listAlumnos;
    }
}
