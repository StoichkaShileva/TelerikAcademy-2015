var btn = document.getElementById('print-nums-button');

Array.prototype.binary_search = function(val, left, right) {
    if (typeof left === 'undefined') left = 0;
    if (typeof right === 'undefined') right = this.length - 1;
    if (left > right) return null;
    var mid = (left + right) >> 1;
    if (val == this[mid]) {
        return mid;
    } else if (val > this[mid]) {
        return this.binary_search(val, mid + 1, right);
    } else {
        return this.binary_search(val, left, mid - 1);
    }
}
btn.addEventListener('click', function() {
    var inputValue = document.getElementById('value').value;
    var searchedValue = document.getElementById('searched').value;
    var resultArea = document.getElementById('result');
    var array = inputValue.split(' ');
    var result = array.binary_search(parseInt(searchedValue));
    resultArea.innerHTML = "Index of the element: " + result;
})
