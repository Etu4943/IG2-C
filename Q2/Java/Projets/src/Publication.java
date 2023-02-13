import java.time.Year;

public class Publication {
    private String title;
    private Year editionYear;
    private Editor editor;

    public Publication(String title, int year, Editor editor){
        this.title = title;
        setYear(year);
        this.editor = editor;
    }

    public void setYear(int year){
        Year newYear = Year.of(year);
        if(newYear.isAfter(Year.now()))
            this.editionYear = Year.now();
        else
            this.editionYear = newYear;
    }

    public String typeMedia(){
        return "L'ouvrage";
    }

    public Editor getEditor() {
        return editor;
    }

    public String getTitle(){
        return this.title;
    }

    @Override
    public String toString(){
        StringBuilder output = new StringBuilder();
        output.append(typeMedia());
        output.append(" édité en ");
        output.append(editionYear.toString());
        output.append(" par ");
        output.append(editor);
        return output.toString();
    }
}
