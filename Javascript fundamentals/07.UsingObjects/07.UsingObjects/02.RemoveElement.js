﻿//Write a function that removes all elements with a given value
// var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];
// arr.remove(1); //arr = [2,4,3,4,111,3,2,'1'];
//Attach it to the array type
//Read about prototype and how to attach methods

Array.prototype.remove = function (element) {
    var newArr = [];
    var count = 0;
    for (var i = 0; i < this.length; i++) {
        if(this[i] === element)
        {
            continue;
        }
        else {
            newArr[count] = this[i];
        }
        count++;
    }
    return newArr;
}

var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];

var arrayAfterRemovedElement = arr.remove(1);
console.log(arrayAfterRemovedElement);