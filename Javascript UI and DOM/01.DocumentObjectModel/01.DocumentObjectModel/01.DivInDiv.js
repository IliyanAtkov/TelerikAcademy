// Write a script that selects all the div nodes that are directly inside other div elements
// Create a function using querySelectorAll()
// Create a function using getElementsByTagName()


function GetAllDivsWithGetElementByTagName() {
    var divs = document.getElementsByTagName("div");
    for (var i = 0, len = divs.length; i < len; i++) {
        if (divs[i].parentNode.nodeName === "DIV") {
            console.log(divs[i]);
        }
    }
    return divs;
}

function GetAllDivsWithQuerySelectorAll() {
    var divs = document.querySelectorAll("div>div");
    for (var i = 0, len = divs.length; i < len; i++) {
        console.log(divs[i]);
    }
    return divs;
}
