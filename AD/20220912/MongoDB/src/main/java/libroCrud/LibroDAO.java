package libroCrud;

import converter.LibroDocConverter;
import model.Libro;
import com.mongodb.Mongoclient;
import com.mongodb.client.MongoCollection;
import javax.swing.text.Document;
import java.util.ArrayList;
import java.util.List;


public class LibroDAO {
    //Creamos un convertidor
    LibroDocConverter converter = new LibroDocConverter();

    //Listar libros (metodos)
    public List<Libro> listaLibros(MongoCollection<Document> mongodb){


        List<Libro> libros = new ArrayList<Libro>();
        List<Document> documentos = mongodb.find().into(new ArrayList<Document>());
        Libro libro;

        for(Document documento: documentos){
            libro = converter.docALibro(documento);

            libros.add(libro);
        }

    }


}
