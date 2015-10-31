// Crеate a function that gets the value of <input type="color"> and sets the background of the body to this value
function changeColor() {
    var element = document.getElementById("input").value;
    console.log(element)
    document.body.style.backgroundColor = element;
}