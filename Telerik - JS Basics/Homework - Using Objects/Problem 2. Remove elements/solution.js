//Write a function that removes all elements with a given value.
//    Attach it to the array type.
//    Read about prototype and how to attach methods.
Array.prototype.remove = function(element) {
    var arr = this;
    var final = [];
    for (var i = 0; i < arr.length; i++) {
       if(arr[i] !== element) {
           final.push(arr[i]);
       }
    }
    return final;
}

var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];
var newww = arr.remove(1); //arr = [2,4,3,4,111,3,2,'1'];
console.log(newww);