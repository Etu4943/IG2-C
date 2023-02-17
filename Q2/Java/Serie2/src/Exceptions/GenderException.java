package Exceptions;

public class GenderException extends Exception{
    private char wrongGender;

    private static String boxTitle = "Valeur pour le genre non acceptée";

    public GenderException(char wrongGender, String message){
        super(message);
        setWrongGender(wrongGender);
    }

    public char getWrongGender(){
        return wrongGender;
    }

    public void setWrongGender(char wrongGender){
        this.wrongGender = wrongGender;
    }

    public static String getBoxTitle() {
        return boxTitle;
    }
}
