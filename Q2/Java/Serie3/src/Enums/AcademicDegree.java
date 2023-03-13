package Enums;

public enum AcademicDegree {

    BACHELOR("bac"),
    MASTER("master");

    private String name;

    AcademicDegree(String degree){
        setName(degree);
    }

    public void setName(String degree){
        this.name = degree;
    }

    public String getName() {
        return name;
    }
}
