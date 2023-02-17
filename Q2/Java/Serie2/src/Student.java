import Exceptions.GenderException;
import Exceptions.SectionException;
import Exceptions.YearNumberException;

import java.time.LocalDate;

public class Student extends Person{
    private String sectionName;
    private int studyYearNumber;
    private static int womanCount;

    public Student(String firstname, String lastname, char gender, LocalDate birthdate, String sectionName, int studyYearNumber) throws GenderException, SectionException, YearNumberException {
        super(firstname, lastname, gender, birthdate);
        setSectionName(sectionName);
        setStudyYearNumber(studyYearNumber);
        if(gender == 'w')
            womanCount += 1;
    }

    public void setSectionName(String sectionName) throws SectionException{
        if(!Enums.Section.contains(sectionName)){
            throw new SectionException(sectionName,"Wrong section name entered");
        }
        this.sectionName = sectionName;
    }

    public void setStudyYearNumber(int studyYearNumber) throws YearNumberException{
        if(!Enums.YearNumber.contains(studyYearNumber))
            throw new YearNumberException(studyYearNumber,"Wrong year entered");
        this.studyYearNumber = studyYearNumber;
    }

    public int getStudyYearNumber() {
        return studyYearNumber;
    }

    public String getSectionName() {
        return sectionName;
    }

    public String toString(){
        StringBuilder output = new StringBuilder();
        output.append(super.toString());
        output.append(" est inscrit en ");
        output.append(getStudyYearNumber());
        output.append("e ");
        output.append(sectionName);
        output.append(".\n");
        output.append("Son nom d'utilisateur est : ");
        output.append(loginName());
        return output.toString();
    }

    public String loginName(){
        StringBuilder output = new StringBuilder();
        output.append(sectionName.substring(0,2));
        output.append(studyYearNumber);
        output.append(getLastname());
        output.append(getFirstname().charAt(0));
        return output.toString();
    }

    public static int getWomanCount() {
        return womanCount;
    }
}
