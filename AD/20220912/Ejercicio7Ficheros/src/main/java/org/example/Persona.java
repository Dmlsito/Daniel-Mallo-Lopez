package org.example;
import java.io.Serializable;
import java.util.Date;

public class Persona implements Serializable {

    String nombre;
    String apellidos;
    Date fechaDeNacimiento ;

    Persona(String nombrePersona, String apellidosPersona) {

        nombre = nombrePersona;
        apellidos = apellidosPersona;

    }

    //Get y set de nombres
    void setNombre(String nombrePersona){
        this.nombre = nombrePersona;
    }
    String getNombre(){
        return nombre;
    }

    //Get y set de apellidos
    void setApellidos(String apellidosPersona){
        this.apellidos = apellidosPersona;
    }

    String getApellidos(){
        return apellidos;
    }

    //Get y set de fechas de nacimiento
    void setDate(Date fechadeNacimientoPersona){
        this.fechaDeNacimiento = fechadeNacimientoPersona;

    }
    Date getDate(){
        return fechaDeNacimiento;
    }


}
