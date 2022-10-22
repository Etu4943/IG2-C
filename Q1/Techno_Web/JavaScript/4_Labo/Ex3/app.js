//let nombre = 3.1415;
let chaine = "Bonjour !";

let autreNombre = 7;
let autreChaine = "oui";

let protoNombre = Object.getPrototypeOf(nombre);

let protoString = Object.getPrototypeOf(chaîne);

let porteBonheurChinois = new Number (8);

let nombre = 4;
Number.prototype.afficheEtoiles = function (){
    let ligne = "";
    for(let i = 0 ; i < this ; i ++){
        ligne += "*";
    }
    console.log(ligne);
};

String.prototype.begaie = function(){
    let phrase = "";
    for(let element of this){
        for(let iElement = 0 ; iElement < 2 ; iElement ++){
            phrase += element;
        }
    }
    console.log(phrase);
}

// La fonction nomfonction attend nbArguments argument(s).

Function.prototype.presente = function(){
    console.log(`La fonction ${this.name} attend ${this.length} arguments`);
}

function introduce(prenom){
    console.log(`Dites bonjours à ${prenom}`);
}

Array.prototype.somme = function(){
    let somme = 0;
    for(let element of this){
        somme += typeof(element) === 'number' ? element : 0;
    }
    console.log(somme);
}

let tableau = [1,4,6,4,"Clement", 5];

Array.prototype.ajouteSiPasPresent = function(element){
    if(!this.includes(element))
        this.push(element);
    console.log(`Resultat : ${this}`);
}
