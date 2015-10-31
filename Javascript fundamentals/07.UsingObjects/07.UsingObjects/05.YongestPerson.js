// Write a function that finds the youngest person in a given array of persons and prints his/hers full name
// Each person have properties firstname, lastname and age, as shown:
// var persons = [
//   { firstname : 'Gosho', lastname: 'Petrov', age: 32 }, 
//   { firstname : 'Bay', lastname: 'Ivan', age: 81},… ];

function findYoungestPerson(persons) {
    var biggestAge = 500;
    var person = {};
    for (var i = 0; i < persons.length; i++) {
        if (persons[i].age < biggestAge) {
            biggestAge = persons[i].age;
            person = persons[i];
        }
    }

    return person;
}

var Gosho = {
    firstname: 'Gosho',
    lastname: 'Petrov',
    age: 32
};

var Dragancho = {
    firstname: 'Dragancho',
    lastname: 'Draganchov',
    age: 5
};
var Slavcho = {
    firstname: 'Slavcho',
    lastname: 'Slavchov',
    age: 63
};
var Traichko = {
    firstname: 'Traichko',
    lastname: 'Traichkov',
    age: 61
};

var persons = [Gosho, Dragancho, Slavcho, Traichko];

var youngestPerson = findYoungestPerson(persons);
console.log(youngestPerson.firstname + " " + youngestPerson.lastname);