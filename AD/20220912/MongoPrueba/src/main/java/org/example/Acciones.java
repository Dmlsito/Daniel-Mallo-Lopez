package org.example;
import com.mongodb.client.MongoCollection;
import com.mongodb.client.model.Filters;
import org.bson.Document;


import java.util.ArrayList;
import java.util.List;
import static com.mongodb.client.model.Filters.eq;


public class Acciones extends Parseos {
    //En esta clase se encontraran todas las acciones que se pueden hacer, listar, consultar, insertar, eliminar, actualizar...



    //Funcion de consulta
     static Libro consultaLibro(String titulo, MongoCollection <Document> colMongo){
        Document documento = colMongo.find(eq("titulo", titulo)).first();

        return documentoAlibro(documento);
    }

    //Funcion listar
    static List <Libro> listarLibros(MongoCollection<Document> colMongo){
         //Creamos una lista de objetos libros
        List <Libro> listaLibros = new ArrayList<Libro>();
        //Creo una lista en la que recogemos todo lo que hay en el documento
        List <Document> documentos = colMongo.find().into(new ArrayList <Document>());
        //Creo un objeto de tipo libro en donde recogere los campo de cada documento los documentos
        Libro libro;
        for( Document documento: documentos ){
            libro = documentoAlibro(documento);
            listaLibros.add(libro);
        }
        return listaLibros;
    }

    //Funcion insertar
    static void insertarLibro(MongoCollection <Document> colMongo, Libro libro){
         //Tenemos que pasar por parametro el libro que queramos insertar en la BBDD
        //Convertimos dicho libro en un documento con la funcion que creamos en la clase parseador
         Document documento = libroAdoc(libro);

         try{
             //Primero debemos controlar si existe o no el titulo que se desea insertar
             if(consultaLibro(libro.getTitulo(), colMongo) == null){
                 colMongo.insertOne(documento);
             }else{
                 System.out.println("ERROR TITULO REPETIDO");
             }

         }catch(Exception e){
             e.printStackTrace();

        }
    }

    //Funcion actualizar
    static void actualizarLibro(MongoCollection <Document> colMongo, Libro libro){
         //Parseamos el libro a un documento para poder insertarlo en la BBDD
         Document documento = libroAdoc(libro);

         try{
             colMongo.replaceOne(Filters.eq("titulo", libro.getTitulo()), documento);
         }catch(Exception e){
             e.printStackTrace();
         }
    }

    //Funcion eliminar
    static void eliminarLibro(MongoCollection <Document> colMongo, String titulo){

         try{
             colMongo.deleteOne(Filters.eq("Titulo", titulo));
         }catch(Exception e){
             e.printStackTrace();
         }



    }

}
