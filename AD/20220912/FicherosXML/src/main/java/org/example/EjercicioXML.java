package org.example;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.NodeList;
import org.w3c.dom.Node;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.DocumentBuilder;
import java.util.ArrayList;

public class EjercicioXML {

    public static void main (String[] args){

        //Crear un nuevo programa para la lectura y procesamiento de ficheros XML con DOM, que lea el siguiente
        // XML y lo transforme en una coleccion de elementos Mascota.
        //Recorrer la coleccion y modificar la mascota Churchill para indicar el genero a Macho y añadiendo una
        // mascota con nombre Leo y tipo Gato.


        ArrayList <Mascota> mascotas = new ArrayList<Mascota>(5);


        try{

            //Creamos lo que nos va a permitir crear el DocumentBuilder+

            //Definimos el path
            String path = "C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\AD\\20220912\\FicherosXML\\Ejercicio.xml";
            //Creamos el DocumentBuilderFactory
            DocumentBuilderFactory creador = DocumentBuilderFactory.newInstance();
            //Creamos el DocumentBuilder
            DocumentBuilder creadorDocumento = creador.newDocumentBuilder();
            //Creamos el Documento
            Document documento = creadorDocumento.parse(path);
            documento.getDocumentElement().normalize();
            //Obtenemos la lista de subnodos que tiene el elemento raiz
            NodeList listaNodos = documento.getElementsByTagName("mascota");


            for( int j = 0; j<listaNodos.getLength(); j++){

                Node nNodos = listaNodos.item(j);

                if(nNodos.getNodeType() == Node.ELEMENT_NODE){

                    //Leemos los elementos
                    Element elemento = (Element) nNodos;
                    String Nombre = elemento.getAttribute("Nombre");

                    Node node1 = elemento.getElementsByTagName("tipo").item(j);
                    String tipo =(node1!=null)? node1.getTextContent():null;

                    Node node2 = elemento.getElementsByTagName("edad").item(j);
                    String edad = (node2 != null)?node2.getTextContent(): null;


                    Node node3 = elemento.getElementsByTagName("genero").item(j);
                    String genero =(node3 != null)? node3.getTextContent(): null;

                    //Creamos la nueva mascota
                    Mascota mascota = new Mascota();
                    mascota.setNombre(Nombre);
                    mascota.setTipo(tipo);
                    mascota.setGenero(genero);

                    if(edad != null) {
                        mascota.setEdad(Integer.parseInt(edad));
                    }
                    mascotas.add(mascota);
                }
            }

            Mascota mascota = new Mascota();
            mascota.setNombre("Leo");
            mascota.setTipo("gato");
            mascotas.add(mascota);

            //Recorremos el array
            for(int h = 0; h<mascotas.size(); h++){

                //Si encontramos a Churchill le cambiamos el genero a macho
                if(mascota.getNombre().equals("Churchill")){
                    mascota.setGenero("Macho");
                }
                System.out.println(mascotas.get(h).toString());
            }




        }catch(Exception e){
            e.printStackTrace();
        }



    }
}
