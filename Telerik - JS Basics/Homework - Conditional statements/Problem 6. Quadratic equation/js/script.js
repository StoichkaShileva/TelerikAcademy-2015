var btn = document.getElementById('show');
btn.addEventListener('click', function() {
    var a = parseFloat(document.getElementById('first-val').value);
    var b = parseFloat(document.getElementById('second-val').value);
    var c = parseFloat(document.getElementById('third-val').value);
    var result = document.getElementById('result');
    var discriminative = (b * b) - (4 * a * c);
    if (discriminative === 0) {
        var rootX = (b * -1) / (2 * a);
        result.innerHTML = "x = " + rootX;
    } else if (discriminative < 0) {
        result.innerHTML = "No real roots";
    } else {
        var firstX = ((b * -1) - Math.sqrt(discriminative)) / (2 * a);
        var secondX = ((b * -1) + Math.sqrt(discriminative)) / (2 * a);
        result.innerHTML = "x = " + firstX + " x1 = " + secondX;
    }
});
