import Enums.AcademicDegree;

import java.io.*;

public class Main implements Serializable {
    public static void main(String[] args){

        SchoolYear y1 = new SchoolYear("Informatique de Gestion",2, AcademicDegree.BACHELOR);
        //Student s0 = new Student("Clément","Potier",y1);
        Student s0;
        Student s1 = new Student("Valentin","Doucet",y1);
        Student s2 = new Student("Baptist","Dahlarra",y1);
        Student s3 = new Student("Justin","Frémy",y1);
        Student s4 = new Student("Bastien","Delval",y1);
        Student s5 = new Student("Cyril","Baras",y1);
        Student s6 = new Student("DeBarbarossa","Diego",y1);
        Student s7 = new Student("Demaret","Antoine",y1);


        try(FileOutputStream fileOutput = new FileOutputStream("StudentListe");
            ObjectOutputStream output = new ObjectOutputStream(fileOutput)){
            output.writeObject(s1);
            output.writeObject(s2);
            output.writeObject(s3);
            output.writeObject(s4);
            output.writeObject(s5);
            output.writeObject(s6);
            output.writeObject(s7);
        }catch(IOException exception){
            System.out.println(exception);
        }

        /*

        try(FileInputStream fileInput = new FileInputStream("StudentListe");
            ObjectInputStream input = new ObjectInputStream(fileInput)){

            while(fileInput.available() > 0){
                s0 = (Student) input.readObject();
                System.out.println(s0);
            }
        }catch(IOException | ClassNotFoundException exception){
            System.out.println(exception);
        }
         */

        CommonZone zone = new CommonZone();

        Producer p1 = new Producer(zone);
        Consumer c1 = new Consumer(zone);

        p1.start();
        c1.start();


    }
}
