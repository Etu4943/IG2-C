
let peintures = [
    ["escaliers.jpg", "Maison aux escaliers", "Escher"],
    ["frappis.jpg", "", "Frappis"],
    ["radeau.jpg", "Radeau de la Méduse", "Géricault"],
    ["joconde.png", "Joconde revisitée"],
    ["fleurs.jpg"],
    ["pipe.jpg", "La trahison des images", "Magritte"],
    ["persistence.jpg", "The Persistence of Memory", "Dali"]
];

   
function creePeinture(src, titre, auteur){
    let element =  document.createElement("img");
    element.className = "peinture";
    element.src = "peintures/"+src;
    element.dataset.info = `${ titre || auteur ? `"${titre}" par ${auteur}` : "aucune information"}`;
    //console.log(element.dataset.info);
    element.addEventListener("mouseover",setComment);
    return element;
}

function setComment(element){
    let info = element.srcElement.dataset.info;
    document.getElementById("pcommentaire").innerHTML = `Commentaire : ${info}`;
}

window.onload = function () {
    let cadre = document.getElementById("peintures");
     for (let peinture of peintures) {
        let elem = creePeinture(...peinture);
        cadre.appendChild(elem);
     }
};
    