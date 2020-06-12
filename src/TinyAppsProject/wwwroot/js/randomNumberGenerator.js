var button = document.getElementById("generate");
var minimum = 1;
var maximum = 1000;
button.onclick = function generate() {
    
    var randomNum = Math.floor(Math.random() * (maximum - minimum + 1)) + minimum;
    var el = document.getElementById('ranNum');
    el.innerHTML = randomNum;
}

