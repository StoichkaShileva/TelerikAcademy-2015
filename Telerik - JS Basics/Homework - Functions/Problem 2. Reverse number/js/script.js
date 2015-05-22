var btn = document.getElementById('print-nums-button');

function reverseDigit(number) {
	var reversed = '';
    for(var i = number.length - 1; i >= 0; i--) {
        reversed += number[i];
    }
    return reversed;
}
btn.addEventListener('click', function () {
	var inputValue = document.getElementById('value').value;
	var resultArea = document.getElementById('result');
	result.innerHTML = "Reversed digit is " + reverseDigit(inputValue)
})