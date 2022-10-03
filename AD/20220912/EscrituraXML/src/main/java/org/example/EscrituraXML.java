package org.example;
import org.w3c.dom.Document;
import org.w3c.dom.NodeList;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.transform.OutputKeys;
import javax.xml.transform.Transformer;
import javax.xml.transform.TransformerFactory;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.StreamResult;
import java.io.File;


public class EscrituraXML
{
    public static void main( String[] args ) {

        try{
            DocumentBuilderFactory creador = DocumentBuilderFactory.newInstance();
            DocumentBuilder creadorDocumento = creador.newDocumentBuilder();
            Document documento = creadorDocumento.parse("C:\\Users\\daniel\\Documents\\GitHub\\Daniel-Mallo-Lopez\\AD\\20220912\\EscrituraXML\\src\\main\\java\\org\\example\\Empleado.xml");

            //Obtenemos el elemento raiz
            Element raiz = documento.getDocumentElement();
            //Creamos una nueva mascota
            Element mascota  = documento.createElement("mascota");
            //Indicamos que cuelgue del elemento raiz
            raiz.appendChild(mascota);
            //Indicamos que queremos que el elemento mascota tenga un atributo
            mascota.setAttribute("Nombre", "daniel");
            //Creamos el elemento edad
            Element edad = documento.createElement("Edad");
            mascota.appendChild(edad);
            edad.setTextContent("23");
            //Creamos el elemento tipo
            Element tipo = documento.createElement("Tipo");
            mascota.appendChild(tipo);
            tipo.setTextContent("loro");



            //Persistimos cambios en DOM a fichero
            TransformerFactory transformerFactory = TransformerFactory.newInstance();
            Transformer transformer = transformerFactory.newTransformer();
            transformer.setOutputProperty(OutputKeys.INDENT, "yes");
            transformer.setOutputProperty("{http://xml.apache.org/xslt}indent-amont", "3");
            DOMSource domSource = new DOMSource(documento);
            StreamResult result =new StreamResult(new File("C:\\Users\\daniel\\Documents\\GitHub\\Daniel-Mallo-Lopez\\AD\\20220912\\EscrituraXML\\src\\main\\java\\org\\example\\Mascotas2.xml"));
            transformer.transform(domSource, result);





        }catch(Exception e){
            e.printStackTrace();
        }











    }
}
