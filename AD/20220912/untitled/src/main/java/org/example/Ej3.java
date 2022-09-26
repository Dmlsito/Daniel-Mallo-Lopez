package org.example;
import java.io.File;

public class Ej3 {

    public static void main(String []args){

        //Crear un programa que realice una copia de entre dos ficheros indicados.
        //Debera leer un fichero de texto (que crearemos nosotros en un directorio con datos) y realizara una nueva copia a un nuevo fichero
        //El programa debera comprobar que el fichero de origen existe y que el fichero de destino no existe (de no cumplirse esto debera
        // cancelar la ejecuciony mostrar un mensaje de error)




    }

    private static void ejercicio3(){

        //Indicamos el path de cada fichero
        String origen = "C:\\Users\\daniel\\Desktop\\Desarrollo de apliaciones moviles\\Acceso a datos\\origen.txt";
        String copia = "C:\\Users\\daniel\\Desktop\\Desarrollo de apliaciones moviles\\Acceso a datos\\copia.txt";

        try{
            File fOrigen = new File(origen);

            if(fOrigen.exists()){
                System.out.println("Este fichero ya existe, su nombre es: " + fOrigen.getName());
            }



            File fDestino = new File(copia);

            if(fDestino.exists()){
                System.out.println("Este fichero ya existen, su nombre es: " + fDestino.getName());
            }




        }catch(Exception e){
            e.printStackTrace();
        }






    }

    private static void copiarArchivos(){
        ImputStream in= null;
        OutPutSatrem out = null;

    }
}
