function solveTask() {
    return function(array) {
        function isNumber(obj) {
            return !isNaN(parseFloat(obj))
        }

        if (arugments[0].length == 0) {
            return null;
        } else {
            var sum = 0,
                i,
                len;
            for (i = 0, len = array.length; i < len; i += 1) {
                if (isNumber(array[i]) == false) {
                    array[i] = parseInt(array[i]);
                    if (isNumber(array[i]) == false) {
                        throw new Error;
                    } else {
                        break;
                    }

                }
                sum += array[i];
            }
            return sum;
        }

    }
}
module.exports=[solveTask]