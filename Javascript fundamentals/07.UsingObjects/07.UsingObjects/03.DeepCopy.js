// Write a function that makes a deep copy of an object
// The function should work for both primitive and reference types

function deepCopy(obj) {
    return JSON.parse(JSON.stringify(obj));
}
var arr = [1, 2, 3];
var object = {
    array: arr,
};

var newCopyiedObject = deepCopy(object);
newCopyiedObject.array = [5, 6, 7];
object.array = [2, 3, 1];
console.log(newCopyiedObject.array);
console.log(object.array);
console.log("Both arrays are different so deep copy is done");