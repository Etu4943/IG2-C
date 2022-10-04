function afficherLangage(langage){
    console.log(`${langage.nom} (${("année" in langage && isFinite(langage)) ? "vu en IG" + langage.année : "pas vu en IG"}) : ${langage.oo ? "orienté objet" : "pas oriente objet"}`);
}