var app = app || {};

(function () {
    app.timeoutFunction = function timeoutFunction() {
        var time = setInterval(displayTime);
    }

    function displayTime() {
        var time = new Date();
        document.getElementById("top").innerHTML = time.toLocaleTimeString();
    }
})();


