var btn = document.getElementById('print-nums-button');

function selectionSort(arr) {
    var array,
        i,
        j;
    array = arr.map(function(num) {
        return parseInt(num);
    });
    for (i = 0; i < array.length; i += 1) {
        for (j = i + 1; j < array.length; j += 1) {
            var temp = array[i];
            if (temp >= array[j]) {
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
    return array;
}
btn.addEventListener('click', function() {
    var inputValue = document.getElementById('value').value;
    var resultArea = document.getElementById('result');
    var array = inputValue.split(' ');
    var result = selectionSort(array);
    resultArea.innerHTML = "Sorted array: " + result;
})
