package org.example;
import converter.LibroDocConverter;
import libroCrud.LibroDAO;
import model.Libro;

import java.util.ArrayList;
import java.util.List;
import con.mongodb.MongoClient;

/**
 * Hello world!
 *
 */
public class Main
{
    public static void main( String[] args )
    {
        //Para mandar un objeto tipo Java a MongoDB tenemos que convertirlo a un objeto MongoDB

        //En el metodo main creamos la conexion a la base de datos
        LibroDAO libroDAO = new LibroDAO();
        MongoClient mongoClient = null;


        mongoClient = new MongoClient(host: "localhost", port: 2701);
        MongoDatabase conexion = mongoClient.getDatabase("biblioteca");
        MongoCollection<Document> collection = conexion.getCollection("Libros");

        //Listar Libros
        List<Libro> libros = libroDAO.listaLibros(collection);
        System.out.println("LISTA DE LIBORS");
        for(Libro libro: libros){
            System.out.println(libro.toString());
        }

        //Objeto de tipo MongoDatabase
       MongoDatabase mongoClient.getDatabase("Biblioteca");

        try{

        }catch(Exception e){
            System.out.println("Error de conexion" + e.getCause().getMessage());
        }finally{
            if(mongoClient != null){
                mongoClient.close();
            }
        }
    }
}
