/* Task Description */
/* 
	Create a function constructor for Person. Each Person must have:
	*	properties `firstname`, `lastname` and `age`
		*	firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
		*	age must always be a number in the range 0 150
			*	the setter of age can receive a convertible-to-number value
		*	if any of the above is not met, throw Error 		
	*	property `fullname`
		*	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
		*	the setter receives a string is the format 'FIRST_NAME LAST_NAME'
			*	it must parse it and set `firstname` and `lastname`
	*	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
	*	all methods and properties must be attached to the prototype of the Person
	*	all methods and property setters must return this, if they are not supposed to return other value
		*	enables method-chaining
*/
function solve() {
    var Person = (function() {
        function validateFirstAndLastName(str) {
            var isValid = true.
            i,
            len;
            if (str.length > 20 || str.length < 3) {
                throw new Error();
            } else {
                isValid = true;
            }

            isValid = /^[A-z\u00C0-\u00ff\s'\.,-\/#!$%\^&\*;:{}=\-_`~()]+$/.test(str);
            if(isValid === false) {
            	throw new Error();
            }
            else {
            	return true;
            }
        }

        function validateAgeRange(num) {
            var age = parseInt(num);
            if (age < 0 || age > 150) {
                throw new Error();
            } else {
                return true;
            }
        }

        function Person(firstname, lastname, age) {
            var validateFirstName,
                validateLastName,
                validateAge;
            validateFirstName = validateFirstAndLastName(firstname);
            validateLastName = validateFirstAndLastName(lastname);
            validateAge = validateAgeRange(age);
            if (validateFirstName === true && validateLastName === true && validateAge === true) {
                this._firstname = firstname;
                this._lastname = lastname;
                this._age = age;
            }
        }
        Object.defineProperties(Person.prototype, {
            "fullname": {
                get: function() {
                    return this._firstname + " " + this._lastname;
                },
                set: function(val) {
                    var firstNameLastName = val.split(' ');
                    this._firstname = firstNameLastName[0];
                    this._lastname = firstNameLastName[1];
                    return this;
                }
            },
            "firstname": {
                get: function() {
                    return this._firstname;
                },
                set: function(val) {
                    if (validateFirstAndLastName(val) === true) {
                        this._firstname = val;
                    }
                }
            },
            "lastname": {
                get: function() {
                    return this._lastname;
                },
                set: function(val) {
                    if (validateFirstAndLastName(val) === true) {
                        this._lastname = val;
                    }
                }
            },
            "age": {
                get: function() {
                    return this._age;
                },
                set: function(val) {
                    if (validateAgeRange(val) === true) {
                        this._age = val;
                    }
                }
            }
        });
        Person.prototype.introduce = function() {
            return "Hello! My name is " + this.fullname + " and I am " + this._age + "-years-old";
        };
        return Person;
    }());
    return Person;
}
var s = solve();
var a = new s("bbbb", "genchev", 32);
a.firstname = "123";
// console.log(a.firstname);
// console.log(a.lastname);
// console.log(a.fullname);
// console.log(a.introduce());

module.exports = solve;
