var btn = document.getElementById('print-nums-button');

btn.addEventListener('click', function () {
	var inputValue = document.getElementById('value').value;
	var resultArea = document.getElementById('result');
	for(var i = 1; i <= parseInt(inputValue); i++) {
		if(i % 7 != 0 && i % 3 != 0)
			resultArea.innerHTML += (i + " ");
	}
})