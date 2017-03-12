var clock = clock || {};

console.log("pocztek");
clock(showClock);
console.log("koniec");

var still = false;

function clock(callback) {
    setInterval(callback, 500)
}

function showClock() {
    if (still) {
        document.getElementById("app").innerHTML = new Date().toLocaleString();
    }
}

function startStop() {
    if (still) {
        still = !still;
        document.getElementById("but").innerHTML = "STOP"
        console.log(still);
    } else {
        still = !still;
        document.getElementById("but").innerHTML = "START"
        console.log(still);

    }
}

clock.startStop = startStop;
