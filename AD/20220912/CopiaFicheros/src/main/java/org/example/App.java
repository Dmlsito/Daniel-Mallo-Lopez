package org.example;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;

/**
 * Hello world!
 *
 */
public class App 
{
    public static void main( String[] args ) {

        ejercicio2();
    }

    private static void ejercicio2() {

        //Declaramos rutas
        String origen = "C:\\Users\\usuario\\Desktop\\2 DAW\\Acceso a datos\\original.txt";
        String copia = "C:\\\\Users\\\\usuario\\\\Desktop\\\\2 DAW\\\\Acceso a datos\\\\destino.txt";

        try{
            File fOrigen = new File(origen);
            if(fOrigen.exists()){
                System.out.println("Ya existe este fichero");
            }else{
                fOrigen.createNewFile();
            }

            File fDestino = new File(copia);
            if(fDestino.exists()){
                System.out.println("Ya existe este fichero");
            }else{
               fDestino.createNewFile();
            }
            //Aplicamos el metodo para copiar los ficheros
            if(copiarFicheros(fDestino, fOrigen)){
                System.out.println("Se ha copiado los archivos con exito");
            }

        }catch(Exception e){
            e.printStackTrace();
        }
    }
    private static boolean copiarFicheros(File fDestino, File fOrigen){
        try{
            //Declaramos los objetos de lectura y de copia
            FileInputStream in = new FileInputStream(fOrigen);
            FileOutputStream out = new FileOutputStream(fDestino);

            int lector = in.read();
            while(lector != -1){
                out.write(lector);
                // Para que avance de byte a byte, ya que con read() lee un byte
                lector = in.read();
            }
        }catch(Exception e){
            e.printStackTrace();
            return false;
        }

        return true;
    }
}
