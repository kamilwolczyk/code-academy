//to wyrażenie piszemy w każdym pliku który będzie używał zmiennej globalnej app
var app = app || {};

//komentarz do (function(){})(); znajdziesz w commandReader.js
(function() {

  function add(a, b) {
    return a + b;
  }

  function substract(a, b) {
    return a - b;
  }

  function multiply(a, b) {
    return a * b;
  }

  function divide(a, b) {
    return a / b;
  }

  //funkcja dostaje znak operatora np. '+' i zwraca metodę która będzie liczyć daną operację
  function getOperation(operator){
    switch(operator) {
      case '+': return add;
      case '-': return substract;
      case '*': return multiply;
      case '/': return divide;
    };
  }

  //kalkulator dostaje dane (dwie liczby i operator), pyta o metodę która policzy wynik i zwraca obliczoną wartość
  function calculate(data){
    var operation = getOperation(data.operator);

    if(operation === null || typeof(operation) !== 'function') {
      throw new Error('Operation for selected operator "' + data.operator + '"" has not been found');
    }

    return operation(data.firstNumber, data.secondNumber);
  }

  //udostępnienie na zewnątrz metody calculate(). Będzie dostępna bezpośrednio w obiekcie app pod nazwą calculator()
  app.calculator = calculate;

})();

