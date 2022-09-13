package org.example;
import java.util.Scanner;

import org.omg.Messaging.SyncScopeHelper;

public class App
{
    public static void main( String[] args ) {
        Scanner teclado = new Scanner(System.in);

        System.out.println("Hola mundo");
        int num = 0;
        num = teclado.nextInt();
    }
}
