/**
 * JB's homework 2017-02-15
 */
var equation = prompt("sex")
equation = equation.replace(/\s/, "")
var first, second, opXY;

if (/\d+\D\d+/.test(equation)) {
	first = getFirstOp()
	second = getSecondOp()
	opXY = getOP()
	alert (first+" "+opXY+" "+second +" = "+ compute(first, opXY, second))
} else {
	alert("poprawna forma x o y gdzie o - jednoznakowy operator")

}

function getFirstOp() {
	return Number(/\d+/.exec(equation))
}

function getSecondOp() {
	return Number(/\d+$/.exec(equation))
}

function getOP() {
	return String(/\D/.exec(equation))
}

function compute(numX, op, numY) {
	switch (op) {
		case "+":
			return numX + numY ;
			break;
		case "-":
			return numX - numY;
			break;
		case "/":
			return numX / numY;
			break;
		case "*":
			return numX * numY;
			break;
	}
}
