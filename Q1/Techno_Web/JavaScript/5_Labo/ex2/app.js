let cadre;

window.onload = function () {
    cadre = document.getElementById("sagas");

    ajouteSaga(
        "Baldur's Gate",
        "Baldur's Gate I (1998)",
        "Baldur's Gate: Tales of the Sword Coast (1999)",
        "Baldur's Gate II: Shadows of Amn (2000)",
        "Baldur's Gate II: Throne of Bhaal (2001)",
        "Baldur's Gate: Enhanced Edition (2012)",
        "Baldur's Gate II: Enhanced Edition (2013)",
        "Baldur's Gate: Enhanced Edition - Siege of Dragonspear (2016)"
    );
    ajouteSaga(
        "Icewind Dales",
        "Icewind Dales (2000)",
        "Icewind Dales II (2002)",
        "Icewind Dales: Enhanced Edition (2014)"
    );
    ajouteSaga(
        "Neverwinter Nights",
        "Neverwinter Nights (2002)",
        "Neverwinter Nights: Shadows of Undrentide (2003)",
        "Neverwinter Nights: Hordes of the Underdark (2003)",
        "Neverwinter Nights 2 (2006)",
        "Neverwinter Nights 2: Mask of the Betrayer (2007)",
        "Neverwinter Nights 2: Storm of Zehir (2008)",
        "Neverwinter Nights 2: Mysteries of Westgate (2009)"
    );
    ajouteSaga(
        "Dragon Age",
        "Dragon Age: Origins (2009)",
        "Dragon Age II (2011)",
        "Dragon Age: Inquisition (2014)"
    );
    ajouteSaga(
        "Mass Effect",
        "Mass Effect (2007)",
        "Mass Effect 2 (2010)",
        "Mass Effect 3 (2012)",
        "Mass Effect: Andromeda (2017)"
    );
    ajouteSaga(
        "Fallout",
        "Fallout (1997)",
        "Fallout 2 (1998)",
        "Fallout Tactics (2001)",
        "Fallout: Brotherhood of Steel (2004)",
        "Fallout 3 (2008)",
        "Fallout: New Vegas (2010)",
        "Fallout 4 (2015)"
    );
};

function ajouteSaga(titre, ...episodes){
    let titre_saga = document.createElement("h2");
    titre_saga.innerText = titre;
    cadre.appendChild(titre_saga);

    let liste = document.createElement("ul");
    let item_liste;

    for(volet in episodes){
        item_liste = document.createElement("li");
        item_liste.innerText = episodes[volet];
        liste.appendChild(item_liste);
    }
    cadre.appendChild(liste);
}