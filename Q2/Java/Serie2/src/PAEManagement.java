import Exceptions.*;
import Enums.*;

import javax.swing.*;
import java.time.LocalDate;

public class PAEManagement {
    public static void main(String[] args) {
        try{
            Person teacher1 = new Person("Bob","Benson",Gender.M, LocalDate.of(1987,2,15));
            Person teacher2 = new Person("Lila","Zoria",Gender.W, LocalDate.of(1990,8,22));
            Person teacher3 = new Person("Paris","Geller",Gender.W, LocalDate.of(1998,11,13));

            LearningActivity l1 = new LearningActivity("Geo",teacher1);
            LearningActivity l2 = new LearningActivity("Math",teacher2);
            LearningActivity l3 = new LearningActivity("Histoire",teacher3);

            Student s1 = new Student("Mika","Potier",Gender.X,LocalDate.of(2003,10,12),Section.COMPTA,YearNumber.ONE);

            s1.addLearningActivity(l1);
            s1.addLearningActivity(l2);
            s1.addLearningActivity(l3);

            for(int i = 1 ; i <= s1.activitiesNB() ; i++){
                System.out.println(s1.getLearningActivities(i));
            }
            System.out.println(s1.getLearningActivities(-1));

        }catch(BadPositionException exception){
            JOptionPane.showMessageDialog(null,exception, "Indice d'activité non reconnu", JOptionPane.ERROR_MESSAGE);
        }catch(SectionException exception){
            JOptionPane.showMessageDialog(null,exception, "Erreur dans la section", JOptionPane.ERROR_MESSAGE);
        }catch(YearNumberException exception){
            JOptionPane.showMessageDialog(null,exception, "Erreur dans l'année d'étude", JOptionPane.ERROR_MESSAGE);
        }catch(TooManyActivities exception){
            JOptionPane.showMessageDialog(null,exception, "Trop d'acticités", JOptionPane.ERROR_MESSAGE);
        }catch(GenderException exception){
            JOptionPane.showMessageDialog(null,exception, "Valeur du genre non acceptée", JOptionPane.ERROR_MESSAGE);
        }
        System.exit(0);

    }
}
