function Tasks(){
	// @@@@@ ***** Task 1 ***** @@@@@
	/*
		Write a script that selects all the div nodes that are
		directly inside other div elements
		Create a function using querySelectorAll()
		Create a function using getElementsByTagName()
	*/
	var task1 = (function () {
		var allInsideDivsViaQuerySelector = document.querySelectorAll('div div');
		var mainDivs = document.getElementsByTagName('div');
		var innerDivs = mainDivs.getElementsByTagName('div');

		return {
			querySelectorDivs: allInsideDivsViaQuerySelector,
			getElementsByTagName: innerDivs
		};

	})();

	var task2 = (function () {
		var inputTypeTextValue = document.querySelector('input[type=text]');
		console.log(inputTypeTextValue.value);
	})();

	var task3 = (function () {
		
	})();

	return {
		task1: task1,
		task2: task2,
		task3: task3,
		// task4: task4
	};
}