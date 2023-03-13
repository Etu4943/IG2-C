import Enums.AcademicDegree;

import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.io.Serializable;

public class Main implements Serializable {
    public static void main(String[] args){
        SchoolYear y1 = new SchoolYear("Informatique de Gestion",2, AcademicDegree.BACHELOR);
        Student s0 = new Student("Clément","Potier",y1);
        Student s1 = new Student("Valentin","Doucet",y1);
        Student s2 = new Student("Baptist","Dahlarra",y1);
        Student s3 = new Student("Justin","Frémy",y1);
        Student s4 = new Student("Bastien","Delval",y1);
        Student s5 = new Student("Cyril","Baras",y1);
        Student s6 = new Student("DeBarbarossa","Diego",y1);
        Student s7 = new Student("Demaret","Antoine",y1);

        try(FileWriter fileOutput = new FileWriter("listStudents",false); PrintWriter output = new PrintWriter(fileOutput)){
            output.println(s0);
            output.println(s1);
            output.println(s2);
            output.println(s3);
            output.println(s4);
            output.println(s5);
            output.println(s6);
            output.println(s7);
        }catch(IOException exception){

        }
    }
}
