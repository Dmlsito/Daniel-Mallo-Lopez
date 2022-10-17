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
        //Path de la ruta donde se va a guardar el fichero con el JSON
        String ruta = "C:\\Users\\daniel\\Documents\\GitHub\\Daniel-Mallo-Lopez\\AD\\20220912\\GSON2\\src\\main\\java\\org\\example\\Mascotas.JSON";
        ArrayList<MascotasGSON> listaMascotas = new ArrayList<MascotasGSON>();
        try{
            System.out.println(leerJSON(ruta));
            escribirJSON(listaMascotas);
            System.out.println("OPERACION REALIZADA CON EXITO");
        }catch(Exception e){
            e.printStackTrace();
            System.out.println("NO SE HA PRODUCIDO LA OPERACION");
        }

    }

    public static ArrayList<MascotasGSON> leerJSON(String ruta) throws FileNotFoundException {
        Gson gson = new GsonBuilder().excludeFieldsWithoutExposeAnnotation().create();
        FileReader fr = new FileReader(ruta);
        MascotasGSON [] mascotas = gson.fromJson(fr, MascotasGSON[].class);
        return new ArrayList<MascotasGSON>(Arrays.asList(mascotas));
    }
        public static String escribirJSON(ArrayList<MascotasGSON> listaMascotas){
        Gson gson = new GsonBuilder().excludeFieldsWithoutExposeAnnotation().setPrettyPrinting().create();
        String json = gson.toJson(listaMascotas);
        return json;

    }


}
