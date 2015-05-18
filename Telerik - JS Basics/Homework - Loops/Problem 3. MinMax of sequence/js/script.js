var btn = document.getElementById('print-nums-button');

btn.addEventListener('click', function () {
	var inputValue = document.getElementById('value').value;
	var vals = inputValue.split(' ');
	var min = Number.MAX_VALUE;
	var max = Number.MIN_VALUE;
	for(var i = 0; i < vals.length; i++) {
		var currentNum = parseInt(vals[i]);
		if(currentNum < min)
			min = currentNum;
		if(currentNum > max)
			max = currentNum;
	}
	result.innerHTML = "Min value is: " + min + " and max value is " + max;
})