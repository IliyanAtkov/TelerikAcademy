// Write a function that checks if a given object contains a given property
// var obj  = …;
// var hasProp = hasProperty(obj, 'length');

function hasProperty(obj, property) {
    for (var i in obj) {
        if (i === property) {
            return true;
        }
    }

    return false;
}

var obj = {
    name: 'az',
    speed: 15,
    length: 5,
    acceleration: 20
};

var result = hasProperty(obj, 'length');
console.log(result);