// Sorting an array means to arrange its elements in increasing order. Write a script to sort an array.
// Use the "selection sort" algorithm: Find the smallest element, move it at the first position,
// find the smallest from the rest, move it at the second position, etc.Hint: Use a second array

function selectionSort(arr) {
    var iMin,
        tmp;

    for (var i = 0; i < arr.length - 1; i++) {
        iMin = i;
      
        for (var j = i + 1; j < arr.length; j++) {
            if (arr[j] < arr[iMin]) {
                iMin = j;
            }       
        }

        if (iMin !== i) {
            tmp = arr[i];
            arr[i] = arr[iMin];
            arr[iMin] = tmp;

        }
    }
    return arr;

}

var arr = [1, 66, 4, 2, 1232, 3, 6, 1, 18, 222, 2, 3, 1, 5, 2];

var sortedArr = selectionSort(arr);
console.log(sortedArr);