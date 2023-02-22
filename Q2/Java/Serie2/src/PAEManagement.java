import Enums.ErrorMessages;
import Exceptions.*;

import javax.swing.*;
import java.time.LocalDate;

public class PAEManagement {
    public static void main(String[] args) {
        try{
            Person teacher1 = new Person("Bob","Benson",'m', LocalDate.of(1987,2,15));
            Person teacher2 = new Person("Lila","Zoria",'w', LocalDate.of(1990,8,22));
            Person teacher3 = new Person("Paris","Geller",'w', LocalDate.of(1998,11,13));

            LearningActivity l1 = new LearningActivity("Geo",teacher1);
            LearningActivity l2 = new LearningActivity("Math",teacher2);
            LearningActivity l3 = new LearningActivity("Histoire",teacher3);

            Student s1 = new Student("Nora","Potier",'x',LocalDate.of(2003,10,12),"compta",1);

            s1.addLearningActivity(l1);
            s1.addLearningActivity(l2);
            s1.addLearningActivity(l3);

            for(int i = 0 ; i < s1.activitiesNB() ; i++){
                System.out.println(s1.getLearningActivities(i));
            }

        }catch(GenderException | SectionException | YearNumberException exception){
            String errorType = ErrorMessages.valueOf(exception.getClass().getSimpleName()).getErrorMessage();
            JOptionPane.showMessageDialog(null,exception, errorType, JOptionPane.ERROR_MESSAGE);
        }

    }
}
