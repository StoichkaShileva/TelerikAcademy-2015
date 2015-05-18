var btn = document.getElementById('show');
btn.addEventListener('click', function() {
    var input = parseFloat(document.getElementById('first-val').value);
    var result = document.getElementById('result');
    var HUNDRED = "hundred";

    function fromZeroToNine(value) {
        switch (value) {
            case 0:
                return "zero";
                break;
            case 1:
                return "one";
                break;
            case 2:
                return "two";
                break;
            case 3:
                return "three";
                break;
            case 4:
                return "four";
                break;
            case 5:
                return "five";
                break;
            case 6:
                return "six";
                break;
            case 7:
                return "seven";
                break;
            case 8:
                return "eight";
                break;
            case 9:
                return "nine";
                break;
        }
    }

    function fromElevenToNineteen(value) {
        switch (value) {
            case 1:
                return "eleven";
                break;
            case 2:
                return "twelve";
                break;
            case 3:
                return "thirteen";
                break;
            case 4:
                return "fourteen";
                break;
            case 5:
                return "fifteen";
                break;
            case 6:
                return "sixteen";
                break;
            case 7:
                return "seventeen";
                break;
            case 8:
                return "eighteen";
                break;
            case 9:
                return "nineteen";
                break;
        }
    }

    function fromTenToHundred(value) {
        switch (value) {
            case 1:
                return "ten";
                break;
            case 2:
                return "twenty";
                break;
            case 3:
                return "thirty";
                break;
            case 4:
                return "fourty";
                break;
            case 5:
                return "fifty";
                break;
            case 6:
                return "sixty";
                break;
            case 7:
                return "seventy";
                break;
            case 8:
                return "eighty";
                break;
            case 9:
                return "ninety";
                break;
        }
    }

    function solveComplexNumbers(firstDigit, secondDigit) {
        if (secondDigit === 0) {
            result.innerHTML += fromTenToHundred(firstDigit);
        } else if (firstDigit === 1) {
            result.innerHTML += fromElevenToNineteen(secondDigit);
        } else {
            result.innerHTML += fromTenToHundred(firstDigit) + " ";
            result.innerHTML += fromZeroToNine(secondDigit);
        }
    }

    function solve() {
        var digit = parseInt(input);
        var inputAsString = input.toString();
        result.innerHTML = "";
        if (inputAsString.length === 1) {
            result.innerHTML = fromZeroToNine(input);
        } else if (inputAsString.length == 2) {
            var firstDigit = parseInt(inputAsString[0]);
            var secondDigit = parseInt(inputAsString[1]);
            solveComplexNumbers(firstDigit, secondDigit);
        } else if (inputAsString.length === 3) {
            var firstDigit = parseInt(inputAsString[0]);
            var secondDigit = parseInt(inputAsString[1]);
            var thirdDigit = parseInt(inputAsString[2]);
            if (secondDigit === 0 && thirdDigit === 0) {
                result.innerHTML += fromZeroToNine(firstDigit) + " " + HUNDRED;
            } else {
                result.innerHTML += fromZeroToNine(firstDigit) + " " + HUNDRED + " ";
                solveComplexNumbers(secondDigit, thirdDigit);
            }

        }
    }
    solve();
});
