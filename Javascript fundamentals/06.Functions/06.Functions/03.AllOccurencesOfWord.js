// Write a function that finds all the occurrences of word in a text
// The search can case sensitive or case insensitive
// Use function overloading

function occurrencesOfWord(text, searchWord) {
    var textArr = text.split(" ");
    var count = 0;
    for (var i = 0; i < textArr.length; i++) {
        if (textArr[i] === searchWord) {
            count++;
        }
    }

    return count;
}

var text = 'This is text and the text is what exactly text is so writing a text is hard work thats why this text is so stupid';
var searchWord = "text";
var result = occurrencesOfWord(text, searchWord);
console.log("The word " + searchWord + " has " + result + " occurences");