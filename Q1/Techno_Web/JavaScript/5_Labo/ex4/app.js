const nbClicksRequis = 5;

function action () { 
    if(this.nbClicksRequis > 0){
        this.innerHTML = `Encore ${this.nbClicksRequis} clicks !`; 
        this.nbClicksRequis --;
    }else{
        this.innerHTML = `Merci !`;
    }  
} 

window.onload = function () 
{   
    for(let i = 0 ; i < 30 ; i ++){
        let copy = document.getElementById("but").cloneNode(true);
        copy.nbClicksRequis = nbClicksRequis;
        copy.onclick = action; 
        document.body.appendChild(copy);
    }
    document.getElementById("but").onclick = action; 
};