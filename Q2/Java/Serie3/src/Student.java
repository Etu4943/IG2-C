import java.io.Serializable;

public class Student implements Serializable {
    private String firstName;
    private String lastName;
    private SchoolYear schoolYear;

    Student(String firstName, String lastName, SchoolYear schoolYear){
        this.firstName = firstName;
        this.lastName = lastName;
        this.schoolYear = schoolYear;
    }

    @Override
    public String toString(){
        StringBuilder output = new StringBuilder();
        output.append(firstName);
        output.append(" ");
        output.append(lastName);
        output.append(" ");
        output.append(schoolYear);
        return output.toString();
    }
}
