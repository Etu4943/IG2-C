public class City {
    private String name;
    private int inhabitantsNb;

    public City(String name, int inhabitantsNb){
        this.name = name;
        setInhabitantsNb(inhabitantsNb);
    }

    public void setInhabitantsNb(int inhabitantsNb){
        if(inhabitantsNb >= 0)
            this.inhabitantsNb = inhabitantsNb;
        else
            this.inhabitantsNb = 0;
    }

    public int getInhabitantsNb() {
        return inhabitantsNb;
    }
}
