package org.example;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;

/**
 * Hello world!
 *
 */
public class App 
{
    public static void main( String[] args ){

        //Crear una aplicacion que, obtenido un fichero en codificacion UTF-8, lo lea en dicha codificacion y lo guarde
        //en otro fichero distinto en codificacion ANSI y en US_ASCII

        ejercicio4();

    }

    private static void ejercicio4(){

        //Paths
        String pathOrigen = "C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\AD\\20220912\\EjerciciosFicheros4\\original.txt";
        String pathDestino = "C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\AD\\20220912\\EjerciciosFicheros4\\destino.txt";

        FileInputStream lctB = null;
        InputStreamReader lctC = null;
        FileOutputStream EB = null;
        OutputStreamWriter EC = null;

        try{
            File fOrigen = new File(pathOrigen);
            File fDestino = new File(pathDestino);
            lctB = new FileInputStream(pathOrigen);
            lctC = new InputStreamReader(lctB, "UTF-8");
            EB = new FileOutputStream(pathDestino);
            EC = new OutputStreamWriter(EB, "ISO-8859-1");


            if(fOrigen.exists()){
                System.out.println("Ya existe dicho fichero, su nombre es: " + fOrigen.getName());
            }else{
                fOrigen.createNewFile();
            }
            if(fDestino.exists()){
                System.out.println("Ya existe dicho fichero, su nombre es: " + fDestino.getName());
            }else{
                fDestino.createNewFile();
            }
           if(codificar(lctB, lctC,  EB, EC)){
               System.out.println("Se ha realizado el proceso con exito");
           }
        }catch(Exception e){
            e.printStackTrace();
        }
    }

    private static boolean codificar(FileInputStream lctB, InputStreamReader lctC, FileOutputStream EB, OutputStreamWriter EC  ){


        try{
            int lector = lctC.read();
            while(lector != (int) -1){
                char caracter = (char) lector;
                System.out.println(caracter);
                EC.write(lector);
                //Avanza de caracter
                lector = lctC.read();

            }

        }catch(Exception e){
            e.printStackTrace();
            return false;
        }


        return true;
    }
}
