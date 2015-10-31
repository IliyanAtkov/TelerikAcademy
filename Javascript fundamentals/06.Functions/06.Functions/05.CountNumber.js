// Write a function that counts how many times given number appears in given array.
// Write a test function to check if the function is working correctly.

function countNumberAppears(arr, number) {
    var count = 0;
    for (var i = 0; i < arr.length; i++) {
        if (arr[i] === number) {
            count++;
        }
    }

    return count;
}
function testCountNumberAppears() {
    var arr = [1, 5, 6, 1, 1, 5, 6, 1214, 23, 321, 23, 6, 1, 5];
    
    console.log("Should return 1  4 times, 1214 1 time, 5 3 time");
    var res = countNumberAppears(arr, 1);
    console.log("1 " + res + " times");
    res = countNumberAppears(arr, 1214);
    console.log("1214 " + res + " times");
    res = countNumberAppears(arr, 5);
    console.log("5 " + res + " times");
}

testCountNumberAppears();

