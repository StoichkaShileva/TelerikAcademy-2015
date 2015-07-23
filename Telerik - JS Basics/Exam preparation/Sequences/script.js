function Solve(params) {
    var N = parseInt(params[0]);
    var nums = [];
    for (var x = 1; x <= N; x+=1) {
        nums.push(parseInt(params[x]));
     }
    var numOfSubsequences = 0;
    for (var j = 1; j < nums.length; j+=1) {
        if(nums[j] >= nums[j-1]) {
            continue;
        }
        else {
            numOfSubsequences++;
        }

     } 
    console.log(++numOfSubsequences);
}
Solve(['9', '1', '8', '8', '7', '6', '5', '7', '7', '6']);