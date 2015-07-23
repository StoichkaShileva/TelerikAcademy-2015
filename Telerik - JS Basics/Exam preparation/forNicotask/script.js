function solve(args) {

    //input
    var nk = args[0].split(' ')
            .map(Number),
        K = parseInt(nk[1]),
        arr = args[1].split(' ')
            .map(Number);

    var result = 0,
        currDigit = 0;
    for (var i = 0; i < arr.length; i++) {
        currDigit = arr[i];

        //if 0 absolute difference of its neighboring numbers
        if (currDigit == 0) {
            if (currDigit == arr[0]) {
                currDigit = Math.abs((arr[i + 1] - arr[arr.length - 1]) * -1);
            }
            else if (currDigit == arr[arr.length - 1]) {
                currDigit = Math.abs((arr[i - 1] - arr[0]) * -1);
            }
            else {
                currDigit = Math.abs((arr[i - 1] - arr[i + 1]) * -1);
            }
            //console.log(currDigit);
        }

        //if even number 2, 4, 6 maximum of its neighboring numbers
        else if (currDigit % 2 == 0) {
            if (currDigit == arr[0]) {
                currDigit = Math.max(arr[i + 1], arr[arr.length - 1]);
            }
            else if (currDigit == arr[arr.length - 1]) {
                currDigit = Math.max(arr[i - 1], arr[0]);
            }
            else {
                currDigit = Math.max(arr[i - 1], arr[i + 1]);
            }
            //console.log(currDigit);
        }

        //if 1 sum of its neighboring numbers
        else if (currDigit == 1) {
            if (currDigit == arr[0]) {
                currDigit = arr[i + 1] + arr[arr.length - 1];
            }
            else if (currDigit == arr[arr.length - 1]) {
                currDigit = parseInt(arr[i - 1] + arr[0]);
            }
            else {
                currDigit = parseInt(arr[i - 1] + [i + 1]);
            }
            //console.log(currDigit);
        }

        //if odd number 3, 5 minimum of its neighboring numbers
        else if (currDigit % 2 != 0 && currDigit != 1) {
            if (currDigit == arr[0]) {
                currDigit = Math.min(arr[i + 1], arr[arr.length - 1]);
            }
            else if (currDigit == arr[arr.length - 1]) {
                currDigit = Math.min(arr[i - 1], arr[0]);
            }
            else {
                currDigit = Math.min(arr[i - 1], arr[i + 1]);
            }
            //console.log(currDigit);
        }
        currDigit = parseInt(currDigit);
        //console.log(currDigit);
        result += currDigit;
    }
    return result;
}


var test1 = [
    '10 3',
    '1 9 1 9 1 9 1 9 1 9'
];

console.log(solve(test1));