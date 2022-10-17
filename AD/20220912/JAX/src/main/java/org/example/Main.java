package org.example;


import javax.xml.bind.JAXBContext;
import javax.xml.bind.Unmarshaller;
import java.io.File;
import java.util.ArrayList;

/**
 * Hello world!
 *
 */
public class Main {
    public static void main(String[] args) {

        try {
            String ruta = "C:\\Users\\daniel\\Documents\\GitHub\\Daniel-Mallo-Lopez\\AD\\20220912\\JAX\\src\\main\\java\\org\\example\\Alumnos.xml";
            realizarLecturaXML(ruta);
        } catch (Exception e) {
            e.printStackTrace();
        }

    }

    private static ArrayList<AlumnosJAXB> realizarLecturaXML(String ruta) {
        ArrayList<AlumnosJAXB> alumnos = new ArrayList<AlumnosJAXB>();
        try {
            File file = new File(ruta);


            if (file.exists()) {
                JAXBContext jaxbContext = JAXBContext.newInstance(Alumno.class);
                Unmarshaller jaxUnmarshaller = jaxbContext.createUnmarshaller();
                Alumno listAlumno = (Alumno) jaxUnmarshaller.unmarshal(file);
                alumnos = (listAlumno != null) ? listAlumno.getListAlumnos() : new ArrayList<AlumnosJAXB>();
                System.out.println(alumnos);
            } else {
                System.out.println("No se ha podido encontrar el fichero indicado");
            }


        } catch (Exception e) {
            e.printStackTrace();
        }
        return alumnos;


    }
}