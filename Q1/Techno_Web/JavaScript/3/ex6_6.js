function foisTrois (x) { return x * 3; }
let foisQuatre = function quadruple (x) { return x * 4; } 
let puissance2 = function (x) { return x * x; }

function beauRésultat(fonction, nombre){
    console.log(`Le ${fonction.résultat} de ${nombre} = ${fonction(nombre)}`);
}
beauRésultat(foisQuatre,7);