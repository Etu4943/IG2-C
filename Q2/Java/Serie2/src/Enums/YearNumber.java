package Enums;

import javax.swing.*;

public enum YearNumber {
    ONE(1),
    TWO(2),
    THREE(3);

    YearNumber(int yearNumber) {
        this.yearNumber = yearNumber;
    }

    private int yearNumber;

    public int getYearNumber() {
        return yearNumber;
    }


    public static boolean contains(YearNumber origin){
        for(YearNumber value : values()){
            if(origin == value)
                return true;
        }
        return false;
    }




}
