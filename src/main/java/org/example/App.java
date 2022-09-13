package org.example;
import java.util.Scanner;

import org.omg.Messaging.SyncScopeHelper;

public class App
{
    public static void main( String[] args ) {

        Scanner teclado = new Scanner(System.in);

        int numeroAmigos = 0;

        String dorsal = teclado.nextLine();
        numeroAmigos = contarAmigos(dorsal);

        System.out.println(numeroAmigos);

    }
    public static int contarAmigos(String dorsal){
        int resultado = 0 ; /*numero de amigos*/

        for(int i = 1; i <=99999; i++){

            if(productoDigitos(dorsal, String.valueOf(i))){
                resultado ++; /*Si se da el caso de que son amigos se incrementara*/
            }
        }
        return resultado;
    }

    public static boolean productoDigitos(String dorsal, String numero){

        //Si el numero contiene 1 ya no es amigo
        if(numero.contains("1")){
            return false;
        }

        int digito = 0;
        int producto = 1;

        for(int i = 0; i<= numero.length(); i++) {
            digito = Character.getNumericValue(numero.charAt(i));
            producto = producto * digito;
        }
        //Si el producto coincide con el dorsal entonces son amigos, sino ps no
        if(producto == Integer.parseInt(dorsal)){
            return true;
        } else{
            return false;
        }

    }



    }

