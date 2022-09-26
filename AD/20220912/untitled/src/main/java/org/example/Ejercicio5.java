package org.example;

import java.io.*;

public class Ejercicio5 {

    public static void main (String[] args){

        //Crear una aplicacion que,dado un fichero en codificacion UTF-8, lo lea en dicha codificacion y lo guarde en otro fichero distinto
        //en codificacion ISO-


    }

    private static void ejercicio5(){

        FileInputStream in = null;
        FileOutputStream out = null;
        InputStreamReader in2 = null;
        OutputStreamWriter out2 = null;

        try{

            in = new FileInputStream("C:\\Users\\daniel\\Documents\\GitHub\\Daniel-Mallo-Lopez\\AD\\20220912\\ñ.txt");
            out = new FileOutputStream("C:\\Users\\daniel\\Documents\\GitHub\\Daniel-Mallo-Lopez\\AD\\20220912\\destino.txt");
            in2 = new InputStreamReader(in, "UTF-8");
            out2 = new OutputStreamWriter(out,"ISO-8859-1");




        }catch(Exception e){
            e.printStackTrace();
        }

    }

    private static boolean guardarInformacion(FileInputStream in, InputStreamReader in2,OutputStreamWriter out2){

        try {
            int lector = in.read();
            while(lector != -1){
                char caracter = (char) lector;
                System.out.println(caracter);
                out2.write(caracter);
                lector = in.read();

            }

        } catch (IOException e) {
            throw new RuntimeException(e);
        }


        return true;
    }
}
