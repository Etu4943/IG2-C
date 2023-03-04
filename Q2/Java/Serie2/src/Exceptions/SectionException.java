package Exceptions;

public class SectionException extends Exception{
    private String wrongSection;

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

}
