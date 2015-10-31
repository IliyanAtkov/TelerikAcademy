// Write a script that shows the sign (+ or -) of the product of three real numbers without calculating it.
// Use a sequence of if statements.

var firstNumber = 3;
var secondNumber = 500;
var thirdNumber = 1000;

var countMinusSign = 0;

if (firstNumber < 0) {
    countMinusSign++;
}
if (secondNumber < 0) {
    countMinusSign++;
}
if (thirdNumber < 0) {
    countMinusSign++;
}

if (countMinusSign % 2 === 0) {
    console.log("The sign of product is Plus(+)");
}
else {
    console.log("The sign of product is Minus(-)");
}