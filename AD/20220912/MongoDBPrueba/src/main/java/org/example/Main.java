package org.example;
import org.bson.Document;

import static org.example.Parseos.libroAdoc;

public class Main
{
    public static void main( String[] args )
    {

        Document document = new Document();
        Libro libro = new Libro();

        libroAdoc(libro){
            return document;

    }

    }
}
