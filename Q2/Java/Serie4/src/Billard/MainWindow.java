package Billard;

import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class MainWindow extends JFrame {
    private Billard billard;
    private Container mainContainer;

    Wall w1 = new Wall(400,200,300,10,Color.BLUE); // Haut
    Wall w2 = new Wall(690,200,10,150,Color.GREEN); // droite
    Wall w3 = new Wall(690,340,-300,10,Color.YELLOW); // bas
    Wall w4 = new Wall(390,350,10,-150,Color.RED); // gauche

    public MainWindow(){
        super("Billard");

        setBounds(100,100,1280,720);

        addWindowListener(new WindowAdapter(){
            public void windowClosing(WindowEvent e){
                System.exit(0);
            }
        });

        billard = new Billard(w1,w2,w3,w4);

        mainContainer = this.getContentPane();

        mainContainer.add(billard);

        setVisible(true);

    }
}
