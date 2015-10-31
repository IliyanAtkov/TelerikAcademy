// Write a function that returns the index of the first element in array that is bigger than its neighbors,
// or -1, if there’s no such element.
// Use the function from the previous exercise.
function firstElementThatIsBiggerThanTwoNeighbors(arr) {
    for (var i = 1; i < arr.length - 1; i++) {
        var result = biggerThanTwoNeighbors(arr, i);
        if (result > 0) {
            return result;
        }
    }

    return -1;
}

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
var result = firstElementThatIsBiggerThanTwoNeighbors(arr);
console.log(result);