package org.example;


public class Ej2 {

    public  static void main(String []args){

        //Abrir un fichero y leerlo byte a byte mostrando cada uno de estos en la pantalla en formato decimal, en formato hexadecimal y en formato char
        //separando cada byte por un guion.

        ejercicio2();

    }

    private static  void ejercicio2(){

        FileImputStream fis = null;

        try {
            fis = new FileImputStream("C:\\Users\\daniel\\Desktop\\Desarrollo de apliaciones moviles\\Acceso a datos\\directorio1\\fichero1.txt");

            // Esta variable servira como un contador
            int x = fis.read();
            String salidaDecimal = new String("");
            String salidaHexadecimal = new String("");
            String salidaChar = new String("");

            //Mientras que la variable x no sea -1 se ira guardando la salida de varias formas
            while (x != -1) {
                salidaDecimal = salidaDecimal + x + "-";
                salidaHexadecimal = salidaHexadecimal + Integer.toHexString(x);
                salidaChar = salidaChar + (char) x + "-";
            }

            //Despues de que se hayan recogido todos los datos se imprime el resultado por pantalla
            System.out.println(salidaDecimal);
            System.out.println(salidaChar);
            System.out.println(salidaHexadecimal);

        }catch(Exception e){
            e.printStackTrace();
        }
        //Este finally se utiliza para cerrar el codigo, aunque este falle
        finally {
            try{
                if(fis!=null){
                    fis.close();
                }
            }catch(Exception e){
                e.printStackTrace();
            }
        }


    }
}
