var colorPickerControler = colorPickerControler || {};

(function () {

    var colors = ["red", "white", "blue", "black","yellow","green"];

    for (var i = 0; i < colors.length; i++) {
        $('<div/>', {
            id: colors[i],
            style: "background-color: " + colors[i]
        }).addClass("colorPickerElement notSelected").appendTo('#pickersContainer');
    }

    $("#pickersContainer").on("click", "div.colorPickerElement", function () {
        $("#selectedColor").css("background-color", this.id);
        $("#selectedColorText").text("Selected color: " + this.id);

        $("div.colorPickerElement").removeClass("selected");
        $(this).removeClass("notSelected");

        $("div.colorPickerElement").not(this).addClass('notSelected');
        $(this).addClass("selected");
    });

})();


