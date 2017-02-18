//to wyrażenie piszemy w każdym pliku który będzie używał zmiennej globalnej app
var app = app || {};

//troche dziwny zapis (function(){})(); ale to nic innego jak hak na stworzenie zakresu, w którym
//tworzone zmienne nie będą globalne. Można zrobić test że nie będzie dostępu do tych metod spoza zakresu
(function(){

  //funkcja do dzielenia wyrażenia. Dostaje tekst np. '12+3' i zwraca podzielone dane
  function excludeDataFromString(string, availableOperators) {
    for(var i=0; i<availableOperators.length; i++) {
      var operator = availableOperators[i];
      var operatorPosition = string.indexOf(operator);
      
      if(operatorPosition < 0)
        continue;

      return {
        firstNumber: string.substr(0, operatorPosition),
        operator: string.substr(operatorPosition, operator.length),
        secondNumber: string.substr(operatorPosition + operator.length)
      }
    }

    throw new Error('Operator not found in text '+ string);
  }

  function parseAndValidate(number) {
    if(isNaN(number))
      throw new Error('Value "' + number + '" is not a number');      

    return parseFloat(number);
  }

  //funkcja nadrzędna który po kolei wywołuje odpowiednie metody: pobrania danych, walidacji i zwraca dane
  function getExpressionData(text, availableOperators) {
      while(true) {
        try {
          var expression = prompt(text);
          var data = excludeDataFromString(expression, availableOperators);

          data.firstNumber = parseAndValidate(data.firstNumber);
          data.secondNumber = parseAndValidate(data.secondNumber);
          
          return data;
        }
        catch(error) {
          alert(error.message)
        }
      }
  }

  //tylko jedna funkcja ma być dostępna poza zakresem, dlatego tylko tą funkcje przypisujemy do zmiennej reader która będzie 
  //dostępna w obiekcie app (do którego mamy dostęp w każdym pliku)
  app.reader = getExpressionData;

})();