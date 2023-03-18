package Billard;

import javax.swing.*;
import java.awt.*;
import java.util.ArrayList;

public class Billard extends JPanel {
    private ArrayList<Wall> verticalWalls = new ArrayList<>();
    private ArrayList<Wall> horizontalWalls = new ArrayList<>();

    public Billard(Wall haut, Wall droite,Wall bas, Wall gauche){
        verticalWalls.add(droite);
        verticalWalls.add(gauche);
        horizontalWalls.add(haut);
        horizontalWalls.add(bas);
    }

    @Override
    public void paint(Graphics g){
        super.paint(g);
        for (Wall wall: verticalWalls) {
            wall.draw(g);
        }
        for (Wall wall: horizontalWalls) {
            wall.draw(g);
        }

    }






}
