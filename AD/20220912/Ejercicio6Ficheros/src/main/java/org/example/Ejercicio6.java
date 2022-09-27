package org.example;
import java.sql.SQLOutput;
import java.util.ArrayList;
import java.io.RandomAccessFile;

/**
 * Hello world!
 *
 */
public class Ejercicio6
{
    public static void main( String[] args )
    {

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
            String destino = "C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\AD\\20220912\\Ejercicio6Ficheros\\destino.txt";
            RandomAccessFile random = new RandomAccessFile(destino, "rw");


            for (Alumno alumno : alumnos) {
                //Como queremos que nunca varie el nuºero de bytes que ocupa cada objeto alumno, indicamos que si es menos de diez se corta y se es mas ya estariamos hablando del siguiente
                StringBuffer sb = new StringBuffer(alumno.getName());
                sb.setLength(20);
                //Esto ocupara 40 bytes
                random.writeChars(sb.toString());
                //Esto ocupara 4 bytes
                random.writeInt(alumno.getEdad());
                //Esto ocupara 8 bytes
                random.writeDouble(alumno.getNotaMedia());
            }

            //Nota : char ocupa 2 bytes, int ocupa 4 bytes y double ocupa 8 bytes

            random.seek(52*(2-1));
            String nombre ="";
            for(int i = 0; i<20; i++){
                //De esta forma como ya estamos posicionados en el segundo elemento, para leer el string iteramos la longitud que le adjudicamos en el buffer
               nombre += random.readChar();
            }
             edad = random.readInt();
            notaMedia = random.readDouble();

            //Imprimimos los datos por pantalla

            System.out.println(nombre);
            System.out.println(edad);
            System.out.println(notaMedia);






        }catch(Exception e){
            e.printStackTrace();
        }

    }
}
