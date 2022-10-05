package org.example;

import org.xml.sax.helpers.DefaultHandler;

import java.util.ArrayList;
import java.util.jar.Attributes;

public class ParseadorMascotasSAX extends DefaultHandler {
    private ArrayList<Mascota> lista ;
    private Mascota mascota;
    private String valorElemento;

    enum tiposNodos{
        MASCOTAS,
        MASCOTA,
        NOMBRE,
        TIPO,
        EDAD,
        GENERO
    }
    public ParseadorMascotasSAX(){
        super();
    }
    @Override
    public void  startDocument(){
        lista = new ArrayList <Mascota>();
    }
   public void startElement(String uri, String localName, Attributes attributes){
        if(localName != null){
            switch(tiposNodos.valueOf(localName.toUpperCase())){
                case MASCOTA:
                    mascota = new Mascota();
                    String nombre = attributes.getValue("Nombre");
                    if(nombre != null){
                        mascota.setNombre(nombre);
                    }
                    break;
            }
        }
   }
   @Override
   public void endElement(String uri, String LocalName, String qName){
        if(LocalName != null){
            switch(tiposNodos.valueOf(LocalName.toUpperCase())){
                case MASCOTA:
                    lista.add(mascota);
                    break;
                case TIPO:
                    mascota.setTipo(valorElemento);
                    break;
                case EDAD:
                   mascota.Edad = Integer.parseInt(valorElemento);
                    break;
                case GENERO:
                    mascota.setGenero(valorElemento);
                    break;

            }
        }

   }

   public void characters(char[] ch, int start, int length){
        valorElemento = new String(ch, start, length);
   }

   public ArrayList <Mascota> obtenerResultado(){
        return lista;
   }






}
