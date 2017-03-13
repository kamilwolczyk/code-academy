$(document).ready(function () {

    $("div").click(function (event) {
        var colorPicker = event.target
        var selectedColor = $("#color");
        var selectedColorText = $("span");
        selectedColor.removeClass();
        selectedColorText.empty();
        switch (colorPicker.className) {
            case "d1 box":
                selectedColor.addClass("d1");
                selectedColorText.append("czerwony");
                break;
            case "d2 box":
                selectedColor.addClass("d2");
                selectedColorText.append("zielony");
                break;
            case "d3 box":
                selectedColor.addClass("d3");
                selectedColorText.append("niebieski");
                break;
            case "d4 box":
                selectedColor.addClass("d4");
                selectedColorText.append("czarny");
                break;
            case "d5 box":
                selectedColor.addClass("d5");
                selectedColorText.append("różowy");
                break;
            case "d6 box":
                selectedColor.addClass("d6");
                selectedColorText.append("szary");
                break;
            case "d7 box":
                selectedColor.addClass("d7");
                selectedColorText.append("malinowy");
                break;
            case "d8 box":
                selectedColor.addClass("d8");
                selectedColorText.append("pomarańczowy");
                break;
            default: break;
        }
    });
})