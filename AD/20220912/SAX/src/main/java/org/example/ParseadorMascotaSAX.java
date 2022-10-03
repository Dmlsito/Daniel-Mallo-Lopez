package org.example;
import java.util.ArrayList;

import javafx.scene.control.IndexRange;
import org.xml.sax.Attributes;
import org.xml.sax.helpers.DefaultHandler;

public class ParseadorMascotaSAX extends DefaultHandler {
    private ArrayList <Mascota> listado;
    private Mascota mascota;
    private String valorElemento;

    enum tiposNodos{
        NOMBRE,
        TIPO,
        mascotas,
        MASCOTA,
        EDAD,
        GENERO;
    }

   public void ParseadorMascotas(){
       listado = new ArrayList<Mascota>();
   }

    @Override
    public void startElement(String uri, String localName, String qName, Attributes attributes){
        if(localName != null){

            switch(tiposNodos.valueOf(localName.toUpperCase())){
                case MASCOTA:
                    mascota = new Mascota();
                    String nombre = attributes.getValue("nombre");
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
                    mascota.edad = Integer.parseInt(valorElemento);
                    break;
                case TIPO:
                    mascota.tipo = valorElemento;
                    break;
                case GENERO:
                    mascota.genero = valorElemento;
                    break;
                case NOMBRE:
                    mascota.nombre = valorElemento;
                    break;
            }
        }
    }



}
