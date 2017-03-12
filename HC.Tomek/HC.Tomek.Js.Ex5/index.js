$(document).ready(function(){
    $("div").click(function (event) {
        var div = $(event.target);

        if (div.hasClass("red-div")) {
            div.addClass("blue-div");
            div.removeClass("red-div");
        }
        else {
            div.addClass("red-div");
            div.removeClass("blue-div");
        }
    })
});