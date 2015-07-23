function solve(params) {
    var numbers = parseInt(params[0]),
        k = parseInt(params[1]),
        numbersAsString = params[2];
    var nums = numbersAsString.split(' ');
    for (var x = 0; x < nums.length; x += 1) {
        nums[x] = parseInt(nums[x]);
    }
    var l = 0;
    var finalArr = [];
    var i = 0;
    while (true) {
        if(k+i-1 == nums.length) {
            break;
        }
        l = i;
        var currentNums = [];
        for (; l < k+i; l += 1) {
            currentNums.push(nums[l]);
        }
        var minNum = 100000000000;
        var maxNum = -100000000000;

        for (var j = 0; j < currentNums.length; j += 1) {
            if (currentNums[j] < minNum) {
                minNum = currentNums[j];
            }
            if (currentNums[j] > maxNum) {
                maxNum = currentNums[j];
            }
        }
        finalArr.push(minNum + maxNum);
        i++;
    }
    console.log(finalArr.join(','));
}
solve(['8', '4', '1 8 8 4 2 9 8 11']);