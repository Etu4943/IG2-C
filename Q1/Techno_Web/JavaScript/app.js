function prixReduit (prix, reductionPourCents = 10) { 
    //reductionPourCents = reductionPourCents ?? 10 ; 
    let rabais = prix * reductionPourCents / 100; 
    return (prix - rabais);
}