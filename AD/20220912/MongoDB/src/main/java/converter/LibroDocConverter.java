package converter;
import org.bson.Document;
public class LibroDocConverter {

    public Document libroADoc(Libro libro){
        Document document = null;

        if(libro != null){
            document = new Document();

            //Este documento recibe los campos que tendra el documento en MongoDB
            document.put("titulo", libro.getTitulo());
            document.put("autor", libro.getAutor());
            document.put("edicion", libro.getEdicion());
        }

        return document;
    }

    public Libro docALibro(Document document){
        Libro libro = null;
        if(document != null){
            libro = new Libro();

            libro.setTitulo(document.getString("titulo"));
            libro.setAutor(document.getString("Autor"));
            libro.setEdicion(document.getInt("Edicion"));
        }

    }
}
