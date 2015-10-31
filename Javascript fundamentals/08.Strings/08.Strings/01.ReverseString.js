// Write a JavaScript function reverses string and returns it
// Example: "sample"  "elpmas"

function reverseString(string) {
    var stringAsArray = string.split('');
    var reversedArray = stringAsArray.reverse();
    var result = "";
    for (var i = 0; i < reversedArray.length; i++) {
        result += reversedArray[i];
    }

    return result;
}

var text = "sample";
var result = reverseString(text);
console.log(result);