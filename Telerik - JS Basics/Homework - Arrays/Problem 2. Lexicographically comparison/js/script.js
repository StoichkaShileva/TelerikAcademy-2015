var btn = document.getElementById('print-nums-button');

function compare(array, array2) {
    var areEqual = true,
        i,
        lenFirst = array.length,
        lenSecond = array2.length,
        minLength = Math.min(lenFirst, lenSecond);
    for (i = 0; i < minLength; i += 1) {
        if (array[i] != array2[i]) {
            areEqual = false;
            break;
        }
    }
    return areEqual;
}
btn.addEventListener('click', function() {
    var resultArea = document.getElementById('result');
    var firstArray = ['a', 'a', 'a', 'b', 'c', 'c'];
    var secondArray = ['a', 'a', 'a', 'b', 'c', 'c'];
    var result = compare(firstArray, secondArray);
    resultArea.innerHTML += "First array = " + firstArray + "<br />";
    resultArea.innerHTML += "Second array = " + secondArray + "<br />";
    if (result) {
        resultArea.innerHTML += "Arrays are lexicographically equal";
    } else {
        resultArea.innerHTML += "Arrays are not lexicographically equal";
    }
})
