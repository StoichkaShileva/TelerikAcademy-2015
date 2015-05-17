var btn = document.getElementById('show');
btn.addEventListener('click', function() {
    var firstVal = parseFloat(document.getElementById('first-val').value);
    var secondVal = parseFloat(document.getElementById('second-val').value);
    var thirdVal = parseFloat(document.getElementById('third-val').value);
    var result = document.getElementById('result');

    if (firstVal >= secondVal && firstVal >= thirdVal) {
        result.innerHTML = firstVal;
    } else if (secondVal >= firstVal && secondVal >= thirdVal) {
        result.innerHTML = secondVal;
    } else if (thirdVal >= firstVal && thirdVal >= secondVal) {
        result.innerHTML = thirdVal;
    }
});
