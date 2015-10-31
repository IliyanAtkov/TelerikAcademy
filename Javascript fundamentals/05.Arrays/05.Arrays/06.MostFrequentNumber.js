// Write a program that finds the most frequent number in an array. Example:
// {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

var arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];
var countArr = [];

for (var i = 0; i < arr.length; i++) {
    if (countArr[arr[i]] === undefined) {
        countArr[arr[i]] = 1;
    }
    else {
        countArr[arr[i]]++;
    }
        
}
var biggestElement = -Infinity;
var biggestNumber = -Infinity;
for (var i = 1; i < countArr.length; i++) {
    if (biggestElement < countArr[i] && countArr[i] !== undefined) {
        biggestElement = countArr[i];
        biggestNumber = i;
    }
}

console.log(biggestNumber + "  " + biggestElement + " times");