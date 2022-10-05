package org.example;

import org.xml.sax.Attributes;
import org.xml.sax.helpers.DefaultHandler;

import java.util.ArrayList;
import java.util.Locale;

public class ParseadorEmpleadoSAX extends DefaultHandler {

    private ArrayList<Empleado> listado;
    private String valorElemento;
    private Empleado empleado;

    enum Nodos{
        EMPLEADOS,
        EMPLEADO,
        GENERO,
        EDAD,
        ALTURA
    }

    //Constructor
    public ParseadorEmpleadoSAX(){
        super();
    }
    @Override
    public void startDocument(){
        listado = new ArrayList<Empleado>();
    }

    @Override
    public void startElement(String localName, String qname, String uri, Attributes attributes){
        if(localName != null){

            switch(Nodos.valueOf(localName.toUpperCase(Locale.ROOT))){
                case EMPLEADO:
                    empleado = new Empleado();
                    //En este String guardaremos el atributo nombre en el caso de que el elemento lo tenga
                    String nombre = attributes.getValue("Nombre");
                    if(nombre != null){
                        //Si nombre no es null lo recojemos en el objeto
                        empleado.nombre = nombre;
                    }
                    break;

            }}}
    @Override
    public void endElement(String localName, String qname, String uri){
        if(localName != null){
            switch(Nodos.valueOf(localName.toUpperCase())){
                case EMPLEADO:
                    listado.add(empleado);
                    break;
                case EDAD:
                    empleado.edad = valorElemento;
                    break;
                case GENERO:
                    empleado.genero = valorElemento;
                    break;
                case ALTURA:
                    empleado.altura = valorElemento;

            }}}
    @Override
    public void characters(char [] ch, int start, int length ){
        valorElemento = new String(ch, start, length);
    }
    public ArrayList <Empleado> ObenerResultado(){
        return listado;
    }

}
