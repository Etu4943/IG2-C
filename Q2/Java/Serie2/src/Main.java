import Enums.ErrorMessages;
import Exceptions.*;
import java.time.LocalDate;
import java.util.ArrayList;
import javax.swing.*;


public class Main {

    public static void main(String[] args) {
        LocalDate d1 = LocalDate.of(2001,3,17);

        Student s1;
        ArrayList<Student> students = new ArrayList<>();
        while(JOptionPane.showConfirmDialog(null,"Desire-tu créer un étudiant ?") == 0){
            String firstname = Main.demanderInfos("Quel est votre prénom : ");
            String lastname = Main.demanderInfos("Quel est votre nom : ");
            String genre = Main.demanderInfos("Quel est votre genre : ");
            String section = Main.demanderInfos("Quel est votre section : ").toLowerCase();
            Integer studyYear = Integer.parseInt(Main.demanderInfos("Quel est votre année d'étude  : "));
            Student newStudent;
            try {
                Person p1 = new Person("Clément", "Potier", 'w', d1);
                newStudent = new Student(firstname,lastname,genre.charAt(0),d1,section,studyYear);
                students.add(newStudent);
                JOptionPane.showMessageDialog(null,newStudent,"Confirmation d'inscription",JOptionPane.PLAIN_MESSAGE);
            }
            catch(GenderException | SectionException | YearNumberException exception) {
                String errorType = ErrorMessages.valueOf(exception.getClass().getSimpleName()).getErrorMessage();
                JOptionPane.showMessageDialog(null,exception, errorType, JOptionPane.ERROR_MESSAGE);
            }
        }
        for(Student student : students){
            System.out.println(student);
        }
        System.out.println("Woman count : " + Student.getWomanCount());
        System.exit(0);
    }

    public static String demanderInfos(String message){
        return JOptionPane.showInputDialog(message);
    }


}
