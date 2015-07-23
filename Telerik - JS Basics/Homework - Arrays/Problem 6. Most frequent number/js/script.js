var btn = document.getElementById('print-nums-button');

function findFrequentNumber(arr) {
    var array,
        i,
        j,
        frequentNumber,
        repeatedTimes;
    array = arr.map(function(num) {
        return parseInt(num);
    });
    repeatedTimes = 0;
    for (i = 0; i < array.length; i += 1) {
        var currentNumber = array[i];
        var currentRepeatedTimes = 0;
        for (j = i; j < array.length; j += 1) {
            if (currentNumber === array[j]) {
                currentRepeatedTimes++;
            }
        }
        if (currentRepeatedTimes >= repeatedTimes) {
            repeatedTimes = currentRepeatedTimes;
            frequentNumber = array[i];
        }
    }
    return {
        "repeatedTimes": repeatedTimes,
        "number": frequentNumber
    };
}
btn.addEventListener('click', function() {
    var inputValue = document.getElementById('value').value;
    var resultArea = document.getElementById('result');
    var array = inputValue.split(' ');
    var result = findFrequentNumber(array);
    resultArea.innerHTML = "Most frequent number is: " + result.number + " (" + result.repeatedTimes + ")";
})
