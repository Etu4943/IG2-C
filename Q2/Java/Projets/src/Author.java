import java.util.ArrayList;

public class Author {
    private String nom;
    private String prenom;
    private ArrayList<Book> books;
    private static int maxSize = 10;
    private int totalPages;

    public Author(String nom, String prenom) {
        this.nom = nom;
        this.prenom = prenom;
        this.books = new ArrayList<Book>();
        totalPages = 0;
    }

    public void addBook(Book newBook){
        if(bookNb() < maxSize){
            books.add(newBook);
            totalPages += newBook.pagesCounting();
        }
    }

    public int countAllBooksPages(){
        int sum = 0;
        for(int i = 0 ; i < books.size() ; i ++){
            sum += books.get(i).pagesCounting();
        }
        return sum;
    }

    public int bookNb(){
        return books.size();
    }

    public String booksLIsting(){
        StringBuilder output= new StringBuilder();
        output.append("Listing des livres : \n");
        for(int i = 0 ; i < bookNb() ; i++){
            output.append("- ");
            output.append(books.get(i));
            output.append("\n");
        }
        return output.toString();
    }

}
