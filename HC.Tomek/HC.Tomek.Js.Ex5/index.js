$(document).ready(function(){
    $("div.colour").click(function (event) {
        var div = $(event.target);

        if (div.hasClass("thickborder")) {
            div.removeClass("thickborder")
            
        }
        else {
            $("div.colour").removeClass("thickborder");
            div.addClass("thickborder");
            var fetchedColour = $("div.thickborder").attr("class");
            fetchedColour=fetchedColour.replace("colour", "");
            fetchedColour = fetchedColour.replace("thickborder", "");
            $("div.result").removeClass().addClass("result");
            $("div.result").addClass(fetchedColour);
            $("div.resultText").text("You chose " + fetchedColour);
        }


    })
});