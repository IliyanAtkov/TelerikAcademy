// Sort 3 real values in descending order using nested if statements.

var firstNumber = 1;
var secondNumber = 30;
var thirdNumber = 5;

if (firstNumber > secondNumber) {
    if (firstNumber > thirdNumber) {
        if(secondNumber > thirdNumber) {
            console.log(firstNumber + " " + secondNumber + " " + thirdNumber);
        }
        else {
            console.log(firstNumber + " " + thirdNumber + " " + secondNumber);
        }
    }
    else {
        console.log(thirdNumber + " " + firstNumber + " " + secondNumber);
    }
}
else if (secondNumber > thirdNumber) {
    if (firstNumber > thirdNumber) {
        console.log(secondNumber + " " + firstNumber + " " + thirdNumber);
    }
    else {
        console.log(secondNumber + " " + thirdNumber + " " + firstNumber);
    }
}
else {
    console.log(thirdNumber + " " + secondNumber + " " + firstNumber);
}