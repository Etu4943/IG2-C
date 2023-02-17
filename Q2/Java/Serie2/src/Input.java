public class Input {
    private String message;
    private boolean condition;

    public Input(String message, boolean condition) {
        this.message = message;
        this.condition = condition;
    }

    public String getMessage() {
        return message;
    }

    public boolean getCondition() {
        return condition;
    }
}
