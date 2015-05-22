var btn = document.getElementById('print-nums-button');

function checkIfNumIsBigger(arr, position) {
    var isBigger = false;
    position = position - '0';
    if (((position - 1) > 0) && ((position + 1) < arr.length)) {
        if (arr[position] > arr[position - 1] && arr[position] > arr[position + 1])
            isBigger = true;
    } else if (position - 1 <= 0) {
        if (arr[position] > arr[position + 1])
            isBigger = true;
    }
    else if (position + 1 >= arr.length) {
        if (arr[position] > arr[position - 1])
            isBigger = true;
    }

    return isBigger;
}
btn.addEventListener('click', function() {
    var inputValue = document.getElementById('value').value;
    var givenDigit = document.getElementById('number').value;
    var resultArea = document.getElementById('result');
    var arrayOfDigits = inputValue.split(' ');
    var isBigger = checkIfNumIsBigger(arrayOfDigits, givenDigit);
    result.innerHTML = "Number at position " + givenDigit + (isBigger ? " is bigger than its neighbours" : " is not bigger than its neighbours");
})
