var btn = document.getElementById('print-nums-button');

function findMaximalSequence(array) {
    var maxSequenceArray,
        i,
        j,
        arrayLength;
    arrayLength = array.length;
    maxSequenceArray = [];
    for (i = 0; i < arrayLength; i += 1) {
        var tempSequence = [];
        for (j = i; j < arrayLength; j += 1) {
            if (array[i] === array[j]) {
                tempSequence.push(array[j]);
            } else {
                break;
            }
        }
        if (maxSequenceArray.length <= tempSequence.length) {
            maxSequenceArray = tempSequence;
        }
    }
    return maxSequenceArray;
}
btn.addEventListener('click', function() {
    var inputValue = document.getElementById('value').value;
    var resultArea = document.getElementById('result');
    var array = inputValue.split(' ');
    var result = findMaximalSequence(array);
    resultArea.innerHTML = "Maximal sequence is: " + result;
})
