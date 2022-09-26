
let nombreObtenu = Number(prompt("Donnez un nombre : "));

while(!isFinite(nombreObtenu)){
    nombreObtenu = Number(prompt("Donnez un nombre : "));
}

function affichageNombreObtenu(){
    document.write("<p class='nombre'>" + nombreObtenu + "</p>");
}
function tableMutliplication(){
    for(let iAge = 1 ; iAge <=10 ; iAge ++){
        document.write(`<tr><td>${nombreObtenu}</td> <td>${iAge}</td> <td>${nombreObtenu * iAge}</td></tr>`);
    }
}



