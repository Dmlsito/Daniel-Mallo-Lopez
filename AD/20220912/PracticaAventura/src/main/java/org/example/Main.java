package org.example;
import java.util.Scanner;
import javax.xml.bind.JAXBContext;
import javax.xml.bind.Unmarshaller;
import java.io.File;
import java.util.ArrayList;

public class Main
{

    public static  void main(String[] args ) {

        String opcion;
        Escena escenaActual = null;
        Scanner teclado = new Scanner(System.in);
        int numeroEscena = 1;
        boolean partidaFinalizada = false;
        String ruta = "E:\\DAW2\\Acceso a datos\\PracticaAventura\\src\\main\\java\\org\\example\\Aventura.xml";

        //Instanciamos un objeto aventura
        Aventura aventura = new Aventura();
        //Para dicho objeto tenga todos los elementos del xml lo igualamos a lo que nos devuelve la función leerAventura
        aventura = leerAventura(ruta);

        //Si se quiere imprimir toda la aventura descomenta la linea 26 y comentar desde la liena 28 a la 60
        //System.out.println(aventura);

        do{
            //Reiniciamos los valores, como queremos que printe siempre la primera escena le damos el valor 1 a numeroEscena
            numeroEscena = 1;
            partidaFinalizada = false;

            //Imprimimos el titulo de la aventura
            System.out.println(aventura.getTitulo());
            //Imprimimos el texto de la primera escena
            while (!partidaFinalizada) {
                //Llamo a la función para que vaya imprimiendo el texto y sus opciones
                mostrarEscenas(aventura, numeroEscena);
                //Después de haberle mostrado al usuario las opciones le preguntamos que quiere hacer y recogemos por teclado su respuesta
                System.out.println("Que quieres elegir? \n");
                numeroEscena = teclado.nextInt();
                //Si el número de la escena corresponde con la escena final la condición para que el bucle se cierre se cumplirá, en este caso es que la variable booleana partidaFinalizada
                // se ponga a true
                if (numeroEscena == 100) {
                    partidaFinalizada = true;
                }
            }

            escenaActual = aventura.getListaEscenas().get(10);
            //Imprimimos el texto de la última escena
            System.out.println(escenaActual.getTexto() + "\n");
            //Opción de volver a jugar
            System.out.println("Quieres volver a jugar");
            opcion = teclado.next();

        }while(opcion.equals("si"));

        System.out.println("MUCHAS GRACIAS POR JUGAR");


    }
    public static Aventura leerAventura(String ruta) {
        //Inicializamos el objeto aventura a null
        Aventura aventura = null;
        try {
            //Creamos un fichero que tendrá la ruta de nuestro xml
            File file = new File(ruta);

            if (file.exists()) {
                JAXBContext context = JAXBContext.newInstance(Aventura.class);
                Unmarshaller unmarshaller = context.createUnmarshaller();
                aventura = (Aventura) unmarshaller.unmarshal(file);

            } else {
                System.out.println("Fichero no encontrado");
            }
        } catch (Exception e) {
            e.printStackTrace();
            System.out.println("SE HA PRODUCIDO UN ERROR EN LA OPERACION");

        }
        return aventura;

    }

    private static Escena mostrarEscenas(Aventura aventura ,int numeroEscena) {
        //Inicializmos el objeto escena a null
        Escena escena = null;

        //Recorremos el listado de escenas de la aventura que recogemos por parámetro y vamos recogiendo en el objeto escena que creamos antes el listado de escenas de esa aventura
        for (int i = 0; i < aventura.getListaEscenas().size(); i++) {
            escena = aventura.getListaEscenas().get(i);
            //Si el codigo de la escena coincide con el número que escribe el usuario por pantalla se printara el texto de esa escena
            if (escena.getCodigoEscena() == numeroEscena) {
                //Imprimimos el texto de la escena
                System.out.println(escena.getTexto());
                //De la misma forma que hicimos para recorrer las escenas recorremos sus opciones, en este caso como solo nos interesa printar la escena que hace referencia ese usuario y el texto de la opcion
                //solo printamos eso
                for(Opcion opcion: escena.getListadoOpciones()){

                    //Imprimimos el texto de la opcion y el resultado que llevara a dicha escena
                    System.out.println(opcion.getResultado() +  " - "  + opcion.getTextoOpcion() + "\n");
              }
            }
        }
        //Retornamos la escena
        return escena;

    }









}