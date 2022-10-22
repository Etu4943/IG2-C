
let cadreHTML = document.getElementById("cadre");

let p1 ={
    texte : "Quelle prétention de prétendre que l’informatique est récente : Adam et Ève avaient déjà un Apple !",
    auteur : "Anonyme",
    couleur : "purple",
    gras : true
}

let p2 = {
    texte : "Cookie : anciennement petit gâteau sucré qu’on acceptait avec plaisir. Aujourd’hui : petit fichier informatique drôlement salé qu’il faut refuser avec véhémence.",
    auteur : "Luc Fayard",
    couleur : "darkgreen",
    gras : false
}

let protoPara = {}; 

protoPara.toString = function () {
    return this.texte + " (" + this.auteur + ")";
}

Object.setPrototypeOf(p1, protoPara);
Object.setPrototypeOf(p2, protoPara);

protoPara.affiche = function(){
    let phrase = `<p ${setStyle(this.couleur, this.gras)}>`;
    phrase += `${this.texte} </br>---<em>${this.auteur}</em></p>`;
    cadreHTML.innerHTML += phrase;
    console.log(phrase);
}

function setStyle(couleur, estEnGras){
    return `style = "color: ${couleur}; font-weight: ${estEnGras ? "bold" : ""};"`;
}


/*ETAPE 5 */

const p3 = Object.create(protoPara);

p3.texte = "Y’a rien de plus con qu’un ordinateur.";
p3.auteur = "Louis Schuffenecker";
p3.couleur = "blue";
p3.gras = "true";

let propriétésP4 = {
    texte: "On voit bien que tu n’as pas rencontré certains de mes étudiants, Louis !", 
    auteur: "enseignant anonyme", 
    couleur: "olive", 
    gras: false
};

let p4 = Object.create(protoPara);

Object.assign(p4,propriétésP4);
