package Apprentissage;

import javax.swing.*;
import java.awt.*;

public class WithLayoutWindow extends JFrame {
    private Container frameContainer;
    private WithFlowLayoutPanel panel;

    public WithLayoutWindow(){
        super("Welcome");
        setBounds(100,100,300,300);
        panel = new WithFlowLayoutPanel();

        frameContainer = this.getContentPane();

        frameContainer.setLayout(new BorderLayout());

        frameContainer.add(panel,BorderLayout.CENTER); // Place le panneau au centre de la fenêtre => Seul composant => prend toute la place

        this.setVisible(true);
    }
}
