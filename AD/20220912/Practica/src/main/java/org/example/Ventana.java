package org.example;

import javax.swing.JFrame;

public class Ventana extends JFrame{

    static int panel = 1;
    static double sumaT = 0;

    public Ventana() {

        setTitle("Carrera de Caballos");
        setResizable(false);

        setBounds(700, 100, 700, 500);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        if(panel == 1) {
            Evento evento = new Evento();
            add(evento);
        }

        setVisible(true);


    }




}