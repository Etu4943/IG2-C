package Exceptions;

public class YearNumberException extends Exception{
    int wrongYear;

    public YearNumberException(int wrongYear, String message) {
        super(message);
        setWrongYear(wrongYear);
    }

    public void setWrongYear(int wrongYear) {
        this.wrongYear = wrongYear;
    }

    public int getWrongYear() {
        return wrongYear;
    }

}
