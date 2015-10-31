// Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects
var sortedNavigator = Object.keys(navigator).sort();
console.log("Smallest navigator property " + sortedNavigator[0]);
console.log("Biggest navigator property " + sortedNavigator[sortedNavigator.length - 1]);
var sortedDocument = Object.keys(document).sort();
console.log("Smallest document property " + sortedDocument[0]);
console.log("Biggest document property " + sortedDocument[sortedDocument.length - 1]);
var sortedWindow = Object.keys(window).sort();
console.log("Smallest window property " + sortedWindow[0]);
console.log("Biggest window property " + sortedWindow[sortedWindow.length - 1]);
