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
    public static void main( String[] args ) {
        ejercicioSax();
    }


        private static void ejercicioSax() {
        try {
            XMLReader lector = XMLReaderFactory.createXMLReader();
            ParseadorEmpleadoSAX parseador = new ParseadorEmpleadoSAX();
            lector.setContentHandler(parseador);
            InputSource xml = new InputSource("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\AD\\20220912\\PracticandoSax\\.idea\\Xml.xml");
            lector.parse(xml);
            ArrayList <Empleado> lista = parseador.ObenerResultado();
            System.out.println(lista);



        } catch (Exception e) {
            e.printStackTrace();
        }
    }
    }

