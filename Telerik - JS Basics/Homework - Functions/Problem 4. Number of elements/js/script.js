var btn = document.getElementById('print-nums-button');

function returnNumberOfDivElements(body) {
    var count = document.getElementsByTagName('div').length;
    return count;
}
btn.addEventListener('click', function () {
    var body = window.body;
	var resultArea = document.getElementById('result');
    var numberOfDivs = returnNumberOfDivElements(body);
	result.innerHTML = "Div elements in the page are: " + numberOfDivs;
})