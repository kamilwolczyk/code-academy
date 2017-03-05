function refreshTime() {
    var container = document.getElementById("clock");
    var clock = document.createElement("label");
    container.appendChild(clock);

    setInterval(function () {
        var date = new Date();
        var time = date.toLocaleTimeString();
        clock.innerHTML = time;
    }, 200);
}
refreshTime();

