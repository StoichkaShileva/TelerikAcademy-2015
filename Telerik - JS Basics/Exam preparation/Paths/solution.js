function solve(params) {
    var firstArgument = params[0].split(' ');
    var rows = parseInt(firstArgument[0]);
    var cols = parseInt(firstArgument[1]);
    var directions = [];
    var mockMatrix = [];
    for (var j = 0, x = 1; j < rows; j += 1, x += 1) {
        var current = params[x].split(' ');

        directions.push(current);
    }
    //Filling mock matrix
    for (var row = 0; row < rows; row += 1, b = Math.pow(2, row)) {
        var currentArr = [];
        for (var col = 0, b = Math.pow(2, row); col < cols; col += 1, b++) {
            currentArr[col] = b;
        }
        mockMatrix.push(currentArr);
    }

    //Checking matrix
    var sum = 0;
    var r = 0;
    var c = 0;
    var hasToBreak = false;
    while (!hasToBreak) {
        if (typeof directions[r] != 'undefined') {

            if (directions[r][c] == 'dr' || directions[r][c] === true) {
                if (directions[r][c] === true) {
                    console.log("failed at (" + r + ", " + c + ")");
                    hasToBreak = true;
                }
                else {
                    sum += mockMatrix[r][c];
                    directions[r][c] = true;
                    r += 1;
                    c += 1;
                }

            }
            else if (directions[r][c] == 'ur' || directions[r][c] === true) {
                if (directions[r][c] === true) {
                    console.log("failed at (" + r + ", " + c + ")");
                    hasToBreak = true;
                }
                else {
                    sum += mockMatrix[r][c];
                    directions[r][c] = true;
                    r -= 1;
                    c += 1;
                }
            }
            else if (directions[r][c] == 'ul' || directions[r][c] === true) {
                if (directions[r][c] === true) {
                    console.log("failed at (" + r + ", " + c + ")");
                    hasToBreak = true;
                }
                else {
                    sum += mockMatrix[r][c];
                    directions[r][c] = true;
                    r -= 1;
                    c -= 1;
                }
            }
            else if (directions[r][c] == 'dl' || directions[r][c] === true) {
                if (directions[r][c] === true) {
                    console.log("failed at (" + r + ", " + c + ")");
                    hasToBreak = true;
                }
                else {
                    sum += mockMatrix[r][c];
                    directions[r][c] = true;
                    r += 1;
                    c -= 1;
                }
            }
        }
        else {
            console.log("successed with " + sum);
            hasToBreak = true;
        }

    }
}
solve(['3 5', 'dr dl dr ur ul', 'dr dr ul ur ur', 'dl dr ur dl ur']);