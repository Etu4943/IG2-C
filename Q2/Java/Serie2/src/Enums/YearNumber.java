package Enums;

import java.util.ArrayList;

public enum YearNumber {
    ONE(1),
    TWO(2),
    THREE(3);
    private int yearNumber;

    public int getYearNumber() {
        return yearNumber;
    }

    YearNumber(int yearNumber) {
        this.yearNumber = yearNumber;
    }


    public static boolean contains(Integer origin){
        for(YearNumber value : values()){
            if(origin.equals(value.getYearNumber()))
                return true;
        }
        return false;
    }


}
