window.onload = init;
let grandActuel = 0;

function init(){
    

}

function clic(numBloc){
    if(numBloc != grandActuel){
        let width_futur_grand = 30;
        let width_futur_petit = 490;
        loop(width_futur_grand,width_futur_petit,numBloc);
    }
}

function loop(width_futur_grand,width_futur_petit,numBloc){
    setTimeout(() => {
        if(width_futur_grand <= 500){
            modWidth(grandActuel,width_futur_petit);
            modWidth(numBloc,width_futur_grand);
            width_futur_grand += 10;
            width_futur_petit -= 10;
            loop(width_futur_grand,width_futur_petit,numBloc);
        } else
            grandActuel = numBloc;
    },100);
}

function modWidth(numBloc,size){
    let bloc = document.querySelector("#bloc"+numBloc);
    bloc.style.width = `${size}px`;
}