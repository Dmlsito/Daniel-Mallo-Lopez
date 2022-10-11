package org.example;

import javax.xml.bind.JAXBContext;
import javax.xml.bind.Unmarshaller;
import java.io.File;
import java.util.ArrayList;


public class Main
{
    public static  void main(String[] args ) {

        try{
            mostrarEscenas();
        }catch(Exception e){
            e.printStackTrace();
        }
    }
    public static void mostrarEscenas(){
        //Ruta del path
        String ruta = "C:\\Users\\daniel\\Documents\\GitHub\\Daniel-Mallo-Lopez\\AD\\20220912\\Aventura\\src\\main\\java\\org\\example\\Aventura.xml";
        // Creamos el arrayList en donde se guardaran las escenas

        try {
            File file = new File(ruta);
            if(file.exists()){
                JAXBContext context = JAXBContext.newInstance(Aventura.class);
                Unmarshaller unmarshaller = context.createUnmarshaller();
                Aventura aventura = (Aventura) unmarshaller.unmarshal(file);

              System.out.println(aventura);

                /*//Imprimimos la primera escena
                for(int i  = 0; i< 1; i++){
                    System.out.println(lista.get(0));
                }
                +7
                 */
            }else{
                System.out.println("Fichero no encontrado");
            }
        }catch(Exception e){
            e.printStackTrace();
            System.out.println("SE HA PRODUCIDO UN ERROR EN LA OPERACION");

        }
    }
}
