public class CommonZone {
    private Student student;
    private boolean isComplete;

    public Student getStudent() {
        return student;
    }

    public void setStudent(Student student) {
        this.student = student;
    }

    public void complete(){
        this.isComplete = true;
    }

    public boolean isComplete() {
        return isComplete;
    }

}
