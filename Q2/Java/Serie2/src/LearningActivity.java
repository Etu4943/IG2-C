public class LearningActivity {
    private String title;
    private Person teacher;

    public LearningActivity(String title, Person teacher){
        this.title = title;
        this.teacher = teacher;
    }
    public String toString(){
        StringBuilder output = new StringBuilder();
        output.append("L'activité d'apprentissage intituté ");
        output.append(title);
        output.append(" donnée par ");
        output.append(teacher);
        return output.toString();
    }
}
