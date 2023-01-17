package org.example;

import com.sun.corba.se.spi.orbutil.threadpool.NoSuchThreadPoolException;
import com.sun.media.jfxmediaimpl.HostUtils;

import javax.swing.*;
import javax.swing.event.ChangeEvent;
import javax.swing.event.ChangeListener;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.SQLOutput;

public class Evento extends JPanel implements ActionListener {

    private JButton btnStart;
    private JSlider slider1;
    private JSlider slider2;
    private JSlider slider3;
    private JProgressBar progres1;
    private JProgressBar progres2;
    private JProgressBar progres3;
    private TextField textField1;
    private TextField textField2;
    private TextField textField3;


    Thread hilo1 = new Thread() {

        public void run() {
            System.out.println();
            for (int i = 0; i < 100; i++) {
                //Con el for vamos recorriendo y aumentando en base al iterador
                progres1.setValue(i);
                //De esta forma cada 100 milisegundos dormira
                try {
                    currentThread().sleep(100);
                }catch(Exception e){
                    e.printStackTrace();
                }
            }
            //Una vez que acabe de rellenarse la progressBar la reiniciamos
            progres1.setValue(0);

        }
    };
    Thread hilo2 = new Thread() {
        public void run() {
            for (int i = 0; i < 100; i++) {
                progres2.setValue(i);

                try {
                    currentThread().sleep(100);
                }catch(Exception e){
                    e.printStackTrace();
                }
            }
            progres2.setValue(0);

        }
    };

    Thread hilo3 = new Thread() {
        public void run() {
            for (int i = 0; i < 100; i++) {
                progres3.setValue(i);
                try {
                    currentThread().sleep(100);
                }catch(Exception e){
                    e.printStackTrace();
                }
            }
            progres3.setValue(0);

        }
    };

    public Evento() {

        setLayout(null);
        btnStart = new JButton("Comenzar carrera");
        btnStart.setBounds(200, 20, 150, 20);
        btnStart.addActionListener(this);

        //El slider 1 es slider 3
        slider1 = new JSlider(1, 10, 5);
        slider1.setBounds(125, 325, 300, 20);

        slider1.addChangeListener(new ChangeListener() {
            @Override
            public void stateChanged(ChangeEvent e) {
                hilo3.setPriority(slider1.getValue());

            }
        });

        slider2 = new JSlider(1, 10, 5);
        slider2.setBounds(125, 200, 300, 20);
        //Estos cambios se han realizado para que el valor del slider y la prioridad de los hilos vaya  acorde

        slider2.addChangeListener(new ChangeListener() {
            @Override
            public void stateChanged(ChangeEvent e) {
                hilo2.setPriority(slider2.getValue());
                System.out.println(hilo2.getPriority());
            }
        });

        slider3 = new JSlider(1, 10, 5);
        slider3.setBounds(125, 80, 300, 20);
        slider3.addChangeListener(new ChangeListener() {
            @Override
            public void stateChanged(ChangeEvent e) {
                hilo1.setPriority(slider3.getValue());
            }
        });

        progres1 = new JProgressBar();
        progres1.setBounds(0, 380, 700, 20);
        progres1.setMaximum(100);

        progres2 = new JProgressBar();
        progres2.setBounds(0, 250, 700, 20);
        progres2.setMaximum(100);

        progres3 = new JProgressBar();
        progres3.setBounds(0, 120, 700, 20);
        progres3.setMaximum(100);

        textField1 = new TextField("TextField1");
        textField1.setBounds(50, 420, 100, 25);

        textField2 = new TextField("TextField1");
        textField2.setBounds(250, 420, 100, 25);

        textField3 = new TextField("TextField1");
        textField3.setBounds(450, 420, 100, 25);

        add(btnStart);
        add(slider1);
        add(slider2);
        add(slider3);
        add(progres1);
        add(progres2);
        add(progres3);
        add(textField1);
        add(textField2);
        add(textField3);

        //Seteamos a true para que se pueda ver la pantalla
        setVisible(true);
    }
    public void comenzarCarrera(){
        hilo1.start();
        hilo2.start();
        hilo3.start();
    }

    @Override
    public void actionPerformed(ActionEvent e) {

        if(e.getSource().equals(btnStart)){
          comenzarCarrera();
        }

    }
}
