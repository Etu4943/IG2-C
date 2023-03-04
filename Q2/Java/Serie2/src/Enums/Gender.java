package Enums;

import javax.swing.*;

public enum Gender {
    M('m'),
    W('w'),
    X('x');

    private char gender;

    Gender(char gender){
        setGender(gender);
    }

    public void setGender(char gender) {
        this.gender = gender;
    }

    public char getGender() {
        return gender;
    }

    /*public static Gender forChar(char c)
    {
        if (c == 'm')
            return Gender.M;
    }

     */

    public static boolean contains(Gender origin){
        for(Gender value : values()){
            if(origin == value)
                return true;
        }
        return false;
    }
}
