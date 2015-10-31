// Write a function that checks if the element at given position in given array of integers is bigger
// than its two neighbors (when such exist).
function biggerThanTwoNeighbors(arr, position) {
    if (position < 0 || position >= arr.length) {
        return -1;
    }
   else if (position + 1 < arr.length && position - 1 >= 0) {
        var leftElement = arr[position - 1];
        var rightElement = arr[position + 1];
        if (arr[position] > leftElement && arr[position] > rightElement) {
            return position;
        }
        else {
            return -2;
        }
    }
   return -1;
}

var arr = [1, 1, 2, 155, 4, 7, 1, 76, 18];
var result = biggerThanTwoNeighbors(arr, 3);
if (result > 0) {
    console.log("The element at position " + result + " is bigger than it's two neighbors");
}
else if (result === -1) {
    console.log("No two neighbours or invalid position");
}
else {
    console.log("The element is smaller than it's two neighbors");
}