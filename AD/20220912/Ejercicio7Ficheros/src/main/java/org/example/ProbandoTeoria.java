package org.example;
import java.io.*;
import java.io.EOFException;


public class ProbandoTeoria {

    public static void main(String[] args){

        //La clase Serializable contiene una serie de metodos con los que podemos escribir objetos en ficheros binarios

        // Object readObject(): // -> leemos un objeto de un ObjectInputStream
        // Object writeObject(Object obj): // -> Escribimos el objeto especificado en un ObjectOutputStream

        //ESCRITURA DE OBJETOS EN FICHEROS BINARIOS
        // Su constructor principal es ObjectOutputStream(FileOutputStream out)
        // Su metodo mas popular es el metodo writeObject(Object object), mediante este metodo podemos escribir un objeto en un fichero

        //LECTURA DE OBJETOS EN FICHEROS BINARIOS
        //El constructor de ObjectInputStream es :
        // ObjectInputStream(FileInputStream in)
        // El metodo mas popular de ObjectInputStream es el metodo readObject(), mediante el cual podemos obtener
        //los datos de un fichero  binario


        probandoCosas();





    }

    public static boolean probandoCosas(){



        try{
            Persona Miguel = new Persona("Miguel", "Mallo Lopez");
            Persona Marcos = new Persona("Marcos", "Lopez, Ibañez");
            Persona Laura = new Persona ("Laura", "Marzoa Roal");

            //Parth del fichero en el que vamos a escribir
            String pathDestino = "C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\AD\\20220912\\Ejercicio7Ficheros\\pathDestino.txt";

            //Y tmb tenemos que crear un metodo FIleInputStream para que nos lea las propiedades de los objetos
            FileOutputStream out = new FileOutputStream(pathDestino);

            //Tenemos que crear un metodo para que me lea las propiedades de los objetos
            ObjectOutputStream escribirPropiedades = new ObjectOutputStream(out);

            escribirPropiedades.writeObject(Miguel);
            escribirPropiedades.writeObject(Marcos);
            escribirPropiedades.writeObject(Laura);

            //Creamos el FileInputStream
            FileInputStream in = new FileInputStream(pathDestino);

            //Creamos el ObjectInputStream
            ObjectInputStream leerPropiedades = new ObjectInputStream(in);


            while(true) {
                //Creamos un objetos de la clase persona que leea las propiedades de nuestros objetos
                //Tenemos que castear a la clase que nosotros queramos acceder
                Persona aux = (Persona) leerPropiedades.readObject();
                //Llamamos y printamos los atributos por pantalla
                System.out.println(aux.getNombre());
                System.out.println(aux.getApellidos());
                System.out.println("");
            }
        //Esta excepcion saltara cuando la clase a la que se hace referencia no aparezca
        }catch(ClassNotFoundException e){
        }
        catch(EOFException e){
        }catch(IOException e){}


        return true;


    }




}
