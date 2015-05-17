var btn = document.getElementById('show');
btn.addEventListener('click', function() {
    var firstVal = parseFloat(document.getElementById('first-val').value);
    var result = document.getElementById('result');
    switch (firstVal) {
        case 0:
            result.innerHTML = "zero";
            break;
        case 1:
            result.innerHTML = "one";
            break;
        case 2:
            result.innerHTML = "two";
            break;
        case 3:
            result.innerHTML = "three";
            break;
        case 4:
            result.innerHTML = "four";
            break;
        case 5:
            result.innerHTML = "five";
            break;
        case 6:
            result.innerHTML = "six";
            break;
        case 7:
            result.innerHTML = "seven";
            break;
        case 8:
            result.innerHTML = "eight";
            break;
        case 9:
            result.innerHTML = "nine";
            break;
    }
});
