let diviseurs = [];
function initialisationDiviseur(){
    let iCase = 0;
    for(let i = 1 ; i <= 12 ; i ++){
        if(12%i == 0){
            diviseurs[iCase] = i;
            iCase ++
        }
    }
}