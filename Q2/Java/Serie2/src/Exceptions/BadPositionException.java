package Exceptions;

public class BadPositionException extends Exception{
    private int wrongValue;
    private int activitiesNB;

    public BadPositionException(int wrongValue, int activitiesNB){
        setWrongValue(wrongValue);
        setActivitiesNB(activitiesNB);
    }

    public void setWrongValue(int wrongValue) {
        this.wrongValue = wrongValue;
    }

    public void setActivitiesNB(int activitiesNB) {
        this.activitiesNB = activitiesNB;
    }

    @Override
    public String toString() {
        if(wrongValue <= 0){
            StringBuilder output = new StringBuilder();
            output.append("Le numéro d'apprentissage ");
            output.append(wrongValue);
            output.append(" que vous avez proposé est <=0.");
            return output.toString();
        }
        else{
            StringBuilder output = new StringBuilder();
            output.append("L'étudiant n'a que ");
            output.append(activitiesNB);
            output.append(" activités dans son PAE. Le numéro ");
            output.append(wrongValue);
            output.append(" que vous avez proposé ne correspond donc pas à une activité d'apprentissage du PAE de cet étudiant.");
            return output.toString();
        }
    }
}
