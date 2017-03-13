$(document).ready(function () {
    
    $("div").click(function () {
        if ($(this).css("background-color") == "rgb(17, 255, 17)") {
            $(this).css("background-color", "transparent");
        } else {
            $(this).css("background-color", "#11ff11");
        }
        var myDiv = this;
        if (myDiv.counter == undefined) {
            myDiv.counter = 0;
        } else {
            myDiv.counter++;
        }
        
        $(this).text(myDiv.counter);
        
        //index.extra.html
        //Po prawej div z kolorkiem
        //po lewej dużo kwadracików z kolorkami (9)
        //klikamy kwadracik i duży się zamienia kalor
        //pod spodem pojawia się "Wybrałeś kolor: #ffffff"
        //mały kwadracik dostaje border
        
        //$("div.okienko").css("background-color", "#55ff55");
    });

});
