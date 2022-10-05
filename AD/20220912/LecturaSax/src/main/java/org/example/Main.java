package org.example;

import org.xml.sax.InputSource;
import org.xml.sax.XMLReader;
import org.xml.sax.helpers.XMLReaderFactory;

import java.util.ArrayList;

/**
 * Hello world!
 *
 */
public class Main
{
    public static void main( String[] args )
    {
        try{
            XMLReader lector = XMLReaderFactory.createXMLReader();
            ParseadorMascotasSAX parseador  = new ParseadorMascotasSAX();
            lector.setContentHandler(parseador);
            InputSource fichero = new InputSource("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\AD\\20220912\\LecturaSax\\src\\main\\java\\org\\example\\Mascotas.xml");
            lector.parse(fichero);
            ArrayList<Mascota> listado = parseador.obtenerResultado();
            System.out.println(listado);



        }catch(Exception e){
            e.printStackTrace();
        }



    }
}
