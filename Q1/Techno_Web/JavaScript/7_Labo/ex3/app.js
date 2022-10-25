window.onload = init;

let value_path;
let CurrentValue;

function init(){
    value_path = document.getElementById("spanVal");
    CurrentValue = parseInt(value_path.innerText);
    majValeur(2);
    document.getElementById("bFact").addEventListener("click", calcFactorielle);
    document.getElementById("bRAZ").addEventListener("click", function (){majValeur(0)});
    document.getElementById("bDecremente10").onclick = calcAjoute(-10);
    document.getElementById("bDecremente1").onclick = calcAjoute(-1);
    document.getElementById("bIncremente1").onclick = calcAjoute(1);
    document.getElementById("bIncremente10").onclick = calcAjoute(10);
    document.getElementById("bMultiplie").onclick = calcMultiplie(2);
    document.getElementById("bDeux").onclick = effetBouttonFois(2);
    document.getElementById("bCinq").onclick = effetBouttonFois(5);
    document.getElementById("bDix").onclick = effetBouttonFois(10);
}

function majValeur(newValue){
    document.getElementById("spanVal").innerText = newValue;
    CurrentValue = parseInt(value_path.innerText);
}

function calcOpposé(){
    majValeur(CurrentValue *-1);
}

function calcCarre(){
    majValeur(CurrentValue * CurrentValue);
}

function calcFactorielle(){
    let resultat;
    if(CurrentValue >= 0)
        resultat = factorielle(CurrentValue);
    else
        resultat = -factorielle(Math.abs(CurrentValue));
    majValeur(resultat);
}

function factorielle(value){
    if(value == 1)
        return value;
    return value * factorielle(value-1);
}

function calcAjoute(value){
   return ( () => majValeur(CurrentValue + value));
}

function calcMultiplie(value){
    return (() => majValeur(CurrentValue * value))
}

function effetBouttonFois(value){
    return (() => {
        document.getElementById("bMultiplie").innerText = `x${value}`;
        document.getElementById("bMultiplie").onclick = calcMultiplie(value);
    });
}