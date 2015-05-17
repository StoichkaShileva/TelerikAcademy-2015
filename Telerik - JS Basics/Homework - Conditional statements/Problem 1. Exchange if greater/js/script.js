var btn = document.getElementById('exchange');
btn.addEventListener('click', function() {
    var firstVal = document.getElementById('first-val').value;
    var secondVal = document.getElementById('second-val').value;
    var temp = firstVal;
    if(firstVal > secondVal) {
    	document.getElementById('first-val').value = secondVal;
    	document.getElementById('second-val').value = temp;
    	
    	document.getElementById('result').innerHTML = "Values have been exchanged";
    }
})
