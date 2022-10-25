function app2 (f, x) { 
    return f(f(x)); 
}

function plus2(valeur){
    return valeur + 2;
}

function plus3(valeur){
    return valeur + 3;
}

function fois3(valeur){
    return valeur * 3;
}

function cube(valeur){
    return valeur * valeur;
}

function afficherNFois(chaine, nbFois = 3){
    for(let i = 0 ; i < nbFois ; i++)
        console.log(chaine);
}

function message() { 
    console.log("Ceci est un message !"); 
}

function executeNFois(f, n=3){
    for(let i = 0 ; i < n ; i ++)
        f();
}

function appn(f, nbFois, valeur){
    if(nbFois == 1)
        return f(valeur);
    
    return f(appn(f,nbFois-1,valeur));
}