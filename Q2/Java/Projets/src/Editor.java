public class Editor {
    private String name;
    private City city;

    public Editor(String nom, City city){
        this.name = nom;
        this.city = city;
    }

    public String toString(){
        StringBuilder output = new StringBuilder();
        output.append("les éditions ");
        output.append(name);
        return output.toString();
    }

    public String getName() {
        return name;
    }

    public City getCity() {
        return city;
    }
}
