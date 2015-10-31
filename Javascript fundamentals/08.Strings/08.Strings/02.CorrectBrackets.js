// 2. Write a JavaScript function to check if in a given
// expression the brackets are put correctly.
// Example of correct expression: ((a+b)/5-d).
// Example of incorrect expression: )(a+b)).function areBracketsCorrect(exp) {
    var count = 0;
    var leftBracket = 0;
    var rightBracket = 0;
    for (var i = 0; i < exp.length; i++) {
        if (exp[i] === "(") {
            count++;
            leftBracket++;
            if (leftBracket < rightBracket) {
                return false;
            }
        }
        else if (exp[i] === ")") {
            count--;
            rightBracket++;
            if (leftBracket < rightBracket) {
                return false;
            }
        }
    }

    if (count === 0) {
        return true;
    }
    else {
        return false;
    }
}

var expression = "(1 + 3) / (2 * 5)";
var result = areBracketsCorrect(expression);
console.log(result);