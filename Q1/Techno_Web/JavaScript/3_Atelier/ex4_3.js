let tab = [9,3,4,15,4,9,16,2];

function somme(tab){
    let total = 0;
    for(let val of tab)
        total += val;
    return total;
}

function premierPair(tab){
    let i = 0;
    let valeur = tab[i];
    while(valeur%2 != 0){ // Le modulo renvoie un reste. On vérifie donc que la division par deux ne laisse rien pour déterminer un pair.
        i ++;
        valeur = tab[i];
    }
    return valeur;
}

function dernierPair(tab){
    let i = tab.length;
    let valeur = tab[i];
    while(valeur%2 != 0){ 
        i --;
        valeur = tab[i];
    }
    return valeur;
}

