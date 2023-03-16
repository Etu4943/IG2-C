import java.io.FileInputStream;
import java.io.IOException;
import java.io.ObjectInputStream;

public class Producer extends Thread{

    Student student;
    CommonZone commonZone;

    public Producer(CommonZone commonZone){
        super("Producer");
        this.commonZone = commonZone;
    }
    @Override
    public void run() {
        synchronized (commonZone){
            try(FileInputStream fileInput = new FileInputStream("StudentListe");
                ObjectInputStream input = new ObjectInputStream(fileInput)){

                while(fileInput.available() > 0){
                    Thread.sleep((int)(Math.random() * 3000)); // simule un accès aléatoire dans le temps à la zone commune
                    student = (Student)input.readObject();
                    commonZone.setStudent(student);
                    System.out.println("Le produceur écrit un student dans la common zone");
                    this.commonZone.notify();
                    this.commonZone.wait();
                }
                this.commonZone.complete();
                this.commonZone.notify();
            }catch(IOException | ClassNotFoundException | InterruptedException exception){

            }
        }

    }
}
