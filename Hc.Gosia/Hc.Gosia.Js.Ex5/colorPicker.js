$(document).ready(function () {

    $("div").click(function (event) {
        var colorPicker = event.target;
        var selectedColor = $("#color");
        var selectedColorText = $("span");
        selectedColor.removeClass();
        selectedColorText.empty();
        selectedColor.addClass(colorPicker.className);
        var color = $(event.target).attr("title");
        selectedColorText.append(color);
    });
})