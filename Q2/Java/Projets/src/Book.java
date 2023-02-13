public class Book extends Publication implements Paging{
    private int tableOfContentPagesNb;
    private int prefacePagesNb;
    private int contentPagesNb;

    public Book(int tableOfContentPagesNb, int prefacePagesNb, int contentPagesNb, String title, int year, Editor editor){
        super(title, year,editor);
        this.tableOfContentPagesNb = tableOfContentPagesNb;
        setContentPagesNb(contentPagesNb);
        setPrefacePagesNb(prefacePagesNb);
    }

    public void setPrefacePagesNb(int prefacePagesNb){
        this.prefacePagesNb = prefacePagesNb < 0 ? 0 : prefacePagesNb;
    }

    public void setContentPagesNb(int contentPagesNb){
        this.contentPagesNb = contentPagesNb < 0 ? 0 : contentPagesNb;
    }

    public int pagesCounting(){
        return prefacePagesNb + contentPagesNb + tableOfContentPagesNb;
    }

    public String typeMedia(){
        return "Le livre";
    }

    public String toString(){
        StringBuilder output = new StringBuilder();
        output.append(super.toString());
        output.append(" compte ");
        output.append(pagesCounting());
        output.append(" pages et est intitulé ");
        output.append(getTitle());

        return output.toString();

    }
}
