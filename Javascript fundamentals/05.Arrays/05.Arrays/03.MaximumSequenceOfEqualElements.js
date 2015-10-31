//Write a script that finds the maximal sequence of equal elements in an array.
//    Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

var arr = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1];
var maxSameElements = 0;
var currentSameElements = 1;
var currentElement = 0;
var number = 0;
var previousElement = arr[0];
for (var i = 1; i < arr.length; i++) {
    currentElement = arr[i];
    if (currentElement === previousElement) {    
        currentSameElements++;
    }
    else {
        previousElement = currentElement;
        if (currentSameElements > maxSameElements) {
            number = arr[i -1];
            maxSameElements = currentSameElements;
        }    
        currentSameElements = 1;
    }
}

console.log("Number " + number + " repeated " + maxSameElements);