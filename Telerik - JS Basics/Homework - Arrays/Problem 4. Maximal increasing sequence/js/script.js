var btn = document.getElementById('print-nums-button');

function findMaximalSequence(arr) {
    var maxSequenceArray,
        i,
        j,
        arrayLength,
        array,
        prop,
        tempSequenceArray;
    array = [];
    for (prop in arr) {
        array.push(parseInt(arr[prop]));
    }
    arrayLength = array.length;
    maxSequenceArray = [];
    tempSequenceArray = [];
    for (i = 0; i < arrayLength; i += 1) {
        var last = false;
        if (array[i] != (array[i + 1] - 1)) {
            last = true;
        }
        if ((array[i - 1]) === (array[i] - 1)) {
            tempSequenceArray.push(array[i - 1]);
            if (last) {
                tempSequenceArray.push(array[i]);
            }
        } else {
            tempSequenceArray = [];
        }
        if (maxSequenceArray.length <= tempSequenceArray.length) {

            maxSequenceArray = tempSequenceArray;
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
