package Enums;

public enum ErrorMessages {
    SectionException("Section non acceptée"),
    YearNumberException("Année d’inscription non acceptée"),
    GenderException("Valeur pour le genre non acceptée");

    private String errorMessage;

    public String getErrorMessage() {
        return errorMessage;
    }

    ErrorMessages(String errorMessage) {
        this.errorMessage = errorMessage;
    }
}
