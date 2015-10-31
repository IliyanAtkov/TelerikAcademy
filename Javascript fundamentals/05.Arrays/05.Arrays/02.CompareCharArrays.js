// Write a script that compares two char arrays lexicographically (letter by letter).
var firstString = "adaneokdarazdakhiq";
var secondString = "adanefxajixakdadka";

var firstArray = firstString.split('');
var secondArray = secondString.split('');
var areEqual = false;
if (firstArray.length === secondArray.length) {
    for (var i = 0; i < firstArray.length; i++) {
        if (firstArray[i] == secondArray[i]) {
            areEqual = true;
            continue;
        }
        else if (firstArray[i] < secondArray[i]) {
            console.log("First array is lexicographically first");
            areEqual = false;
            break;
        }
        else {
            console.log("Second array is lexicographically first");
            areEqual = false;
            break;
        }
    }
    if (areEqual == true) {
        console.log("Both arrays are lexicographically equal");
    }
}
else {
    if (firstArray.length > secondArray.length) {
        console.log("Second array is lexicographically first");
    }
    else {
        console.log("First array is lexicographically first");
    }
}
