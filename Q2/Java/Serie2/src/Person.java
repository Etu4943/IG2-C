import Exceptions.GenderException;

import java.time.LocalDate;
import java.time.Period;
import Enums.*;

public class Person {
    private String firstname;
    private String lastname;
    private Gender gender;
    private LocalDate birthdate;

    public Person(String firstname, String lastname, Gender gender, LocalDate birthdate) throws GenderException {
        this.firstname = firstname;
        this.lastname = lastname;
        setGender(gender);
        this.birthdate = birthdate;
    }

    public void setGender(Gender gender) throws GenderException{
        if(!Enums.Gender.contains(gender)) {
            throw new GenderException(gender.getGender(), "Wrong value for gender");
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
