package org.example;
import java.util.Date;
import java.util.ArrayList;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.ObjectOutputStream;
import java.io.ObjectInputStream;


/**

 *
 */
public class Ejercicio7
{
    public static void main( String[] args )
    {
        //Realizar un programa que contenga una clase Persona para la presentacion de nombre, apellidos y
        //fecha de nacimiento. Esta clase debera tener:
        //Implementar la interfaz Serializable
        //Tener definido un constructor que reciba datos para todas las propiedades de la clase
        //Tener definidos getters y setters
        //Crear una sobreescritura del metodo toString().
        //Crear una clase PersonaMapping para el guardado de  un listado de objetos persona y obtencion de objetos
        //persona de un fichero
        //Desde un fichero con metodo main para crear una serie de obejtos persona y persistirlos en el fichero.
        //Luego leer el fichero, obtener los objetos e imprimirlos por pantalla

        String nombrePersona = "";
        String apellidosPersona = "";
        Date fechaDeNacimientoPersona ;
        ArrayList<Persona> personas = new ArrayList<Persona>();





    }

    public static boolean ejercicio7(){

        //Creamos varios objetos de la clase persona
        Persona Miguel = new Persona("Miguel", "Mallo");
        Persona Marcos = new Persona("Marcos", "Lopez, Ibañez");
        Persona Laura = new Persona ("Laura", "Marzoa Roal");

        try {
            //Creamos el FiletOuputStream
            FileOutputStream out = new FileOutputStream("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\AD\\20220912\\Ejercicio7Ficheros\\pathDestino.txt");

            //Creamos el ObjectOutputStream
            ObjectOutputStream escribirFichero = new  ObjectOutputStream(out);
            escribirFichero.writeObject(Miguel);
            escribirFichero.writeObject(Marcos);
            escribirFichero.writeObject(Laura);

            //Creamos el FileObjectStream
            FileInputStream in = new FileInputStream ("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\AD\\20220912\\Ejercicio7Ficheros\\pathDestino.txt");

            //Creamos el ObjectInputStream
            ObjectInputStream escribirFicheros = new ObjectInputStream (in);

            while(true){
                //Creamos un objeto aux casteado a persona para que recoja lo que lee el ObjectInputStream
                Persona aux = (Persona) escribirFicheros.readObject();
                System.out.println(aux.getNombre());
                System.out.println(aux.getApellidos());
                System.out.println(aux.getDate());
                System.out.println(" ");
            }

        }catch(ClassNotFoundException e){
        }catch(Exception e){
        }
        return true;
    }


    @Override
    public String toString() {

        return super.toString();
    }
}
