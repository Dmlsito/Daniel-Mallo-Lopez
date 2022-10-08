package org.example;

import org.xml.sax.Attributes;
import org.xml.sax.helpers.DefaultHandler;

import java.util.ArrayList;
import java.util.Locale;

public class ParseadorMascotaSAX extends DefaultHandler {

    private ArrayList<Mascota> listadoMascotas;
    private String valorElemento;
    private Mascota mascota;

 enum tiposNodos {
       MASCOTAS,
        MASCOTA,
        EDAD,
        GENERO,
        TIPO;
    }


    public ParseadorMascotaSAX() {
        super();
    }

    @Override

    public void startDocument() {

        listadoMascotas = new ArrayList<Mascota>();
    }


    @Override
    public void startElement(String localName, String uri, String qName, Attributes attributes) {
        if (localName != null) {
            switch (tiposNodos.valueOf(localName.toUpperCase(Locale.ROOT))) {
                case MASCOTA:
                    mascota = new Mascota();
                    String nombre = attributes.getValue("Nombre");
                    if (nombre != null) {
                        mascota.setNombre(nombre);
                    }


            }
        }
    }

    @Override
    public void endElement(String localName, String qName, String uri) {
        if (localName != null) {
            switch (tiposNodos.valueOf(localName.toUpperCase())) {
                case MASCOTA:
                    listadoMascotas.add(mascota);
                    break;
                case TIPO:
                    mascota.setTipo(valorElemento);
                    break;
                case EDAD:
                    mascota.setEdad(valorElemento);
                    break;
                case GENERO:
                    mascota.setGenero(valorElemento);
                    break;
            }

        }
    }
        @Override
        public void characters( char[] ch, int start, int length) {
            valorElemento = new String(ch, start, length);

        }

        public ArrayList<Mascota> obtenerResultado() {
            return listadoMascotas;
        }


    }
