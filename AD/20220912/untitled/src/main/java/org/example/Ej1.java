package org.example;

import java.io.File;

/**
 * Hello world!
 *
 */
public class Ej1
{
    public static void main( String[] args )
    {
       File directorio1 = new File("C:\\Users\\daniel\\Desktop\\Desarrollo de apliaciones moviles\\Acceso a datos\\directorio1");

       //Indicamos que si ya existe el directorio que se quiera crear le aparezca un mensaje al usuario
       if(directorio1.exists()){
           System.out.println("Ya existe: " + directorio1.getName());
       }else{
           directorio1.mkdir();
       }

       File directorio2 = new File("C:\\Users\\daniel\\Desktop\\Desarrollo de apliaciones moviles\\Acceso a datos\\directorio2");

       if(directorio2.exists()){
           System.out.println("Ya existe: " + directorio2.getName());
       }else{
           directorio2.mkdir();
       }

       File fichero1 = new File("C:\\Users\\daniel\\Desktop\\Desarrollo de apliaciones moviles\\Acceso a datos\\directorio1\\fichero1.txt");

       if(fichero1.exists()){
           System.out.println("Ya existe: " + fichero1.getName());
       }else{
           try{
               fichero1.createNewFile();
           }catch(Exception e){
               System.out.println("Error");
           }
       }

       File fichero2 = new File("C:\\Users\\daniel\\Desktop\\Desarrollo de apliaciones moviles\\Acceso a datos\\directorio1\\fichero2.txt");

       if(fichero2.exists()){
           System.out.println("Ya existe: " + fichero2.getName());
       }else {
           try{
               fichero2.createNewFile();
           }catch(Exception e){
               System.out.println("Error");
           }
       }

       File fichero3 = new File("C:\\Users\\daniel\\Desktop\\Desarrollo de apliaciones moviles\\Acceso a datos\\directorio2\\fichero3.txt");

       if(fichero3.exists()){
           System.out.println("Ya existe: " + fichero3.getName());
       }else{
           try{
               fichero3.createNewFile();
           }catch(Exception e){
               System.out.println("Error");
           }
       }

       File fichero4 = new File("C:\\Users\\daniel\\Desktop\\Desarrollo de apliaciones moviles\\Acceso a datos\\fichero4.txt");

       if(fichero4.exists()){
           System.out.println("Ya existe: " + fichero4.getName());
       }else{
           try{
               fichero4.createNewFile();
           }catch(Exception e){
               System.out.println("Error");
           }
       }


    }
}
