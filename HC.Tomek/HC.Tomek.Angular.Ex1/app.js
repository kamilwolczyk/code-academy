import 'jquery';
import 'bootstrap';

$(document).ready(function(){
    var resultContainer=$('#result-container');
    var startButton=$('#start-button');
    startButton.tooltip();
    resultContainer.hide();
    $('#start-button').click(function(){
        startButton.hide();
        setTimeout(function(){
            resultContainer.html('Odmierzono 2 sekundy!').show('slow');
        },2000);
    });
});

$(document).ready(function(){
    alert('asd');
});