// Write a script that converts a number in the range [0...999] to a text corresponding to its English pronunciation. Examples:
// 0  'Zero'
// 273  'Two hundred seventy three'
// 400  'Four hundred'
// 501  'Five hundred and one'
// 711  'Seven hundred and eleven'


function onChange() {
    var input = document.getElementById("input").value;
    console.log(input);
    var result = "";
    if (input.length === 1) {
        result += getNumbersFromZeroToNine(input[0]);
    }
    else if (input.length === 2) {
        result += getNumbersWithLengthTwoOrThree(input[0], input[1]);
    }
    else if (input.length === 3) {
        result += getNumbersFromZeroToNine(input[0]);
        result += " ";
        result += "hundred ";
        if (input[1] === "0" || input[1] === "1") {
            if (input[1] != "0" || input[2] != "0") {
                result += "and ";
            }      
        }
        
            result += getNumbersWithLengthTwoOrThree(input[1], input[2]);
        }

    console.log(result);
}

function getNumbersFromZeroToNine(input) {
    var result = "";
    switch (input) {
        case "1": result += "one"; break;
        case "2": result += "two"; break;
        case "3": result += "three"; break;
        case "4": result += "four"; break;
        case "5": result += "five"; break;
        case "6": result += "six"; break;
        case "7": result += "seven"; break;
        case "8": result += "eight"; break;
        case "9": result += "nine"; break;
        case "0": result += "zero"; break;   
    }
    return result;
}

function getNumbersFromTenToNineteen(input) {
    var result = "";
    switch(input) {
        case "1": result += "eleven"; break;
        case "2": result += "twelve"; break;
        case "3": result += "thirteen"; break;
        case "4": result += "fourteen"; break;
        case "5": result += "fiftheen"; break;
        case "6": result += "sixteen"; break;
        case "7": result += "seventeen"; break;
        case "8": result += "eighteen"; break;
        case "9": result += "nineteen"; break;
        case "0": result += "ten"; break;
    }
    return result;
}

function getNumbersWithLengthTwoOrThree(firstNumber, secondNumber)
{
    var result = "";
    switch (firstNumber) {
        
        case "1": result += getNumbersFromTenToNineteen(secondNumber); break;
        case "2": result += "twenty "; break;
        case "3": result += "thirty "; break;
        case "4": result += "fourty "; break;
        case "5": result += "fifty "; break;
        case "6": result += "sixty "; break;
        case "7": result += "seventy "; break;
        case "8": result += "eigthty "; break;
        case "9": result += "ninety "; break;
    }

    if (firstNumber != "1") {
        result += getNumbersFromZeroToNine(secondNumber);
        if (result[result.length - 2] === "r") {
            result = result.replace("zero", "");
        }
    }
    return result;
}