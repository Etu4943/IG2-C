import java.io.FileInputStream;

public class Consumer extends Thread{
    private CommonZone commonZone;


    public Consumer(CommonZone commonZone){
        super("Consumer");
        this.commonZone = commonZone;
    }

    public void run(){
        Student student;
        synchronized (commonZone){
            while(! commonZone.isComplete()){
                try{
                    Thread.sleep((int)(Math.random() * 3000));
                    student = commonZone.getStudent();

                    if(student == null)
                        commonZone.wait();
                    else{
                        System.out.println("Le consumer à lu : " + student);
                        commonZone.setStudent(null);
                        commonZone.notify();
                    }
                }catch(InterruptedException exception){
                    System.out.println(exception);
                }
            }
        }
    }
}
