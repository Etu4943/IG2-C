import java.util.ArrayList;

public class Main {
    public static void main(String[] args) {

        City c1 = new City("Genval",500);
        Editor e1 = new Editor("Potier",c1);
        Editor e2 = new Editor("Dulac",c1);
        ScientificBook scienceBook = new ScientificBook(10,3,2,120,"Les revues du monde",2002,e1);
        ScientificBook s2 = new ScientificBook(10,3,2,120,"Les revues du monde",2002,e1);

        Author a1 = new Author("Radian","Paula");
        Book b1 = new Book(3,1,89,"La plus haute feuille de l'arbre",2008, e2);

        /*System.out.println(scienceBook);
        System.out.println(scienceBook.getEditor().getName());
        System.out.println(scienceBook.getEditor().getCity().getInhabitantsNb());
        */

        a1.addBook(scienceBook);
        a1.addBook(b1);

        System.out.println(a1.booksLIsting());
        System.out.println("Nombres de pages totales : " + a1.countAllBooksPages());
        scienceBook.setPrefacePagesNb(3);
        System.out.println("Nombres de pages totales : " + a1.countAllBooksPages());
        System.out.println("Nombres de pages totales sciences : " + scienceBook.pagesCounting());

        System.out.println(ScientificBook.getScientificBooksNb());
        System.out.println(pagesScienceBookAverage());
    }

    public static float pagesScienceBookAverage(){
        // 2 solutions :
        //      - Retenir des infos en statiques dans SciencesBook (tableau des instances, ou directements un tableau de pagesCounting)
        //      - Remplir un tableau dans le main avec toutes lies instances de SciencesBook

        // Solution retenue :
        //      Enregistré un tableau d'instance static dans la classe ScienceBook
        //      Problèmes potentiels :
        //          Je pars du principe que toute instance est de toute façon crée dans le main, mais si ce n'est pas le cas, ma structure ne fonctionne plus.
        ArrayList<ScientificBook> instanceListe = ScientificBook.getInstancesList();
        int sum = 0;
        for(int i = 0 ; i < instanceListe.size() ; i ++){
            sum += instanceListe.get(i).pagesCounting();
        }
        return (float)sum / instanceListe.size();
    }
}
