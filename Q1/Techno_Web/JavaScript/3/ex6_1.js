function compteSupérieur(tab, reference){
    let nbNombresSuperieur = 0;
    for (nombre of tab){
        if (nombre >= reference)
            nbNombresSuperieur ++;
    }
    return nbNombresSuperieur;
}