package Apprentissage;

import javax.swing.*;
import java.awt.*;

public class WithFlowLayoutPanel extends JPanel {
    private JLabel line1Label, line2Label;

    public WithFlowLayoutPanel(){
        line1Label = new JLabel("Henallux - Département IESN");
        line2Label = new JLabel("Informatique de Gestion");

        this.setLayout(new FlowLayout()); // Associe le gestionnaire de tracé FlowLayout

        this.add(line1Label);
        this.add(line2Label);
    }
}
