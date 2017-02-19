function getString(){
    var string = prompt("Wpisz wyrażenie, którą chcesz wykonać np. 2+2 [+, -, /, *]", "");
    return string;
}
function getNumbersAndOperatorFromString(string) {
     
    var data = {};
    // get numbers
    var numbersFromStringRegExp = /[-]{0,1}[\d.]*[\d]+/g;
    var numbersFromString = string.match(numbersFromStringRegExp);
    if (numbersFromString === null || numbersFromString.length == 1 || string.length >= (numbersFromString[0].length + numbersFromString[1].length) + 2)
        alert("Błędne wyrażenie");
    else
    var firstNumber = numbersFromString[0];
    var secondNumber = numbersFromString[1];

    // get operator
    var stringWithoutFirstNumber = string.substr(firstNumber.length);
    var firstNumber = parseFloat(firstNumber);
    var secondNumber = parseFloat(secondNumber);
    if (secondNumber < 0 && stringWithoutFirstNumber[0] == "-" && stringWithoutFirstNumber.length === 2) {
        var operator = "";
        var stringForAlert = firstNumber + "" + secondNumber + "=";
    }
    else {
        var operator = stringWithoutFirstNumber.substr(0, 1);
        var stringForAlert = firstNumber + operator + secondNumber + "=";
    }
        var data = { firstNumber: firstNumber, secondNumber: secondNumber, operator: operator, stringForAlert: stringForAlert };
        return data;
    }


function calculate(data) {
    switch (data.operator) {
        case "+":
            alert(data.stringForAlert + add(data.firstNumber, data.secondNumber));
            break;
        case "-":
            alert(data.stringForAlert + substract(data.firstNumber, data.secondNumber));
            break;
        case "*":
            alert(data.stringForAlert + multiply(data.firstNumber, data.secondNumber));
            break;
        case "/":
            alert(data.stringForAlert + divide(data.firstNumber, data.secondNumber));
            break;
        case "":
            alert(data.stringForAlert + add(data.firstNumber, data.secondNumber));
            break;
        default:
            alert("Błędne wyrażenie");
    }
}

function add(a, b) {
    return a + b
}

function substract(a, b) {
    return a - b;
}

function divide(a, b) {
    return a / b;
}

function multiply(a, b) {
    return a * b;
}

  