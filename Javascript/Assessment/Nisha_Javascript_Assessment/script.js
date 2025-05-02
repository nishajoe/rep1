
var fName = document.getElementsByName("fname").value;
var lName = document.getElementsByName("lname").value;
var phn = document.getElementsByName("phno").value;
var eMail = document.getElementsByName("email").value;
var uName = document.getElementsByName("uname").value;
var pswd = document.getElementsByName("pswd").value;
var cPswd = document.getElementsByName("cpswd").value;


function numberCheck() {
    var regExp = /^(\([0-9]{3}\) |[0-9]{3}-)[0-9]{3}-[0-9]{4}/;
    if (!phn.match(regExp) || phn != 10) {
        alert("Please enter correct contact detail");
    }
}

function alphabetCheck() {
    var regAlpha = /^[A-Za-z]+$/;
    if (!fName.match(regAlpha) || !lName.match(regAlpha)) {
        alert("Please enter alphabets only");
    }
    return true;
}

function check() {
    if (uName.length < 8 || pswd.length < 8) {
        alert("Please enter 8 or more than 8 characters");
    }
    return true;
}

function valid() {
    if (!pswd.matchc(Pswd)) {
        alert("Password doesn't match");

    }
    return true;
}

function validate() {
    if (fName == " " || lName == " " || phn == " " || eMail == " " || uName == " " || pswd == " " || cPswd == " ") {
        alert("Enter every field");

    }

    alert("Successfull!");
    return true;
}


