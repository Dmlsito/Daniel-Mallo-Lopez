package org.example;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;




/**
 * Hello world!
 *
 */
public class TeoriaFicherosXML
{
    public static void main( String[] args )
    {
        //Para realizar el parseo de un documento mediante DOM hacemos uso del paquete javax.xml.parsers.
        //Para crear un objeto Document, escribimos lo siguiente
        //DocumentBuilderFactory fabrica(Nombre escogido) = DocumentBuildFactory.newInstance();
        //Su metodo es -> Elemetent getDocumentElement() -> Con esto obtenemos el elemento raiz

        //Los metodos del objeto Element son ->
        //NodeList getElementsByTagName(String name)
        //String getAttribute(String name) -> Recupera un valor de atributo por nombre
        //boolean hasAttribute(String name) -> Devuelve verdadero cuando se especifica un atributo con un nombre determinado en
        //este elemento o tiene un valor predeterminado; de lo contrario, devuelve falso

        //Los metodos del objeto Node son ->
        //......
        //Nota: Para utilizar todos estos metodos de dichas clases tenemos que importarlos



        //Ejemplo de lectura DOM

        try{
            //Instanciamos el DocumentBuilderFactory para poder obtener un obejto de la clase DocumentBuilder
            DocumentBuilderFactory  fabricaCreadorDocument = DocumentBuilderFactory.newInstance();

            //Creamos instancia de DocumentBuilder, esta clase implementa un parseador DOM
            DocumentBuilder creadorDocumento = fabricaCreadorDocument.newDocumentBuilder();

            //Creamos instancia de document indicando el fichero xml que debe parsear
            Document documento = creadorDocumento.parse("C:\\Users\\daniel\\Documents\\GitHub\\Daniel-Mallo-Lopez\\AD\20220912\\FicherosXML\\Ejemplo.xml");

            //Obtenemos el elemento raiz del documento
            Element raiz = documento.getDocumentElement();

            //Obtenemos la lista de nodos que tienen la etiqueta "EMPLEADO"
            NodeList listaEmpleados = raiz.getElementsByTagName("EMPLEADO");

            //Con un for recorremos la lista de los empleados
            for(int i = 0; i<listaEmpleados.getLength(); i++){

                //Guardamos los datos de un empleado
                Node empleado = listaEmpleados.item(i);

                //Imprimir cabecera
                System.out.println("Empleado" + i);
                System.out.println("=========");

                //Obtenemos la lista de los datos que contiene ese empleado
                NodeList datosEmpleado = empleado.getChildNodes();


                //Recuperamos un dato concreto del empleado
                Element elemento = (Element) empleado;
                Node nodoNombre = elemento.getElementsByTagName("NOMBRE").item(0);
                String valNombre = nodoNombre.getTextContent();
                System.out.println("Nombre : " + valNombre);
            }







        }catch(Exception e){
            ex.printStackTrace();
        }






    }
}
