/////////////////////////
// Définition de fonction //
/////////////////////////
function citeNFois(mot, nbFois){
	if(!isFinite(nbFois) || nbFois < 0)
		console.log("Erreur, vous n'avez pas rentré un nombre positif");
	else{
		for(let i = 0 ; i < nbFois ; i++){
  	console.log(`${i+1}) ${mot}`);
 		} 
	}
}

////////////////
// Déclaration //
////////////////
let citeNFois = function (mot, nbFois){
	if(!isFinite(nbFois) || nbFois < 0)
		console.log("Erreur, vous n'avez pas rentré un nombre positif");
	else{
		for(let i = 0 ; i < nbFois ; i++){
  	console.log(`${i+1}) ${mot}`);
 		} 
	}
}

/////////////////////////
// Mode Orioenté Objet //
////////////////////////
const citeNFois = new Function ('mot', 'nbFois', 'if(!isFinite(nbFois) || nbFois < 0)console.log("Erreur, vous n\'avez pas rentré un nombre positif"); else{ for(let i = 0 ; i < nbFois ; i++){ console.log(`${i+1} ${mot}`);} }'); 