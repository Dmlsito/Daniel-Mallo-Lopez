package org.example;
import java.util.ArrayList;
import java.util.Locale;

import org.xml.sax.Attributes;
import org.xml.sax.helpers.DefaultHandler;

public class ParseadorMascotaSAX extends DefaultHandler {
    private ArrayList <Mascota> listado;
    private Mascota mascota;
    private String valorElemento;

    enum tiposNodos{
        MASCOTAS,
        MASCOTA,
        TIPO,
        EDAD,
        GENERO;
    }

   public ParseadorMascotaSAX(){
        super();
   }

   @Override
   public void startDocument(){
        listado = new ArrayList<Mascota>();
   }
   @Override
    public void startElement(String uri, String localName, String qName, Attributes attributes){
        if(localName != null){

            switch(tiposNodos.valueOf(localName.toUpperCase(Locale.ROOT))){
                case MASCOTA:
                    mascota = new Mascota();
                    String nombre = attributes.getValue("Nombre");
                    if(mascota != null){
                        mascota.nombre = nombre;
                    }
                    break;
            }}}

    @Override
    public void endElement(String uri, String localName, String qName){
        if(localName != null){
            switch(tiposNodos.valueOf(localName.toUpperCase())){
                case MASCOTA:
                    listado.add(mascota);
                    break;
                case EDAD:
                    mascota.setEdad(valorElemento);
                    break;
                case TIPO:
                    mascota.tipo = valorElemento;
                    break;
                case GENERO:
                    mascota.genero = valorElemento;
                    break;

            }
        }
    }

    @Override
    public void characters(char [] ch, int start, int length){

        valorElemento = new String(ch, start, length);
    }
    public ArrayList<Mascota> obtenerResultado(){
        return listado;
    }



}
