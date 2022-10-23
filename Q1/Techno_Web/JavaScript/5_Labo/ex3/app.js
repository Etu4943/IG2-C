
let listeElem = document.getElementsByClassName("elem");
for(let element of listeElem){
    element.dataset.list = element.parentNode.id;
    element.addEventListener("click", changeList);
}

function changeList(){
    let newElem = this.cloneNode(true);
    newElem.dataset.list = this.dataset.list == "liste1" ? "liste2" : "liste1";
    newElem.addEventListener("click", changeList);
    let newList = document.getElementById(newElem.dataset.list);
    newList.appendChild(newElem);
    this.remove();
}


