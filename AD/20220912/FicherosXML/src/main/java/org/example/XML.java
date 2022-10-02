package org.example;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;
import javax.xml.parsers.DocumentBuilder;
import  javax.xml.parsers.DocumentBuilderFactory;




public class XML
{
    public static void main( String[] args )
    {
        /*try{
            //Creamos el DocumetBuilderFactoy
            DocumentBuilderFactory fabricarCreadorDocumento = DocumentBuilderFactory.newInstance();
            //Creamos el DocumentBuilder
            DocumentBuilder creadorDocumento = fabricarCreadorDocumento.newDocumentBuilder();
            //Creamos el documento
            Document documento = creadorDocumento.parse("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\AD\\20220912\\FicherosXML\\Ejemplo.xml");
            //Obtenemos el elemento raiz
            Element raiz = documento.getDocumentElement();
            //Vamos a obtener la lista de nodos que tiene la etiqueta empleado
            NodeList listaNodosEmpleado = raiz.getElementsByTagName("EMPLEADO");

            //Recorremos toda la lista de nodos
            for(int i = 1; i<listaNodosEmpleado.getLength(); i++){

                Node empleado = listaNodosEmpleado.item(i);
                System.out.println("Empleado" + i);
                //Obtenemos la lista de los datos que contiene ese empleado
                NodeList datosEmpleado = empleado.getChildNodes();

                //Recorremos la lista de todos los datos del empleado
                for(int k = 0; k<datosEmpleado.getLength(); k++){

                    //Obtenemos de la lista un dato tras otro
                    Node dato = datosEmpleado.item(k);
                    //Tenemos que comprobar si el dato se trata de un nodo de tipo element
                    if(dato.getNodeType() == Node.ELEMENT_NODE){

                        //Mostramos el nombre del tipo de dato
                        System.out.println(dato.getNodeName() + " : ");
                        //El valor esta contenido  del nodo element
                        Node datoContenido = dato.getFirstChild();
                       //Mostramos el valor del nodo que debe de ser de tipo text
                        if(datoContenido != null && datoContenido.getNodeType() == Node.TEXT_NODE){
                            System.out.println(datoContenido.getNodeValue());
                        }

                    }


                    System.out.println();



                }


            }







        }catch(Exception e){
            e.printStackTrace();
        }
*/







        try{

            //Creamos el DocumentBuilderFactory
            DocumentBuilderFactory br = DocumentBuilderFactory.newInstance();
            //Creamos el DocumentBuilderç
            DocumentBuilder creadorDocumento = br.newDocumentBuilder();
            //Creamos el documento
            Document documento = creadorDocumento.parse("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\AD\\20220912\\FicherosXML\\Ejemplo.xml");

            //Ahora vamos a obtener el elemento raiz
            Element raiz = documento.getDocumentElement();

            NodeList listaNodosPrincipales = raiz.getElementsByTagName("EMPLEADO");

            //Recorremos la listaNodosPrincipales
            for(int i = 1; i<listaNodosPrincipales.getLength();i++){

                //Accedo a un nodo en concreto
                Node nodo = listaNodosPrincipales.item(i);
                System.out.println("Empleado" + i);

                //Ahora accedemos a los childNodes de nodo
                NodeList listadoDeChildsNodes = nodo.getChildNodes();

                //Recorro el listadoDeChildsNodes+
                for(int k = 0; k<listadoDeChildsNodes.getLength(); k++){

                    //Accedo a un nodo en concreto
                    Node subNode = listadoDeChildsNodes.item(k);
                    //Compruebo que se trata de un dato de tipo element
                    if(subNode.getNodeType() == Node.ELEMENT_NODE){

                        //Mostramos el nombre del nodo
                        System.out.println(subNode.getNodeName() + ": ");
                        Node datoContenido = subNode.getFirstChild();

                        //Compruebo que el datoContenido es de tipo texto
                        if(datoContenido != null && datoContenido.getNodeType() == Node.TEXT_NODE){
                            System.out.println(datoContenido.getNodeValue());
                        }


                    }
                    //Espacio entre las lineas
                    System.out.println();


                }



            }

        }catch(Exception e){
            e.printStackTrace();
        }



    }
}
