var btn = document.getElementById('print-nums-button');

function allocateArray(numberOfIntegers) {
    var arr,
        i,
        len;
    arr = new Array(numberOfIntegers);
    for (i = 0, len = arr.length; i < len; i += 1) {
        arr[i] = i * 5;
    }
    return arr;
}
btn.addEventListener('click', function() {
    var resultArea,
        array,
        integers = 20;
    resultArea = document.getElementById('result');
    array = allocateArray(integers);
    resultArea.innerHTML = array;
});
