function Solve(params) {
    var rowsAndCols = params[0].split(' ');
    var maxRows = parseInt(rowsAndCols[0]);
    var maxCols = parseInt(rowsAndCols[1]);
    var directionsByRows = new Array(maxRows);
    var anotherMatrix = new Array(maxRows);
    var firstNum = 1;
    var currentFirstNumber = 2;
    for (var i = 0; i < maxRows; i++) {
        firstNum = Math.pow(currentFirstNumber, i);

        var current = [];
        for (var j = 0; j < params[i + 1].length; j++) {
            current.push(firstNum);
            firstNum--;
        }
        anotherMatrix[i] = current;
    }
    for (var i = 0; i < maxRows; i++) {
        var current = [];
        for (var j = 0; j < params[i + 1].length; j++) {
            current.push(parseInt(params[i + 1][j]));
        }
        directionsByRows[i] = current;
    }
    var startRow = maxRows - 1;
    var startCol = maxCols - 1;
    var finalValue = 0;
    var finalValueNumber = -1;
    var rowsBreak = false;
    var colsBreak = false;
    for (var row = startRow; !rowsBreak;) {
        for (var col = startCol; !colsBreak;) {

            if (parseInt(directionsByRows[row][col]) == 1 || directionsByRows[row][col] === true) {
                if (directionsByRows[row][col] === true) {
                    console.log("Sadly the horse is doomed in " + finalValue + " jumps");
                    rowsBreak = true;
                    colsBreak = true;
                } else if (typeof directionsByRows[row - 2][col + 1] !== 'undefined') {
                    directionsByRows[row][col] = true;

                    finalValue++;
                    finalValueNumber += anotherMatrix[row][col];
                    row -= 2;
                    col++;
                } else {
                    console.log("Go go Horsy! Collected " + finalValueNumber + " weeds");
                    rowsBreak = true;
                    colsBreak = true;
                }
            } else {
                console.log("Go go Horsy! Collected " + finalValueNumber + " weeds");
                rowsBreak = true;
                colsBreak = true;
            }
        } else if (parseInt(directionsByRows[row][col]) == 2 || directionsByRows[row][col] === true) {
            if (directionsByRows[row][col] === true) {
                console.log("Sadly the horse is doomed in " + finalValue + " jumps");
                rowsBreak = true;
                colsBreak = true;
            } else if (typeof directionsByRows[row - 1][col + 2] !== 'undefined') {
                directionsByRows[row][col] = true;

                finalValue++;
                finalValueNumber += anotherMatrix[row][col];
                row--;
                col += 2;
            } else {
                console.log("Go go Horsy! Collected " + finalValueNumber + " weeds");
                rowsBreak = true;
                colsBreak = true;
            }
        } else {
            console.log("Go go Horsy! Collected " + finalValueNumber + " weeds");
            rowsBreak = true;
            colsBreak = true;
        }
    } else if (parseInt(directionsByRows[row][col]) == 3 || directionsByRows[row][col] === true) {
        if (directionsByRows[row][col] === true) {
            console.log("Sadly the horse is doomed in " + finalValue + " jumps");
            rowsBreak = true;
            colsBreak = true;
        } else if (typeof directionsByRows[row + 1][col + 2] !== 'undefined') {
            directionsByRows[row][col] = true;

            finalValue++;
            finalValueNumber += anotherMatrix[row][col];
            row++;
            col += 2;
        } else {
            console.log("Go go Horsy! Collected " + finalValueNumber + " weeds");
            rowsBreak = true;
            colsBreak = true;
        }
    } else {
        console.log("Go go Horsy! Collected " + finalValueNumber + " weeds");
        rowsBreak = true;
        colsBreak = true;
    }
} else if (parseInt(directionsByRows[row][col]) == 4 || directionsByRows[row][col] === true) {
    if (directionsByRows[row][col] === true) {
        console.log("Sadly the horse is doomed in " + finalValue + " jumps");
        rowsBreak = true;
        colsBreak = true;
    } else if (typeof directionsByRows[row + 2][col + 1] !== 'undefined') {
        directionsByRows[row][col] = true;

        finalValue++;
        finalValueNumber += anotherMatrix[row][col];
        row += 2;
        col++;
    } else {
        console.log("Go go Horsy! Collected " + finalValueNumber + " weeds");
        rowsBreak = true;
        colsBreak = true;
    }
} else {
    console.log("Go go Horsy! Collected " + finalValueNumber + " weeds");
    rowsBreak = true;
    colsBreak = true;
}
} else if (parseInt(directionsByRows[row][col]) == 5 || directionsByRows[row][col] === true) {
    if (directionsByRows[row][col] === true) {
        console.log("Sadly the horse is doomed in " + finalValue + " jumps");
        rowsBreak = true;
        colsBreak = true;
    } else if (typeof directionsByRows[row + 2][col - 1] !== 'undefined') {
        directionsByRows[row][col] = true;

        finalValue++;
        finalValueNumber += anotherMatrix[row][col];
        row += 2;
        col--;
    } else {
        console.log("Go go Horsy! Collected " + finalValueNumber + " weeds");
        rowsBreak = true;
        colsBreak = true;
    }
} else if (parseInt(directionsByRows[row][col]) == 6 || directionsByRows[row][col] === true) {
    if ((row + 1 <= maxRows && row + 1 >= 0) && (col - 2 <= maxCols && col - 2 >= 0)) {
        if (directionsByRows[row][col] === true) {
            console.log("Sadly the horse is doomed in " + finalValue + " jumps");
            rowsBreak = true;
            colsBreak = true;
        } else if (typeof directionsByRows[row + 1][col - 2] !== 'undefined') {
            directionsByRows[row][col] = true;

            finalValue++;
            finalValueNumber += anotherMatrix[row][col];
            row++;
            col -= 2;
        } else {
            console.log("Go go Horsy! Collected " + finalValueNumber + " weeds");
            rowsBreak = true;
            colsBreak = true;
        }
    } else {
        console.log("Go go Horsy! Collected " + finalValueNumber + " weeds");
        rowsBreak = true;
        colsBreak = true;
    }
} else if (parseInt(directionsByRows[row][col]) == 7 || directionsByRows[row][col] === true) {
    if ((row - 1 <= maxRows && row - 1 >= 0) && (col - 2 <= maxCols && col - 2 >= 0)) {
        if (directionsByRows[row][col] === true) {
            console.log("Sadly the horse is doomed in " + finalValue + " jumps");
            rowsBreak = true;
            colsBreak = true;
        } else if (typeof directionsByRows[row - 1][col - 2] !== 'undefined') {
            directionsByRows[row][col] = true;

            finalValue++;
            finalValueNumber += anotherMatrix[row][col];
            row--;
            col -= 2;
        } else {
            console.log("Go go Horsy! Collected " + finalValueNumber + " weeds");
            rowsBreak = true;
            colsBreak = true;
        }
    } else {
        console.log("Go go Horsy! Collected " + finalValueNumber + " weeds");
        rowsBreak = true;
        colsBreak = true;
    }
} else if (parseInt(directionsByRows[row][col]) == 8 || directionsByRows[row][col] === true) {
    if ((row - 2 <= maxRows && row - 2 >= 0) && (col - 2 <= maxCols && col - 1 >= 0)) {
        if (directionsByRows[row][col] === true) {
            console.log("Sadly the horse is doomed in " + finalValue + " jumps");
            rowsBreak = true;
            colsBreak = true;
        } else if (typeof directionsByRows[row - 2][col - 1] !== 'undefined') {
            directionsByRows[row][col] = true;

            finalValue++;
            finalValueNumber += anotherMatrix[row][col];
            row -= 2;
            col--;
        } else {
            console.log("Go go Horsy! Collected " + finalValueNumber + " weeds");
            rowsBreak = true;
            colsBreak = true;
        }
    } else {
        console.log("Go go Horsy! Collected " + finalValueNumber + " weeds");
        rowsBreak = true;
        colsBreak = true;
    }
}
}
}
}
Solve(['3 170', '65256624788315872547146742545371652845427473747267157662731442588248254733848315117257871124376782841157534346443612618725181711166757567365663638423518322167414635742267', '45455813336725247538881424621676377742372315377756873812547467266271517642434424316613753727845166781146278516761172147847651254585283744475617153481423232871713755726637', '61554736574112247245452874872314627642462447345828387664685574613831561533388314718463335155846275353167535228183566874387343281726347481161154526852575881675721325662347']);
