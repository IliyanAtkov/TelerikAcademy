// Write a function that returns the last digit of given integer as an English word.
// Examples: 512  "two", 1024  "four", 12309  "nine"

function getLastDigitOfNumber(number) {
    var lastDigit = number % 10;
    var digitAsWord;
    switch (lastDigit) {
        case 1: digitAsWord = "one"; break;
        case 2: digitAsWord = "two"; break;
        case 3: digitAsWord = "three"; break;
        case 4: digitAsWord = "four"; break;
        case 5: digitAsWord = "five"; break;
        case 6: digitAsWord = "six"; break;
        case 7: digitAsWord = "seven"; break;
        case 8: digitAsWord = "eight"; break;
        case 9: digitAsWord = "nine"; break;
        case 0: digitAsWord = "zero"; break;
        default: digitAsWord = "Not a number"; break;
    }
    
    return digitAsWord;
}

var number = 12309;
var result = getLastDigitOfNumber(number);
console.log(result);