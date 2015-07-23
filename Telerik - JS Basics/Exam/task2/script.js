function solve(params) {
    var rows = parseInt(params[0]),
        cols = parseInt(params[1]);
    var pieces = [];
    for (var z = 2; z < rows + 2; z += 1) {
        pieces.push(params[z]);
    }

    var moves = [];
    var movesNumber = parseInt(params[2 + rows]);
    for (var s = 3 + rows; s < movesNumber + 3 + rows; s += 1) {
        moves.push(params[s]);
    }
    var matrix = [];
    var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".toLowerCase();
    for (var row = rows - 1, num = 1; row >= 0; row--, num++) {
        var current = [];
        for (var col = 0; col < cols; col += 1) {
            current.push(alphabet[col] + num);
        }
        matrix.unshift(current);
    }
    var copied = [];
    for (var r = 0; r < matrix.length; r += 1) {
        var curr = [];
        for (var c = 0; c < matrix[r].length; c += 1) {
            curr.push(matrix[r][c]);
        }
        copied.push(curr);
    }

    for (var p = 0; p < pieces.length; p += 1) {
        var current = pieces[p];
        for (var m = 0; m < current.length; m += 1) {
            copied[p][m] = pieces[p][m];
        }
    }
    var spec = [];
    for (var y = 0; y < moves.length; y += 1) {
        var current = moves[y].split(' ');
        spec.push(current);
    }

    //SPEEEEEEEEEEEEEEEEEEEEC

    function searchInMatrix(str) {
        var special = "empty";
        for (var row = 0; row < matrix.length; row += 1) {
            for (var col = 0; col < matrix[row].length; col += 1) {
                if (matrix[row][col] == str) {
                    if (copied[row][col] == "R") {
                        special = "R";
                    }
                    else if (copied[row][col] == "B") {
                        special = "B"
                    }
                    else if (copied[row][col] == "Q") {
                        special = "Q";
                    }
                }
            }
        }
        return special;
    }

    function checkForObstacles(str1, str2) {
        var firstLetter = spec[q][w][0];
        var firstNumber = parseInt(spec[q][w][1]);

        var secondLetter = spec[q][w + 1][0];
        var secondNumber = parseInt(spec[q][w + 1][1]);
        var isEmpty = true;
        if (firstLetter == secondLetter) {

            var max = Math.max(firstNumber, secondNumber);
            var min = Math.min(firstNumber, secondNumber);
            for (var j = min; j < max; j += 1) {
                var str = firstLetter + j.toString();
                var r = searchInMatrix(str);
                if (r != "empty") {
                    isEmpty = false;
                    break;
                }
            }
            return isEmpty;
        }
        else if (firstNumber == secondNumber) {
            var isEmpty = true;
            var max = Math.max(firstLetter.charCodeAt(0), secondLetter.charCodeAt(0));
            var min = Math.min(firstLetter.charCodeAt(0), secondLetter.charCodeAt(0));
            for (var j = min; j < max; j += 1) {
                var str = String.fromCharCode(j) + j;
                var r = searchInMatrix(str);
                if (r != "empty") {
                    isEmpty = false;
                    break;
                }
            }

        }
        return isEmpty;
    }

    for (var q = 0; q < spec.length; q += 1) {
        var w = 0;
        var finalResult = "";
        //for (var w = 0; w < spec[q].length;) {
        var result = searchInMatrix(spec[q][w]);
        if (result == "Q") {
            //var currentResult = checkForObstacles(spec[q][w], spec[q][w + 1]);
            var isReserved = searchInMatrix(spec[q][w + 1]);
            if (isReserved != "empty") {
                console.log("no");
            }
            else {
                var firstLetter = spec[q][w][0];
                var firstNumber = parseInt(spec[q][w][1]);

                var secondLetter = spec[q][w + 1][0];
                var secondNumber = parseInt(spec[q][w + 1][1]);
                var specialRow = 0;
                var specialCol = 0;
                var specialRowSecond = 0;
                var specialColSecond = 0;
                var hasObstacle = false;
                for (var rowo = 0; rowo < rows; rowo += 1) {
                    for (var colo = 0; colo < cols; colo += 1) {
                        if (matrix[rowo][colo] == spec[q][w]) {
                            specialRow = rowo;
                            specialCol = colo;
                        }
                        if (matrix[rowo][colo] == spec[q][w + 1]) {
                            specialRowSecond = rowo;
                            specialColSecond = colo;
                        }
                    }
                }
                if (secondLetter == firstLetter) {
                    if (firstNumber > secondNumber) {

                        while (specialRow != specialRowSecond || specialCol != specialColSecond) {
                            specialRow++;
                            if(typeof copied[specialRow] != 'undefined') {
                                if (copied[specialRow][specialCol] != '-') {
                                    hasObstacle = true;
                                    break;
                                }
                            }

                        }
                        if(specialRow != specialRowSecond && specialCol != specialColSecond) {
                            console.log("no");
                        }
                        else {
                            if (hasObstacle == false) {
                                console.log("yes");
                            }
                            else {
                                console.log("no");
                            }
                        }

                    }
                    else {

                        while (specialRow != specialRowSecond || specialCol != specialColSecond) {
                            specialRow--;

                            if(typeof copied[specialRow] != 'undefined') {
                                if (copied[specialRow][specialCol] != '-') {
                                    hasObstacle = true;
                                    break;
                                }
                            }

                        }
                        if(specialRow != specialRowSecond && specialCol != specialColSecond) {
                            console.log("no");
                        }
                        else {
                            if (hasObstacle == false) {
                                console.log("yes");
                            }
                            else {
                                console.log("no");
                            }
                        }
                    }
                }
                else if (firstNumber == secondNumber) {
                    if (firstLetter > secondLetter) {

                        while (specialRow != specialRowSecond || specialCol != specialColSecond) {
                            specialCol--;
                            if(typeof copied[specialRow] != 'undefined') {
                                if (copied[specialRow][specialCol] != '-') {
                                    hasObstacle = true;
                                    break;
                                }
                            }

                        }
                        if(specialRow != specialRowSecond && specialCol != specialColSecond) {
                            console.log("no");
                        }
                        else {
                            if (hasObstacle == false) {
                                console.log("yes");
                            }
                            else {
                                console.log("no");
                            }
                        }
                    }
                    else {

                        while (specialRow != specialRowSecond || specialCol != specialColSecond) {
                            specialCol++;
                            if(typeof copied[specialRow] != 'undefined') {
                                if (copied[specialRow][specialCol] != '-') {
                                    hasObstacle = true;
                                    break;
                                }
                            }

                        }
                        if(specialRow != specialRowSecond && specialCol != specialColSecond) {
                            console.log("no");
                        }
                        else {
                            if (hasObstacle == false) {
                                console.log("yes");
                            }
                            else {
                                console.log("no");
                            }
                        }
                    }
                }
                else if (secondNumber > firstNumber && secondLetter > firstLetter) {

                    while (specialRow != specialRowSecond || specialCol != specialColSecond) {
                        specialRow--;
                        specialCol--;
                        if (copied[specialRow][specialCol] != '-') {
                            hasObstacle = true;
                            break;
                        }
                    }
                    if(specialRow != specialRowSecond && specialCol != specialColSecond) {
                        console.log("no");
                    }
                    else {
                        if (hasObstacle == false) {
                            console.log("yes");
                        }
                        else {
                            console.log("no");
                        }
                    }
                }
                else if (secondNumber < firstNumber && secondLetter > firstLetter) {

                    while (specialRow != specialRowSecond || specialCol != specialColSecond) {
                        specialRow++;
                        specialCol++;
                        if (copied[specialRow][specialCol] != '-') {
                            hasObstacle = true;
                            break;
                        }

                    }
                    if(specialRow != specialRowSecond && specialCol != specialColSecond) {
                        console.log("no");
                    }
                    else {
                        if (hasObstacle == false) {
                            console.log("yes");
                        }
                        else {
                            console.log("no");
                        }
                    }
                }
                else if (secondNumber > firstNumber && secondLetter < firstLetter) {

                    while (specialRow != specialRowSecond || specialCol != specialColSecond) {
                        specialRow--;
                        specialCol--;
                        if (copied[specialRow][specialCol] != '-') {
                            hasObstacle = true;
                            break;
                        }

                    }
                    if(specialRow != specialRowSecond && specialCol != specialColSecond) {
                        console.log("no");
                    }
                    else {
                        if (hasObstacle == false) {
                            console.log("yes");
                        }
                        else {
                            console.log("no");
                        }
                    }
                }
                else if (secondNumber < firstNumber && secondLetter < firstLetter) {

                    while (specialRow != specialRowSecond || specialCol != specialColSecond) {
                        specialRow++;
                        specialCol--;
                        if (copied[specialRow][specialCol] != '-') {
                            hasObstacle = true;
                            break;
                        }

                    }
                    if(specialRow != specialRowSecond && specialCol != specialColSecond) {
                        console.log("no");
                    }
                    else {
                        if (hasObstacle == false) {
                            console.log("yes");
                        }
                        else {
                            console.log("no");
                        }
                    }
                }
                else {
                    console.log("yes");
                }
            }
        }
        else if (result == "B") {
            //var currentResult = checkForObstacles(spec[q][w], spec[q][w + 1]);
            var isReserved = searchInMatrix(spec[q][w + 1]);
            if (isReserved != "empty") {
                console.log("no");
            }
            else {
                var firstLetter = spec[q][w][0];
                var firstNumber = parseInt(spec[q][w][1]);

                var secondLetter = spec[q][w + 1][0];
                var secondNumber = parseInt(spec[q][w + 1][1]);
                var firstLetter = spec[q][w][0];
                var firstNumber = parseInt(spec[q][w][1]);

                var secondLetter = spec[q][w + 1][0];
                var secondNumber = parseInt(spec[q][w + 1][1]);
                var specialRow = 0;
                var specialCol = 0;
                var specialRowSecond = 0;
                var specialColSecond = 0;
                var hasObstacle = false;
                for (var rowo = 0; rowo < rows; rowo += 1) {
                    for (var colo = 0; colo < cols; colo += 1) {
                        if (matrix[rowo][colo] == spec[q][w]) {
                            specialRow = rowo;
                            specialCol = colo;
                        }
                        if (matrix[rowo][colo] == spec[q][w + 1]) {
                            specialRowSecond = rowo;
                            specialColSecond = colo;
                        }
                    }
                }
                if (secondNumber > firstNumber && secondLetter > firstLetter) {

                    while (specialRow != specialRowSecond || specialCol != specialColSecond) {
                        specialRow--;
                        specialCol++;
                        if(specialRow >= 0) {
                            if (copied[specialRow][specialCol] != '-') {
                                hasObstacle = true;
                                break;
                            }
                        }
                        else {
                            hasObstacle = true;
                        }


                    }
                    if(specialRow != specialRowSecond && specialCol != specialColSecond) {
                        console.log("no");
                    }
                    else {
                        if (hasObstacle == false) {
                            console.log("yes");
                        }
                        else {
                            console.log("no");
                        }
                    }
                }
                else if (secondNumber < firstNumber && secondLetter > firstLetter) {

                    while (specialRow != specialRowSecond || specialCol != specialColSecond) {
                        specialRow++;
                        specialCol++;
                        if (copied[specialRow][specialCol] != '-') {
                            hasObstacle = true;
                            break;
                        }

                    }
                    if(specialRow != specialRowSecond && specialCol != specialColSecond) {
                        console.log("no");
                    }
                    else {
                        if (hasObstacle == false) {
                            console.log("yes");
                        }
                        else {
                            console.log("no");
                        }
                    }
                }
                else if (secondNumber > firstNumber && secondLetter < firstLetter) {

                    while (specialRow != specialRowSecond || specialCol != specialColSecond) {
                        specialRow--;
                        specialCol--;
                        if (copied[specialRow][specialCol] != '-') {
                            hasObstacle = true;
                            break;
                        }

                    }
                    if(specialRow != specialRowSecond && specialCol != specialColSecond) {
                        console.log("no");
                    }
                    else {
                        if (hasObstacle == false) {
                            console.log("yes");
                        }
                        else {
                            console.log("no");
                        }
                    }
                }
                else if (secondNumber < firstNumber && secondLetter < firstLetter) {

                    while (specialRow != specialRowSecond || specialCol != specialColSecond) {
                        specialRow++;
                        specialCol--;
                        if (copied[specialRow][specialCol] != '-') {
                            hasObstacle = true;
                            break;
                        }

                    }
                    if (hasObstacle) {
                        console.log("no");
                    }
                    else {
                        console.log("yes");
                    }
                }
                else {
                    console.log("no");
                }
            }
        }
        else if (result == "R") {
            //var currentResult = checkForObstacles(spec[q][w], spec[q][w + 1]);
            var isReserved = searchInMatrix(spec[q][w + 1]);
            if (isReserved != "empty") {
                console.log("no");
            }
            else {
                var firstLetter = spec[q][w][0];
                var firstNumber = parseInt(spec[q][w][1]);

                var secondLetter = spec[q][w + 1][0];
                var secondNumber = parseInt(spec[q][w + 1][1]);
                var firstLetter = spec[q][w][0];
                var firstNumber = parseInt(spec[q][w][1]);

                var secondLetter = spec[q][w + 1][0];
                var secondNumber = parseInt(spec[q][w + 1][1]);
                var specialRow = 0;
                var specialCol = 0;
                var specialRowSecond = 0;
                var specialColSecond = 0;
                var hasObstacle = false;
                for (var rowo = 0; rowo < rows; rowo += 1) {
                    for (var colo = 0; colo < cols; colo += 1) {
                        if (matrix[rowo][colo] == spec[q][w]) {
                            specialRow = rowo;
                            specialCol = colo;
                        }
                        if (matrix[rowo][colo] == spec[q][w + 1]) {
                            specialRowSecond = rowo;
                            specialColSecond = colo;
                        }
                    }
                }
                if (secondLetter == firstLetter) {
                    if (firstNumber > secondNumber) {

                        while (specialRow != specialRowSecond || specialCol != specialColSecond) {
                            specialRow++;
                            if(typeof copied[specialRow] != 'undefined') {
                                if (copied[specialRow][specialCol] != '-') {
                                    hasObstacle = true;
                                    break;
                                }
                            }

                        }
                        if(specialRow != specialRowSecond && specialCol != specialColSecond) {
                            console.log("no");
                        }
                        else {
                            if (hasObstacle == false) {
                                console.log("yes");
                            }
                            else {
                                console.log("no");
                            }
                        }
                    }
                    else {

                        while (specialRow != specialRowSecond || specialCol != specialColSecond) {
                            specialRow--;
                            if(typeof copied[specialRow] != 'undefined') {
                                if (copied[specialRow][specialCol] != '-') {
                                    hasObstacle = true;
                                    break;
                                }
                            }

                        }
                        if(specialRow != specialRowSecond && specialCol != specialColSecond) {
                            console.log("no");
                        }
                        else {
                            if (hasObstacle == false) {
                                console.log("yes");
                            }
                            else {
                                console.log("no");
                            }
                        }
                    }
                }
                else if (firstNumber == secondNumber) {
                    if (firstLetter > secondLetter) {

                        while (specialRow != specialRowSecond || specialCol != specialColSecond) {
                            specialCol--;
                            if(typeof copied[specialRow] != 'undefined') {
                                if (copied[specialRow][specialCol] != '-') {
                                    hasObstacle = true;
                                    break;
                                }
                            }

                        }
                        if(specialRow != specialRowSecond && specialCol != specialColSecond) {
                            console.log("no");
                        }
                        else {
                            if (hasObstacle == false) {
                                console.log("yes");
                            }
                            else {
                                console.log("no");
                            }
                        }
                    }
                    else {

                        while (specialRow != specialRowSecond || specialCol != specialColSecond) {
                            specialCol++;
                            if(typeof copied[specialRow] != 'undefined') {
                                if (copied[specialRow][specialCol] != '-') {
                                    hasObstacle = true;
                                    break;
                                }
                            }

                        }
                        if(specialRow != specialRowSecond && specialCol != specialColSecond) {
                            console.log("no");
                        }
                        else {
                            if (hasObstacle == false) {
                                console.log("yes");
                            }
                            else {
                                console.log("no");
                            }
                        }
                    }
                }
                else {
                    console.log("no");
                }
            }
        }
        else {
            console.log("no");
        }
        //console.log(finalResult);
    }

    var thirdMatrix = [];
    for (var rowe = 0, num = 1; rowe < rows; rowe += 1) {
        var curr = [];
        for (var cole = 0; cole < cols; cole += 1, num++) {
            curr.push(num);
        }
        thirdMatrix.push(curr);
    }
    //console.log(spec);
    //console.log(copied);
    //console.log(thirdMatrix);
    //console.log(matrix);
    //console.log(moves);
}
//solve(['7', '8', '---Q----', 'Q-------', '------R-', '--------', '-------R', '----B---', '-B------', '6', 'd7 h6', 'a6 b4', 'g5 h7', 'd7 g7', 'h3 a4', 'b1 a2', 'b1 d4', 'e2 h4']);
