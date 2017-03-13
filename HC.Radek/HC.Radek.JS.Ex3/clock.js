var myClock = myClock || {};

(function (){

    var clock = document.getElementById("clock");
    var active = true;

    var setClock = function () {

        setInterval(function () {
            clock.innerHTML = new Date();
        },1000);
    }

    
    myClock.startView = setClock;


})();
