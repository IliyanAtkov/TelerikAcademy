// Write a script that finds the greatest of given 5 variables
var arr = [30, -150, 100, "da", 20];

var maxValue = arr[0];

for (var i = 0; i < arr.length; i++) {
    if (arr[i] > maxValue) {
        maxValue = arr[i];
    }
}

console.log(maxValue);