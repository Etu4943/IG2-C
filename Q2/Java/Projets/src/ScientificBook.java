import java.util.ArrayList;

public class ScientificBook extends Book{
    private int appendicPagesNb;
    private static ArrayList<ScientificBook> instancesList = new ArrayList<ScientificBook>();

    public ScientificBook(int appendicPagesNb, int tableOfContentPagesNb, int prefacePagesNb, int contentPagesNb, String title, int year, Editor editor){
        super(tableOfContentPagesNb,prefacePagesNb,contentPagesNb,title,year,editor);
        this.appendicPagesNb = appendicPagesNb;
        instancesList.add(this);
    }

    public void setAppendicPagesNb(int appendicPagesNb){
        this.appendicPagesNb = appendicPagesNb > 0 ? appendicPagesNb : 0;
    }

    public int pagesCounting(){
        return super.pagesCounting() + appendicPagesNb;
    }

    public String typeMedia(){
        return "L'ouvrage scientifique";
    }

    public static ArrayList<ScientificBook> getInstancesList() {
        return instancesList;
    }

    public static int getScientificBooksNb(){
        return instancesList.size();
    }
}
