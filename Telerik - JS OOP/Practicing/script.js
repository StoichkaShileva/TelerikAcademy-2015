/* global console */
/* jshint strict: true */
'use strict';
//Just a class
//Experiments

function GUT () {
	console.log("alo");
	var bom = 5;
}
var a = {
	name: "",
	age: 0,
	bum: function(txt) {
		return this.name + " " + txt;
	}
};

function Person() {

}
console.log(a);

var Person = function() {
	var name,
		age,
		setName,
		setAge,
		viewName,
		viewAge,
		self = this;
	a = 5;
	setName = function(name) {
		self.name = name;
	};
	setAge = function(age) {
		self.age = age;
	};
	viewName = function() {
		return self.name;
	};
	viewAge = function() {
		return self.age;
	};
	return {
		SetAge: setAge,
		SetName: setName,
		PeekName: viewName,
		PeekAge: viewAge,
	};
};


var gosho = new Person();
gosho.SetName = "Gosho";
console.log(gosho.PeekName());