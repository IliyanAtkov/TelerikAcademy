// Write a script that finds the biggest of three integers using nested if statements.

var firstNumber = 5;
var secondNumber = 1000;
var thirdNumber = 3;

if (firstNumber > secondNumber) {
    if (firstNumber > thirdNumber)
    {
        console.log("FirstNumber is biggest");
    }
    else {
        console.log("ThirdNumber is biggest");
    }
}
else if (secondNumber > firstNumber) {
    if (secondNumber > thirdNumber) {
        console.log("SecondNumber is biggest");
    }
    else
    {
        console.log("ThirdNumber is biggest");
    }
}
else if (thirdNumber > firstNumber) {
    if (thirdNumber > secondNumber)  {
        console.log("ThirdNumber is biggest");
    }
    else {
        console.log("SecondNumber is biggest");
    }
}
else {
    console.log("Some of the numbers are equal");
}