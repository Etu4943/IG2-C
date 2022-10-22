function Carre(couleur, cote, bordure, ecartGAuche, ecartHaut){
    this.couleur = couleur;
    this.cote = cote;
    this.bordure = bordure;
    this.ecartGAuche = ecartGAuche;
    this.ecartHaut = ecartHaut;
}

let carre1 = new Carre ("green", 50, 2, 100, 100);

Carre.prototype.toString = function toString(){
    return `carré ${this.couleur} de ${this.cote}px de coté`;
}

function affiche(){
    let carréHTML = `<div style="position:absolute; left:${this.ecartGAuche}px; top:${this.ecartHaut}px; width: ${this.cote}px; height: ${this.cote}px; border: ${this.bordure}px solid black; background-color: ${this.couleur}"></div>`;
    document.getElementById("cadre").innerHTML += carréHTML;
}

Object.assign(Carre.prototype, { affiche });

let carre2 = new Carre("blue", 100, 1, 150, 50);