window.onload = init;
let grandActuel = 0;

function init(){
    

}

function clic(numBloc){
    if(numBloc != grandActuel){
        let width_futur_grand = 30;
        let width_futur_petit = 490;
        while(width_futur_grand <= 500){
            width_futur_grand = setTimeout(modWidth, 1000, grandActuel,width_futur_petit);
            width_futur_petit = setTimeout(modWidth, 1000, numBloc,width_futur_grand);
        }
        grandActuel = numBloc;
    }
}

function modWidth(numBloc,size){
    let bloc = document.querySelector("#bloc"+numBloc);
    bloc.style.width = `${size}px`;
    return size + (numBloc == grandActuel ? -10 : 10);
}