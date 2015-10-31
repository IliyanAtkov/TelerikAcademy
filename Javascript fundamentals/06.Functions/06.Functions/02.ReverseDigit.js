// Write a function that reverses the digits of given decimal number. Example: 256  652
function reverseNumber(number)
{
    var numberAsArray = number.toString(10).split("").map(Number);
    var reversedNumberAsArray = numberAsArray.reverse();
    var result = "";
    for (var i = 0; i < reversedNumberAsArray.length; i++) {
        result = result + "" + reversedNumberAsArray[i];
    }
    return result * 1;
}

var number = 256;
var result = reverseNumber(number);
console.log(result);