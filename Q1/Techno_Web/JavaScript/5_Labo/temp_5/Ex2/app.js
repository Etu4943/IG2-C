let li1 = document.getElementById("li1");
function creatpasswd(){
    let table = ["a","A","b","B","c","C","d","D","e","E","f","F","g","G","h","H","i","I","j","J","k","K","l","L","m","M","n","N","o","O","p","P","q","Q","r","R","s","S","t",'T',"u","U","v","V","w","W","x","X","y","Y","z","Z",1,2,3,4,5,6,7,8,9,0];
    let passwd = "";
    for(let index = 0; index < 15; index ++){
        let random = Math.floor(Math.random()*table.length);
        passwd += table[random];
    }
    console.log(passwd);
}