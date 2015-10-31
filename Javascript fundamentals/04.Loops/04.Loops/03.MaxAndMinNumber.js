// Write a script that finds the max and min number from a sequence of numbers

var arr = [5, 6, 15, 3, 10, 3, 155, 8];

arr = arr.sort(function (a, b) { return a - b; });
console.log("Smallest number " + arr[0]);
console.log("Biggest number " + arr[arr.length - 1]);