$(document).ready(function () {

    $("div").click(function (event) {

        var selectedDiv = $(event.target);
        if (typeof (event.target.count) === 'undefined') {
            event.target.count = 1;
            selectedDiv.html(event.target.count);
            changeColour(selectedDiv);
        }
        else {
            event.target.count++;
            selectedDiv.html(event.target.count);
            changeColour(selectedDiv);
        }
    });

})

function changeColour(selectedDiv) {
    if (selectedDiv.hasClass("red-class") === false) {
        selectedDiv.addClass('red-class');
    }
    else {
        selectedDiv.removeClass('red-class');
    }
}
