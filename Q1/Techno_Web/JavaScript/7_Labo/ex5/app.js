window.onload = init;
let table = [];
let nbLignes;
let nbColonnes;
let intervalId;

function init(){
    nbLignes = parseInt(prompt("Nombre de lignes demandés : "));
    nbColonnes = parseInt(prompt("Nombre de colonnes demandés : "));
    creationGrille(nbLignes,nbColonnes);
    document.getElementById("bAvancer").addEventListener("click", avancer);
    document.getElementById("bContinu").addEventListener("click",lancerInterval);
    document.getElementById("bStop").addEventListener("click", stopInterval);
    document.getElementById("bStop").disabled = true;
}

function creationGrille(nbLignes, nbColonnes){
    for(let iLigne = 0 ; iLigne < nbLignes ; iLigne ++){
        table.push([]);
        let newLigne = document.createElement("tr");
        for(let iColonne = 0 ; iColonne < nbColonnes ; iColonne ++){
            let newCase = document.createElement("td");
            newCase.addEventListener("click", clic);
            newLigne.appendChild(newCase);
            table[iLigne].push(newCase);
        }
        document.getElementById("plateau").appendChild(newLigne);

    }
}

function clic(){
    this.classList.toggle("vivant");
}

function lancerInterval(){
    let stopButton = document.getElementById("bStop");
    stopButton.disabled = false;
    intervalId = setInterval(avancer,500);
}

function stopInterval(){
    let stopButton = document.getElementById("bStop");
    stopButton.disabled = true;
    clearInterval(intervalId);
}

function avancer(){
    let cellulesAModifier = [];
    for(let ligne of table){
        for(let elem of ligne){
            let estEnVie = elem.classList.contains("vivant");
            let nbVivantsAutour = nbSiblingsVivants(table.indexOf(ligne),ligne.indexOf(elem));
            if(( doitMourir(nbVivantsAutour) && estEnVie) || (doitNaitre(nbVivantsAutour) && !estEnVie))
                cellulesAModifier.push(elem)
        }
    }
    cellulesAModifier.map(x => modificationStatus(x));
}

function modificationStatus(elem){
    elem.classList.toggle("vivant");
}

function doitNaitre(nbVivantsAutour){
    return nbVivantsAutour ==3;
}

function doitMourir(nbVivantsAutour){
    return nbVivantsAutour < 2 || nbVivantsAutour > 3;
}

function nbSiblingsVivants(iLigne, iColonne){
    let somme = 0;
    let sigblings = [];
    sigblings.push([iLigne-1, iColonne-1]);
    sigblings.push([iLigne-1, iColonne]);
    sigblings.push([iLigne-1, iColonne+1]);
    sigblings.push([iLigne, iColonne-1]);
    sigblings.push([iLigne, iColonne+1]);
    sigblings.push([iLigne+1, iColonne-1]);
    sigblings.push([iLigne+1, iColonne]);
    sigblings.push([iLigne+1, iColonne+1]);
    let sibligsValides = sigblings.filter(x => (x[0] >= 0 && x[0] < nbLignes) && (x[1] >= 0 && x[1] < nbColonnes));
    for(let coordonees of sibligsValides){
        somme += estVivant(coordonees[0],coordonees[1]);
    }
    return somme;
}

function estVivant(iLigne,iColonne){
    return table[iLigne][iColonne].classList.contains("vivant");
}