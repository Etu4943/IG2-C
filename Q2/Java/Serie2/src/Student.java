import Exceptions.*;
import Enums.*;

import java.time.LocalDate;
import java.util.ArrayList;

public class Student extends Person{
    private Section sectionName;
    private YearNumber studyYearNumber;

    private static int MAX_SIZE = 4;

    private LearningActivity[] learningActivities;
    private static int womanCount;

    public Student(String firstname, String lastname, Gender gender, LocalDate birthdate, Section sectionName, YearNumber studyYearNumber) throws GenderException, SectionException, YearNumberException {
        super(firstname, lastname, gender, birthdate);
        setSectionName(sectionName);
        setStudyYearNumber(studyYearNumber);
        if(gender == Gender.W)
            womanCount += 1;
        learningActivities = new LearningActivity[MAX_SIZE];
    }

    public void setSectionName(Section sectionName) throws SectionException{
        if(!Enums.Section.contains(sectionName)){
            throw new SectionException(sectionName.getName(),"Wrong section name entered");
        }
        this.sectionName = sectionName;
    }

    public void setStudyYearNumber(YearNumber studyYearNumber) throws YearNumberException{
        if(!Enums.YearNumber.contains(studyYearNumber))
            throw new YearNumberException(studyYearNumber.getYearNumber(),"Wrong year entered");
        this.studyYearNumber = studyYearNumber;
    }

    public int getStudyYearNumber() {
        return studyYearNumber.getYearNumber();
    }

    public String getSectionName() {
        return sectionName.getName();
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
        output.append(sectionName.getName().substring(0,2));
        output.append(studyYearNumber.getYearNumber());
        output.append(getLastname());
        output.append(getFirstname().charAt(0));
        return output.toString();
    }

    public static int getWomanCount() {
        return womanCount;
    }

    public int activitiesNB(){
        int compteur = 0;
        while(learningActivities[compteur] != null && compteur < MAX_SIZE){
            compteur ++;
        }
        return compteur;
    }

    public void addLearningActivity(LearningActivity learningActivity) throws TooManyActivities{
        int indice = activitiesNB();
        if(indice == MAX_SIZE - 1)
            throw new TooManyActivities();
        learningActivities[indice] = learningActivity;
    }


    public LearningActivity getLearningActivities(int indice) throws BadPositionException
    {
        int activitiesNB = activitiesNB();
        if(indice <= 0 || indice > activitiesNB)
            throw new BadPositionException(indice,activitiesNB);
        return learningActivities[indice-1];
    }
}
