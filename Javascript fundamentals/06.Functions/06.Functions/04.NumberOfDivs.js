// Write a function to count the number of divs on the web page
function countDivs() {
    var result = document.getElementsByTagName("div");
    console.log(result.length + " divs");
}