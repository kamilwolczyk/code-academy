$(document).ready(function () {
    //$.ajax({
    //    url: "Ajax/HelloWorld",
    //    success: function (result) {
    //        alert(result);
    //    }
    //})
    $.getJSON("HelloWorld", function (result) {
        alert(result.FirstName+" "+result.Surname);
    });
})

