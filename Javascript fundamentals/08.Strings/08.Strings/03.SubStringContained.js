// Write a JavaScript function that finds how many
// times a substring is contained in a given text
// (perform case insensitive search).
//     Example: The target substring is "in". The text is as
//     follows:
// We are living in an yellow submarine. We don't
//     have anything else. Inside the submarine is very
//     tight. So we are drinking all the day. We will
//     move out of it in 5 days.
//         The result is: 9.
//    function howManyTimesSubStringIsContained(text, subString) {
    var count = 0;
    text = text.toLowerCase();
    subString = subString.toLowerCase();
    for (var i = 0; i < text.length; i += subString.length - 1) {
        var currentSubString = text.substr(i, subString.length);
        if (currentSubString === subString) {
            count++;
        }
    }

    return count;
}
var text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
var subString = "in";
var result = howManyTimesSubStringIsContained(text, subString);
console.log(result);