package Apprentissage;

import javax.swing.*;
import java.awt.*;

public class WithGridLayoutPanel extends JPanel {
    private JButton un,deux,trois,quatre,cinq,six;

    public WithGridLayoutPanel(){
        un = new JButton("un");
        deux = new JButton("deux");
        trois = new JButton("trois");
        quatre = new JButton("quatre");
        cinq = new JButton("cinq");
        six = new JButton("six");

        this.setLayout(new GridLayout(2,3));

        this.add(un);
        this.add(deux);
        this.add(trois);
        this.add(quatre);
        this.add(cinq);
        this.add(six);
    }
}
