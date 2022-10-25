function coteEnPourcents(cote, max = 20){
    console.log(((cote/max)*100).toFixed(0) + "%");
}

function prixTVAC(prix, tva=21){
    let total = prix + prix*(tva/100);
    console.log(total);
}

const min = (...tab) => tab = tab.flatMap(x => x).sort(compareNumbers).shift(); ;

function compareNumbers(a, b) {
    return a - b;
}
  


function somme(f, ...tab){
    let somme = 0;
    if(f instanceof Function){
        tab = tab.map(f);
    }else
        somme = f;

    for(let elem of tab)
        somme += elem;
    
    return somme;
}

function carre(x) { 
    return x*x; 
}

// classList ! , map c'est pour appliquer une fonction aux élément (pas pour passer dssus !);