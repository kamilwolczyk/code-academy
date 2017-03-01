var divek = document.getElementById("app")
for(var i = 1;i<11;i++){
    var pc = document.createElement("p")
    pc.innerHTML="Jest ok "+i;
    divek.appendChild(pc)
    
}

divek.style.display= "none"