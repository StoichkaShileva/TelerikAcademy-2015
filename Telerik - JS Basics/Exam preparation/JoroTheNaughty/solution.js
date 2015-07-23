function solve(params) {
    var first = params[0].split(' ');
    var rows = parseInt(first[0]);
    var cols = parseInt(first[1]);
    var jumps = parseInt(first[2]);
    var startPoints = params[1].split(' ');
    var startRow = parseInt(startPoints[0]);
    var startCol = parseInt(startPoints[1]);
    var jumpsPositions = [];
    for (var x = 2; x < jumps + 2; x += 1) {
        var currentPositions = params[x].split(' ');
        for (var l = 0; l < currentPositions.length; l += 1) {
            currentPositions[l] = parseInt(currentPositions[l]);
        }
        jumpsPositions.push(currentPositions);
    }

    var matrix = [];
    var num = 1;
    var temp = num;
    for (var row = 0; row < rows; row += 1, num += cols) {
        var current = [];
        temp = num;
        for (var col = 0; col < cols; col += 1, num += 1) {
            current.push(num);
        }
        num = temp;
        matrix.push(current);
    }

    var hasToBreak = false;
    var i = 0;
    var jumpsNeeded = 0;
    var sum = 0;
    var rrow = startRow;
    var ccol = startCol;
    for (; !hasToBreak; i += 1) {
        for (; !hasToBreak; i += 1) {
            if (i < jumpsPositions.length) {
                var currentRow = jumpsPositions[i][0];
                var currentCol = jumpsPositions[i][1];
            }
            else {
                i = 0;
                var currentRow = jumpsPositions[i][0];
                var currentCol = jumpsPositions[i][1];
            }
            if (currentRow + rrow >= rows || currentCol + ccol >= cols) {
                sum += matrix[rrow][ccol];
                console.log("escaped " + sum);
                hasToBreak = true;
            }
            else {
                if (typeof matrix[rrow] != "undefined") {
                    if (matrix[rrow][ccol] != true || typeof matrix[rrow][ccol] != "undefined") {
                        sum += matrix[rrow][ccol];
                        jumpsNeeded++;
                        rrow += (currentRow);
                        ccol += (currentCol);
                    }
                    else {
                        console.log("caught " + jumpsNeeded);
                        hasToBreak = true;
                    }
                }
                else {
                    console.log("escaped " + sum);
                    hasToBreak = true;
                }
            }

        }
    }
}
solve(['500 500 1', '0 0', '-1 1']);
