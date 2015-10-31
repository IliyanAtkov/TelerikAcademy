// Write a script that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
var arr = [3, 2, 3, 4, 2, 2, 4];

var previousElement = arr[0];
var currentElement = 0;
var maxSequence = 0;
var currentOrderElements = 1;
for (var i = 1; i < arr.length; i++) {
    currentElement = arr[i];
    if (currentElement > previousElement) {
        currentOrderElements++;
    }
    else {
        if (currentOrderElements > maxSequence) {
            number = i - currentOrderElements;
            maxSequence = currentOrderElements;
        }
        currentOrderElements = 1;
    }
    previousElement = currentElement;
}

console.log("Increasing sequence is : ");
while (maxSequence != 0) {
    console.log(arr[number]);
    number++;
    maxSequence--;
}