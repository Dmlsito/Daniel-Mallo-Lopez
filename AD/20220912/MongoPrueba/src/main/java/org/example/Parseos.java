package org.example;
import org.bson.Document;
public class Parseos {

    //En esta clase estaran las funciones de parseo

    //Funcion de parseo de un objeto de la clase libro a un documento en mongoDb

    static Document libroAdoc(Libro libro){

        //Instanciamos un documento nulo
        Document documento = null;

        if(libro != null){
            documento = new Document();
            //Vamos añadiendo a los campos del documento los valores de la clase libro
            documento.put("titulo", libro.getTitulo());
            documento.put("autor", libro.getAutor());
            documento.put("edicion", libro.getEdicion());
        }
        return documento;
    }

    //Funcion de parseo de un documento a un objeto en java

    static Libro documentoAlibro(Document documento){
         Libro libro = null;
         if(documento != null){
             libro = new Libro();
             //Recogemos los valores de los campos como propiedades de la clase libro
             libro.setEdicion(documento.getInteger("Edicion"));
             libro.setAutor(documento.getString("Autor"));
             libro.setTitulo(documento.getString("Titulo"));
         }
         return libro;
    }
}
