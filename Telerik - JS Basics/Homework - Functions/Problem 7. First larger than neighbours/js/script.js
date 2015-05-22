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
function findFirstBigger (arr) {
    var position = -1;
    for (var i = 0; i < arr.length; i++) {
        if(checkIfNumIsBigger(arr, i)) {
            position = i;
            break;
        }
    };
    return position;
}
btn.addEventListener('click', function() {
    var inputValue = document.getElementById('value').value;
    var resultArea = document.getElementById('result');
    var arrayOfDigits = inputValue.split(' ');
    var position = findFirstBigger(arrayOfDigits);
    result.innerHTML = "Position: " + position;
})
