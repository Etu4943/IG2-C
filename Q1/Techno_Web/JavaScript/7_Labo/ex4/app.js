window.onload = init;
let grandActuel = 0;

function init(){
    

}

function clic(numBloc){
    if(numBloc != grandActuel){
        for(let i = 0 ; i < 49 ; i ++){
            setTimeout(modWidth,10*i,grandActuel,500-(10*i));
            setTimeout(modWidth,10*i,numBloc,20+(10*i));
        }
        grandActuel = numBloc;
    }
}

function modWidth(numBloc,size){
    let bloc = document.querySelector("#bloc"+numBloc);
    bloc.style.width = `${size}px`;
}