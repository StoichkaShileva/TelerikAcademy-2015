// var smth = (function() {
// 	var obj = {};

// 	obj.init = function(brand) {
// 		this.brand = brand;
// 		return this;
// 	};

// 	obj.alo = function() {
// 		return "pesho";
// 	};

// 	return obj;
// })();

// var car = (function (parent) {
// 	var car = Object.create(parent);
    
//     car.init = function (brand, hp) {
//     	parent.init.call(this, brand);
//     	this.horsePower = hp;
//     };

// 	return car;
// })(smth);
 
// var car = Object.create(car).init("BUM", 120);
// console.log(car.alo());


// function solve () {
// 	var sth = (function () {
// 		var obj = Object.create({});
// 		Object.defineProperty(obj, 'init', {
// 			value: function (name) {
// 				this.name = name;
// 			}
// 		});
// 	})();
// }



function solve() {

	var bum = (function () {
		var obj = Object.create({});
		Object.defineProperty(obj, 'opa', {

		});
	})();

	var module = {
		getAlo: bum
	};
}

solve();