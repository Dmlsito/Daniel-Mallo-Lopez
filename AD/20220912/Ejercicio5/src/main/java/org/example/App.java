package org.example;
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
    public static void main( String[] args ) {

        ejercicio3();


    }

    private static void ejercicio3(){

        //Defimos los paths de los ficheros implicados
        String pathOrigen = "C:\\Users\\usuario\\Desktop\\2 DAW\\Acceso a datos\\original.txt";
        String pathDestino = "C:\\Users\\usuario\\Desktop\\2 DAW\\Acceso a datos\\destino.txt";

        try{
            FileInputStream in = new FileInputStream(pathOrigen);
            InputStreamReader in2 = new InputStreamReader(in, "UTF-8");
            FileOutputStream out = new FileOutputStream(pathDestino);
            OutputStreamWriter out2 = new OutputStreamWriter(out, "ISO-8859-1");

            if(copiarYguardar(in, in2, out, out2)){
                System.out.println("La operacion ha sido un exito");
            }

        }catch(Exception e){
            e.printStackTrace();
        }

    }
    private static boolean copiarYguardar( FileInputStream in,  InputStreamReader in2, FileOutputStream out, OutputStreamWriter out2 ){

        try{

            char caracter =(char) in2.read();
            while(caracter !=(int) -1){
                out2.write(caracter);
                int lector =(int) caracter;
                out.write(lector);
                caracter =(char) in2.read();
            }

        }catch(Exception e){
            e.printStackTrace();
            return false;
        }
        finally(){

        }

        return true;



    }

}
