import Enums.AcademicDegree;

import java.io.Serializable;

public class SchoolYear implements Serializable {
    private String section;
    private int yearNum;
    AcademicDegree degree;

    public SchoolYear(String section, int yearNum, AcademicDegree degree) {
        this.section = section;
        this.yearNum = yearNum;
        this.degree = degree;
    }

    @Override
    public String toString(){
        StringBuilder output = new StringBuilder();
        output.append(degree.getName());
        output.append(" ");
        output.append(yearNum);
        output.append(" en ");
        output.append(section);
        return output.toString();
    }
}
