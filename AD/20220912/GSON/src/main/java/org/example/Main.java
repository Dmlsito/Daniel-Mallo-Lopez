package org.example;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;

import java.io.FileNotFoundException;
import java.io.FileReader;
import java.util.ArrayList;
import java.util.Arrays;

/**
 * Hello world!
 *
 */
public class Main
{
    public static void main( String[] args )
    {
        //Path de la ruta
        String ruta = "C:\\Users\\daniel\\Documents\\GitHub\\Daniel-Mallo-Lopez\\AD\\20220912\\GSON\\src\\main\\java\\org\\example\\Alumno\\Alumno.JSON";
        ArrayList<AlumnoGSON> listaAlumnos = new ArrayList<AlumnoGSON>();

        try{
            System.out.println(leerJSON(ruta));
            generarJSON(listaAlumnos);
        }catch(Exception e){
            e.printStackTrace();
        }


    }

    public static ArrayList<AlumnoGSON> leerJSON (String ruta) throws FileNotFoundException {
        Gson gson = new GsonBuilder().excludeFieldsWithoutExposeAnnotation().create();
        FileReader fr = new FileReader(ruta);
        AlumnoGSON[]  alumnos = gson.fromJson(fr, AlumnoGSON[].class);
        return new ArrayList<AlumnoGSON> (Arrays.asList(alumnos));

    }

    public static String generarJSON(ArrayList<AlumnoGSON> listaAlumno){
        Gson gson = new GsonBuilder().excludeFieldsWithoutExposeAnnotation().setPrettyPrinting().create();
        String json = gson.toJson(listaAlumno);
        return json;
        //Si queremos que escriba en un fichero lo que tenemos que hacer es usar un FileWritter para que lo escribas en un fichero
    }
}
