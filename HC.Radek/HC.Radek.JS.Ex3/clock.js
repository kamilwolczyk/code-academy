var myClock = myClock || {};

(function (){

    var clock = document.getElementById("clock");
    var active = true;

    var setClock = function () {
        setTimeout(function () {
           clock.innerHTML = new Date();
           setClock();
        }, 1000);
    }

    
    myClock.startView = setClock;


})();
