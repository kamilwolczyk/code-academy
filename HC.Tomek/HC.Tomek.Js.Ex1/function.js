function add(a,b) {
    return a + b;
}

function subtract(a,b) {
    return a - b;
}

function multiply(a, b) {
    return a * b;
}

function divide(a, b) {
    return a / b;
}

function operation(a, b, c) {
    switch (b) {
        case 1:
            return add(a, c)
            break;
        case 2:
            return subtract(a, c)
            break;
        case 3:
            return multiply(a, c)
            break;
        case 4:
            return divide(a, c)
            break;
    }
}