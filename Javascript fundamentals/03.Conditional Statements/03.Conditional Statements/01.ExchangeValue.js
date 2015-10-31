// Write an if statement that examines two integer variables and exchanges
// their values if the first one is greater than the second one.

var firstNumber = 10;
var secondNumber = 3;
var biggerNumber = 0;
if (firstNumber > secondNumber) {
	console.log("First number is bigger than second done exchange of values");
	biggerNumber = firstNumber;
	firstNumber = secondNumber;
	secondNumber = biggerNumber;
}
