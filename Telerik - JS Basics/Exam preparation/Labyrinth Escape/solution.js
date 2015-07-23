function solve(params) {
    var rowsAndCols = params[0].split(' ');
    var rows = parseInt(rowsAndCols[0]);
    var cols = parseInt(rowsAndCols[1]);
    var startPositions = params[1].split(' ');
    var r = parseInt(startPositions[0]);
    var c = parseInt(startPositions[1]);
    var directions = [];
    for (var j = 2; j < rows + 1; j += 1) {
        var currentDirections = [];
        currentDirections = params[j].split('');
        directions.push(currentDirections);
    }
    var mockMatrix = [];
    for (var x = 0, bum = 1; x < rows; x += 1, bum += 4) {
        var current = [];
        for (var j = bum; j < cols + bum; j += 1) {
            current.push(j);
        }
        mockMatrix.push(current);
    }
    var collected = 0;
    var numsOfSteps = 0;
    var hasToBreak = false;
    for (var row = r; !hasToBreak;) {
        for (var col = c; !hasToBreak;) {
            if (typeof directions[row] != "undefined") {
                //debugger;
                if (directions[row][col] == "l" || directions[row][col] == true) {
                    if (directions[row][col] == true) {
                        console.log("lost " + numsOfSteps);
                        hasToBreak = true;
                    }
                    directions[row][col] = true;
                    collected += mockMatrix[row][col];
                    numsOfSteps++;
                    col -= 1;
                }
                else if (directions[row][col] == "r" || directions[row][col] == true) {
                    if (directions[row][col] == true) {
                        console.log("lost " + numsOfSteps);
                        hasToBreak = true;
                    }
                    directions[row][col] = true;
                    collected += mockMatrix[row][col];
                    numsOfSteps++;
                    col += 1;
                }
                else if (directions[row][col] == "u" || directions[row][col] == true) {
                    if (directions[row][col] == true) {
                        console.log("lost " + numsOfSteps);
                        hasToBreak = true;
                    }
                    directions[row][col] = true;
                    collected += mockMatrix[row][col];
                    numsOfSteps++;
                    row -= 1;
                }
                else if (directions[row][col] == "d" || directions[row][col] == true) {
                    if (directions[row][col] == true) {
                        console.log("lost " + numsOfSteps);
                        hasToBreak = true;
                    }
                    directions[row][col] = true;
                    collected += mockMatrix[row][col];
                    numsOfSteps++;
                    row += 1;
                }
            }
            else {
                console.log("out " + collected);
                hasToBreak = true;
                break;
            }

        }
        if(hasToBreak == true) {
            break;
        }
    }

}

solve(["5 8", "0 0", "rrrrrrrd", "ludulrd", "durlddud", "urrrldud", "ulllllll"]);