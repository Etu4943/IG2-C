import Exceptions.GenderException;

import java.time.LocalDate;
import java.time.Period;

public class Person {
    private String firstname;
    private String lastname;
    private char gender;
    private LocalDate birthdate;

    public Person(String firstname, String lastname, char gender, LocalDate birthdate) throws GenderException {
        this.firstname = firstname;
        this.lastname = lastname;
        setGender(gender);
        this.birthdate = birthdate;
    }

    public void setGender(char gender) throws GenderException{
        if(gender != 'm'&& gender != 'w' && gender != 'x') {
            throw new GenderException(gender, "Wrong value for gender");
        }
        this.gender = gender;
    }

    public String toString(){
        StringBuilder output = new StringBuilder();
        output.append(firstname);
        output.append(" ");
        output.append(lastname);
        output.append(" ( ");
        output.append(age());
        output.append(" ans)");

        return output.toString();
    }

    public String getLastname() {
        return lastname;
    }

    public String getFirstname() {
        return firstname;
    }

    public int age(){
        return Period.between(birthdate,LocalDate.now()).getYears();
    }
}
