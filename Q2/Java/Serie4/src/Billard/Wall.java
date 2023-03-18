package Billard;

import java.awt.*;

public class Wall {
    Rectangle rectangle; // {x,y,width,heigth}
    Color color;

    public Wall(int Xposition, int Yposition, int width, int heigth,Color color){
        rectangle = new Rectangle(Xposition,Yposition,width,heigth);
        this.color = color;
    }

    public void draw(Graphics g){
        g.fillRect(rectangle.x, rectangle.y,rectangle.width,rectangle.height);
        g.setColor(color);
    }
}
