package Exceptions;

public class SectionException extends Exception{
    private String wrongSection;
    private static String boxTitle = "Section non accpetée";

    public SectionException(String wrongSection, String message) {
        super(message);
        setWrongSection(wrongSection);
    }

    public void setWrongSection(String wrongSection) {
        this.wrongSection = wrongSection;
    }

    public String getWrongSection() {
        return wrongSection;
    }

    public static String getBoxTitle() {
        return boxTitle;
    }
}
