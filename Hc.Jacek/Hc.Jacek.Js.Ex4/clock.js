console.log(1);
setTimeout(function() {
   console.log(2) 
}, 0);

for(var i = 0 ; i<100;i++){
console.log(".")
}
console.log(4)
my(oooo)
logger(oooo)

function oooo (){
    console.log("sex")
}

function my (dupa){
    console.log(dupa)
}

function logger(dupa){
console.log("loggeer")
dupa()
}

function strzel (x, gdykoniec){
setTimeout(function() {
    gdykoniec()
}, 100);
}