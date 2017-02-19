// JavaScript source code
function calculations()

{
    if (document.mathKW2.calculation_type.value == "+") {
        result = parseInr(x) + parseInr(y)
        
        alert("Result: " + result)
    }

    else if (document.mathKW2.calculation_type.value == "-") {
        result = parseInr(x) - parseInr(y)
        
        alert("Result: " + result)
    }

    else if (document.mathKW2.calculation_type.value == "*") {
        result = parseInr(x) * parseInr(y)
        
        alert("Result: " + result)
    }

    else if (document.mathKW2.calculation_type.value == "/") {
        result = parseInr(x) / parseInr(y)
        
        alert("Result: " + result)
    }



}