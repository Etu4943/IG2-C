let li = document.body.children[1].children[0];
let ul = li.parentNode;

function affiche(element){
    console.log(`
    ELEMENT : ${element.localName.toUpperCase()} (${element.children['length']} children et ${element.childNodes.length} childNodes)\n
    \tChilnodes : ${loop_childNodes(element.childNodes)}
    `);

    for(let child of element.children){
        affiche(child);
    }
}


function loop_childNodes(childNodes){
    let phrase = "";
    for(let element of childNodes)
        phrase += element.nodeName + " ";
    return phrase;

}

function changeColorEmphaseLi(){
    let element = document.getElementsByTagName("li");
    for(let child of element){
        for(let child_element of child.children){
            if(child_element.nodeName === "EM")
                child_element.style.color = "blue";
        }
    }
}