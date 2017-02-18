
//app to zwykła zmienna. Dzięki temu nie będziemy dopisywać metod bezpośrednio do obiektu
//window tylko do obiektu app (on będzie przypisany bezpośrednio do window)
//zapis app || {} oznacza wyrażenie - jeżeli app jest nullem to przypisz pusty obiekt {}
//jeżeli zaś jest juz wcześniej zdefiniowane, dopisuj do tego obiektu kolejne metody
var app = app || {};

app.start = function() {
  //metoda reader ma za zadanie pobrać od użytkownika obiekt będący danymi do liczenia:
  //zwraca obiekt posiadający 3 elementy: firstNumber, secondNumber i operator
  //jako parametr dostaje wyświetlony tekst i tablicę zawierająca możliwe operatory
  //dodatkowo element ten będzie walidował czy liczby są poprawne
  var data = app.reader('Wprowadz wyrażenie np. 2+5', ['+', '-', '*', '/']);

  //kalkulator dostaje poprzednio zwrócony obiekt, wybiera należytą funkcję do liczenia
  //i wykonuje obliczenie
  var result = app.calculator(data);

  //ostatnia operacja to wyświetlenie wyniku
  alert('Wynik to ' + result);
};

app.start();


//komentarz dodatkowy:
//jeżeli odpowiednio umieścimy znaczniki <script>, tak że app.js będzie na końcu, to będziemy mieli wszystkie 
//zarejestrowane wcześniej komponenty tj. calculator i commandReader
//w obiekcie window będziemy mieli obiekt app który będzie miał przypisane 3 metody:
//
//   window
//       --- app
//            ----- reader()
//            ----- calculate()
//            ----- start()
//
//jak nie zachowamy odpowiednej kolejności w index.html to nie będzie zarejestrowanych odpowiednich metod