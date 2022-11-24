package org.example;

import org.bson.Document;

public class Parseos {

    //Funcion para convertir un objeto libro a un documento

    static private Document libroAdoc(Libro libro){
        //Creamos el objeto documento y por ahora lo inicializamos a nulo
        Document document = null;

        //Si libro no esta vacio
            if(libro != null){
                document = new Document();
                //Asiganamos los valores del objeto libro al documento
                document.put("titulo", libro.getTitulo());
                document.put("autor", libro.getAutor());
                document.put("edicion", libro.getEdicion());
            }
        return document;
    }

    //Funcion para convertir un documento en un libro

    static private Libro documentoAlibro(Document document){
        //Creamos el objeto libro y por ahora lo inicializamos a nulo
        Libro libro = null;

        //Si document no esta vacio
        if(document != null){
            libro = new Libro();
            //Recuperamos los campos del documento y seteamos el objeto libro con sus valores
            libro.setTitulo(document.getString("titulo"));
            libro.setAutor(document.getString("autor"));
            libro.setEdicion(document.getInteger("edicion"));
        }


        return libro;
    }
}
