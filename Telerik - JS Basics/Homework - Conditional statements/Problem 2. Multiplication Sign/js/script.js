var btn = document.getElementById('show');
btn.addEventListener('click', function() {
    var firstVal = document.getElementById('first-val').value;
    var secondVal = document.getElementById('second-val').value;
    var thirdVal = document.getElementById('third-val').value;
    var result = document.getElementById('result');
    if(firstVal === 0 && secondVal === 0 && thirdVal === 0) {
    	result.innerHTML = "0";
    }
    else if(firstVal > 0 && secondVal > 0 && thirdVal > 0) {
    	result.innerHTML = "+";
    }
    else if(firstVal < 0 && secondVal < 0 && thirdVal < 0) {
    	result.innerHTML = "-";
    }
    else if(firstVal < 0 && secondVal < 0 && thirdVal > 0)  {
    	result.innerHTML = "+";
    }
    else if(firstVal < 0 && secondVal > 0 && thirdVal < 0)  {
    	result.innerHTML = "+";
    }
    else if(firstVal > 0 && secondVal < 0 && thirdVal < 0)  {
    	result.innerHTML = "+";
    }
    else if(firstVal < 0 && secondVal > 0 && thirdVal > 0) {
    	result.innerHTML = "-";
    }
    else if(firstVal > 0 && secondVal < 0 && thirdVal > 0) {
    	result.innerHTML = "-";
    }
    else if(firstVal > 0 && secondVal > 0 && thirdVal < 0) {
    	result.innerHTML = "-";
    }
    else if(firstVal === 0 || secondVal === 0 || thirdVal === 0){
    	result.innerHTML = "0";
    }
});
