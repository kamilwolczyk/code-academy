import 'jquery';
import 'bootstrap';

$(document).ready(function () {
  var resultContainer = $('#result-container');
  var button = $('#start-button');

  button.tooltip();
  resultContainer.hide();

  button.click(function () {
    setTimeout(function () {
      resultContainer.html('<p>Odliczono 2 sekundy !</p>').show('slow');
    }, 2000);
  });
});
