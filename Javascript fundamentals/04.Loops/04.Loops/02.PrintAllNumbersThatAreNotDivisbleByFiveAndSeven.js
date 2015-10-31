// Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time
var n = 50;

for (var i = 1; i <= n; i++) {
    if((i % 7 != 0) || (i % 3 != 0)){
        console.log(i);
    }
}