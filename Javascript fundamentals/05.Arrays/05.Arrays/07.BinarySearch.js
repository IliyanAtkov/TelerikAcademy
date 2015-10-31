// Write a program that finds the index of given element in a sorted array of integers by using the binary search
// algorithm (find it in Wikipedia).

function binarySearch(arr, value){
    var low = 0;
    var high = arr.length - 1;
    var midPoint = 0;

    while (low <= high) {
        midPoint = Math.floor(low + (high - low) / 2);
        if (value === arr[midPoint]) {
            return midPoint;
        }
        else if (value < arr[midPoint]) {
            high = midPoint - 1;
        }
        else {
            low = midPoint + 1;
        }
    }

    return -1;
}

var arr = [1, 3, 15, 2, 100, 40, 50, 12, 35, 68, 2, 183, 1000, 94];
var sortedArr = arr.sort(function (a, b) { return a - b; });
var searchingNumber = 15;
var result = binarySearch(sortedArr, searchingNumber);
if (result !== -1) {
    console.log("Searching number " + searchingNumber + " " + "is found in index " + result);
}
else {
    console.log("Searching number does not exists");
}
