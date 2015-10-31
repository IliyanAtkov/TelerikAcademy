// 01. Write an expression that checks if given integer is odd or even.

 var number = 5;
 if (number % 2 === 0) {
 	console.log("Number is odd");
 }
 else {
 	console.log("Number is even");
 }



// 02. Write a boolean expression that checks for given integer if it can be divided (without remainder)
// by 7 and 5 in the same time.

// var number = 35;
// 
// if (number % 5 === 0 && number % 7 === 0) {
// 	console.log("Number can be divided by 7 and 5 in the same time");
// }
// else {
// 	console.log("number cannot be divided by 7 and 5 in the same time");
// }



// 03. Write an expression that calculates rectangle’s area by given width and height

// var width = 30;
// var height = 60;
// 
// var area = width * height;
// console.log(area);



// 04. Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

// var number = 1732;
// var result = Math.floor((number / 100) % 10);
// if (result === 7) {
// 	console.log("Third digit from right to left is 7");
// }
// else {
// 	console.log("Third digit from right to left is not seven");
// }


// 05. Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

// var number = 50;
// number = number.toString(2);
// var mask = 1;
// mask = mask << 3;
// var result = mask & number;
// result = result >> 3;
// if (result === 1) {
// 	console.log("The third bit is 1");
// }
// else {
// 	console.log("The third bit is 0");
// }


// 06. Write an expression that checks if given print (x,  y) is within a circle K(O, 5).

// var x = 5;
// var y = 4;
// var radius = 5;
// if ((x * x + y * y) < radius * radius) {
// 	console.log("The given point (" + x + "," + y + ") is within the circle.");
// }
// else {
// 	console.log("The given point (" + x + "," + y + ") is OUTSIDE thr circle!");
// }



// 07. Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

// function isPrime(n)
// {
// 	for (var i = 2; i <= Math.sqrt(n); i++) {
// 		if (n % i === 0) {
// 			return false;
// 		}
// 		else {
// 			return true;
// 		}
// 	}
// }
// var n = 37;
// if (isPrime(n)) {
// 	console.log("Number is prime");
// }
// else {
// 	console.log("Number is not prime");
// }



// 8. Write an expression that calculates trapezoid's area by given sides a and b and height h.

// var a = 5;
// var b = 10;
// var heigth = 25;
// var area = ((a + b) / 2) * heigth;
// console.log(area);



// 9.Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3)
// and out of the rectangle R(top=1, left=-1, width=6, height=2).

// var x = 3;
// var y = 5;
// var result = (((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 9) && ((x < -1) || ((x >= -1) && ((y <= -1) || (y >= 1))));
// if (result === true) {
// 	console.log("The coordinates (" + x + ", " + y + ") are inside the circle and out of the rectangular: TRUE");
// }
// else {
// 	console.log("The coordinates (" + x + ", " + y + ") are inside the circle and out of the rectangular: FALSE");
// }