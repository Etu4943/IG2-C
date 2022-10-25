window.onload = init;




function init(){
    let currentValue;
    majValeur(2);

}

function majValeur(newValue){
    document.getElementById("spanVal").innerText = newValue;
}

function calcOpposé(){
    let value = parseInt(document.getElementById("spanVal").innerText);
    let resultat = value *-1;
    console.log(resultat);
    majValeur(resultat);
}