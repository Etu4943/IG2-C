package Enums;

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

    public static boolean contains(String origin){
        for(Section value : values()){
            if(origin.equals(value.getName()))
                return true;
        }
        return false;
    }
}
