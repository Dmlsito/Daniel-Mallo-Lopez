package ejercicio6;
import java.util.ArrayList;
import java.io.RandomAccessFile;


public class Ejercicio6 {

    public static void main(String[]Args){

        //Crear una nueva clase  Alumno con los siguientes atributos
        // Nombre CHAR(10)
        //Edad INT
        //Nota media
        //Insertar en un ArrayList <alumno> datos de varios alumnos
        //Recorrer en un ArrayList y por cada alumno recuperado grabar sus atributos en un fichero (Random
        // AccesFile) como tipos primitivos
        //Una vez grabados todos los alumnos, acceder directamente al segundo alumno grabado e imprimir
        //por consola sus atributos



        ejercicio6();



    }
    public static void ejercicio6(){

        String NombreAlumno = "";
        int edad = 0;
        double notaMedia = 0;



       try {

           //Creamos los datos de varios alumnos
           Alumno daniel = new Alumno("daniel", 20, 6);
           Alumno Marcos = new Alumno("Marcos", 23, 8.8);
           Alumno Andres = new Alumno("Andres", 25, 6.9);
           Alumno Lara = new Alumno("Lara", 19, 8.9);


           ArrayList<Alumno> alumnos = new ArrayList<Alumno>();
           //Añadimos al arraylist los objetos creados de la clase alumno
           alumnos.add(daniel);
           alumnos.add(Marcos);
           alumnos.add(Andres);
           alumnos.add(Lara);

           //Path fichero destino
           String destino = "C:\\Users\\daniel\\Documents\\GitHub\\Daniel-Mallo-Lopez\\AD\\20220912\\untitled\\destino";
           RandomAccessFile random = new RandomAccessFile(destino, "rw");


           for (int i = 0; i < alumnos.size(); i++) {


           }

       }catch(Exception e){
           e.printStackTrace();
       }

    }
}
