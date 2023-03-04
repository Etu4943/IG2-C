package Enums;

import javax.swing.*;
import java.util.ArrayList;

public enum Section {
    COMPTA("compta"),
    MARKET("market"),
    DROIT("droit"),
    INFO("info");

    private String name;

    public String getName() {
        return name;
    }

    Section(String name) {
        this.name = name;
    }

    public static ArrayList<String> toList(){
        ArrayList<String> list = new ArrayList<String>();
        for(Section value : values()){
            list.add(value.getName());
        }
        return list;
    }

    public static boolean contains(Section origin){
        for(Section value : values()){
            if(value == origin)
                return true;
        }
        return false;
    }

}
