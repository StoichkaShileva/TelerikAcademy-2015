/* globals console*/
'use strict';

(function() {
 if (true) {} else{};   var Person;
    Person = (function() {
        var prop = 3,
            i = 1,
            x = 54,
            Person;
        function checkForSth(val) {
            var isNumeric = !isNaN(parseFloat(val)) && isFinite(val);
            if (isNumeric === false) {
                throw new Error("Value must be a number!");
            } else {
                return true;
            }
        }
        Person = function(name, age) {
            this._name = name;
            if (checkForSth(age) === true) {
                this._age = age;
            }
        };
        Object.defineProperties(Person.prototype, {
            'name': {
                get: function() {
                    return this._name;
                },
                set: function(val) {
                    this._name = val;
                }
            },
            'age': {
                get: function() {
                    return this._age;
                },
                set: function(val) {
                    if (checkForSth(val) === true) {
                        this._age = val;
                    }
                }
            }
        });
        return Person;
    })();
    var ivan = new Person("Gosho", 12);
    // ivan.age = "a";
    console.log(ivan.age);
    ivan.age = 23;
    console.log(ivan.age);
})();
