function solve() {
	function solution (el, content) {
		if(el === undefined || content) {
			throw new Error();
		}
		if(!(el instanceof HTMLElement)) {
			if(typeof el !== 'string') {
				throw new Error();
			}
			else {
			 	el = document.getElementById(el);
			 	if(el==null) {
			 		throw new Error();
			 	}
			};
		}
		el.innerHTML = '';
		var fragment = document.createDocumentFragment();
		for(var i = 0; i < content.length; i+=1) {
			if(typeof content[i] !== 'string' || typeof content[i] !== 'number') {
				throw new Error();
			}
			fragment.innerHTML += content[i];
		}
		el.appendChild(fragment);
	}
	return solution;
}