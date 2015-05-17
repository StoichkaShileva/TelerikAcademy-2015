var btn = document.getElementById('show');
btn.addEventListener('click', function() {
    var firstVal = parseFloat(document.getElementById('first-val').value);
    var secondVal = parseFloat(document.getElementById('second-val').value);
    var thirdVal = parseFloat(document.getElementById('third-val').value);
    var result = document.getElementById('result');
    if (firstVal >= secondVal && firstVal >= thirdVal) {
        result.innerHTML = "";
        result.innerHTML += firstVal + " ";
        if (secondVal >= thirdVal) {
            result.innerHTML += secondVal + " ";
            result.innerHTML += thirdVal + " ";
        }
        else {
            result.innerHTML += thirdVal + " ";
             result.innerHTML += secondVal + " ";
        }
    }
    else if (secondVal >= firstVal && secondVal >= thirdVal) {
        result.innerHTML = "";
        result.innerHTML += secondVal + " ";
        if (firstVal >= thirdVal) {
            result.innerHTML += firstVal + " ";
            result.innerHTML += thirdVal + " ";
        }
        else {
            result.innerHTML += thirdVal + " ";
            result.innerHTML += firstVal + " ";
        }
    }
    else if (thirdVal >= firstVal && thirdVal >= secondVal) {
        result.innerHTML = "";
        result.innerHTML += thirdVal + " ";
        if (secondVal >= firstVal) {
            result.innerHTML += secondVal + " ";
            result.innerHTML += firstVal + " ";
        }
        else {
            result.innerHTML += firstVal + " ";
            result.innerHTML += secondVal + " ";
        }
    }
});
