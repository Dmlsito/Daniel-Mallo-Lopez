package org.example;

import org.xml.sax.InputSource;
import org.xml.sax.XMLReader;
import org.xml.sax.helpers.XMLReaderFactory;

import java.util.ArrayList;

/**
 * Hello world!
 *
 */
public class Teoria
{
    public static void main( String[] args )
    {

        String edad;
        String genero;
        String tipo;
        String nombre;

        try{
            XMLReader lector = XMLReaderFactory.createXMLReader();
            ParseadorMascotaSAX parser = new ParseadorMascotaSAX();
            lector.setContentHandler(parser);
            InputSource fichero = new InputSource("C:\\Users\\daniel\\Documents\\GitHub\\Daniel-Mallo-Lopez\\AD\20220912\\SAX\src\\main\\java\\org\\example\\Mascotas.xml");
            lector.parse(fichero);
            ArrayList<Mascota> lista = parser.obtenerResultado();
            System.out.println(lista);







        }catch(Exception e){
            e.printStackTrace();
        }






    }
}
