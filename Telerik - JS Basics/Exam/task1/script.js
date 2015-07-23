function solve(params) {
    var nk = params[0].split(' ').map(Number),
        s = params[1].split(' ').map(Number);

    function absoluteDifference(num1, num2) {
        var max = Math.max(num1, num2);
        var min = Math.min(num1, num2);
        return max - min;
    }

    for (var p = 0; p < nk[1]; p += 1) {
        var transformation = [];
        for (var x = 0; x < s.length; x += 1) {
            if (x == 0) {
                var neighbourLeft = s[s.length - 1];
                if (x + 1 < s.length) {
                    var neighbourRight = s[x + 1];
                }
                if (s[x] == 0) {
                    var difference = absoluteDifference(neighbourLeft, neighbourRight);
                    transformation.push(difference);
                }
                else if (s[x] % 2 == 0) {
                    var max = Math.max(neighbourLeft, neighbourRight);
                    transformation.push(max);
                }
                else if (s[x] == 1) {
                    var sum = neighbourLeft + neighbourRight;
                    transformation.push(sum);
                }
                else if (s[x] % 2 != 0) {
                    var min = Math.min(neighbourLeft, neighbourRight);
                    transformation.push(min);
                }
            }
            else if (x == s.length - 1) {
                if (x - 1 >= 0) {
                    var neighbourLeft = s[x - 1];
                }
                var neighbourRight = s[0];
                if (s[x] == 0) {
                    var difference = absoluteDifference(neighbourLeft, neighbourRight);
                    transformation.push(difference);
                }
                else if (s[x] % 2 == 0) {
                    var max = Math.max(neighbourLeft, neighbourRight);
                    transformation.push(max);
                }
                else if (s[x] == 1) {
                    var sum = neighbourLeft + neighbourRight;
                    transformation.push(sum);
                }
                else if (s[x] % 2 != 0) {
                    var min = Math.min(neighbourLeft, neighbourRight);
                    transformation.push(min);
                }
            }
            else {
                if (x - 1 >= 0) {
                    var leftNeighbour = s[x - 1];
                }
                if (x + 1 < s.length) {
                    var rightNeighbour = s[x + 1];
                }
                if (s[x] == 0) {
                    var difference = absoluteDifference(leftNeighbour, rightNeighbour);
                    transformation.push(difference);
                }
                else if (s[x] % 2 == 0) {
                    var max = Math.max(leftNeighbour, rightNeighbour);
                    transformation.push(max);
                }
                else if (s[x] == 1) {
                    var sum = leftNeighbour + rightNeighbour;
                    transformation.push(sum);
                }
                else if (s[x] % 2 != 0) {
                    var min = Math.min(leftNeighbour, rightNeighbour);
                    transformation.push(min);
                }
            }
        }
        s = transformation;
    }

    var finalSum = 0;
    for (var o = 0; o < transformation.length; o += 1) {
        finalSum += transformation[o];
    }
    console.log(finalSum);
}
solve(['5 1', '9 0 2 4 1']);