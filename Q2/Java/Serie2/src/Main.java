import Enums.YearNumber;
import Exceptions.*;
import java.time.LocalDate;
import java.util.ArrayList;
import javax.swing.*;
import Enums.*;


public class Main {

    private static int[] monthList = {1,2,3,4,5,6,7,8,9,10,11,12};

    public static void main(String[] args) {
        LocalDate d1 = LocalDate.of(2001,3,17);



        JTextField yearField = new JTextField(5);
        JList<Integer> month = new JList<Integer>(monthList);
        JTextField dayField = new JTextField(5);

        Object[] birthDate = {
                "year", yearField,
                "month", monthField,
                "day",dayField
        };

        JPanel getBirthdate = new JPanel();
        getBirthdate.add(new JLabel("Day : "));
        getBirthdate.add(dayField);
        getBirthdate.add(new JLabel("Month : "));
        getBirthdate.add(monthField);
        getBirthdate.add(new JLabel("Year : "));
        getBirthdate.add(yearField);

        Student s1;
        ArrayList<Student> students = new ArrayList<>();
        while(JOptionPane.showConfirmDialog(null,"Desire-tu créer un étudiant ?") == 0){
            String firstname = demanderInfos("Quel est votre prénom : ");
            String lastname = demanderInfos("Quel est votre nom : ");
            Gender genre = demanderGenre();
            Section section = demanderSection();
            YearNumber studyYear = demanderAnnee();
            JOptionPane.showMessageDialog(null,getBirthdate,"title",JOptionPane.QUESTION_MESSAGE);
            int year = Integer.parseInt(yearField.getText());
            //int month = Integer.parseInt(monthField.getText());
            int day = Integer.parseInt(dayField.getText());
            //LocalDate birthdate = LocalDate.of(year,month,day);
            Student newStudent;
            try {
                newStudent = new Student(firstname,lastname,genre,d1,section,studyYear);
                students.add(newStudent);
                JOptionPane.showMessageDialog(null,newStudent,"Confirmation d'inscription",JOptionPane.PLAIN_MESSAGE);
            }
            catch(YearNumberException exception) {
                JOptionPane.showMessageDialog(null,exception, "Erreur d'année", JOptionPane.ERROR_MESSAGE);
            }catch(SectionException exception){
                JOptionPane.showMessageDialog(null,exception, "Erreur de section", JOptionPane.ERROR_MESSAGE);
            }catch(GenderException exception){
                JOptionPane.showMessageDialog(null,exception, "Erreur de genre", JOptionPane.ERROR_MESSAGE);
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

    private static Gender demanderGenre(){
        return (Gender) JOptionPane.showInputDialog(null,"Quel est votre genre : ","title",JOptionPane.QUESTION_MESSAGE,null, Gender.values(),Gender.W);
    }

    private static Section demanderSection(){
        return (Section) JOptionPane.showInputDialog(null,"Quel est votre section : ","title",JOptionPane.QUESTION_MESSAGE,null, Section.values(),Section.COMPTA);
    }

    private static YearNumber demanderAnnee(){
        return (YearNumber) JOptionPane.showInputDialog(null,"Quel est votre année d'étude : ","title",JOptionPane.QUESTION_MESSAGE,null, YearNumber.values(),YearNumber.ONE);
    }

}
