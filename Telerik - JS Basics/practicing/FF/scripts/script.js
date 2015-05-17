var arr = ['4', "ivan", " dragan"];var i;
var length = arr.length;
for (i = 0; i < length; i++) {
    if(i == 5) {
        continue;
    }
}
console.log("i am stupid string");

arr.forEach(function (item) {
    console.log(item);
});

for (var index = 0; index < 5; index++) {
    console.log(index);
}