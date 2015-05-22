var btn = document.getElementById('print-nums-button');

function checkHowManyTimes(arr, digit) {
    var count = 0;
    for (var i = 0; i < arr.length; i++) {
        if(arr[i] === digit) {
            count++;
        }
    };
    return count;
}
btn.addEventListener('click', function () {
    var inputValue = document.getElementById('value').value;
	var givenDigit = document.getElementById('number').value;
	var resultArea = document.getElementById('result');
    var arrayOfDigits = inputValue.split(' ');
    var repeatedTimes = checkHowManyTimes(arrayOfDigits, givenDigit);
	result.innerHTML = "Digit " + givenDigit + " is repeated " + repeatedTimes + " times in the array " + arrayOfDigits;
})