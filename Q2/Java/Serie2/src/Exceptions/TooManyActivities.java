package Exceptions;

public class TooManyActivities extends Exception{
    public String toString(){
        return "Le nombre maximum d’activités d’apprentissage permis est déjà atteint !";
    }
}
