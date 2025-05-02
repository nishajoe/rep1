var content = document.getElementById("display");

function append(input) {
    content.value += input;
}

function clearDisplay() {
    content.value = '';
}

function calculate() {
    content.value = eval(content.value);
}