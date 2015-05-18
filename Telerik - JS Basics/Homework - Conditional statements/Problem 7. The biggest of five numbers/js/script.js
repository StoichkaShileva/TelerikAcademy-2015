var btn = document.getElementById('show');
btn.addEventListener('click', function() {
    var firstVal = parseFloat(document.getElementById('first-val').value);
    var secondVal = parseFloat(document.getElementById('second-val').value);
    var thirdVal = parseFloat(document.getElementById('third-val').value);
    var fourthVal = parseFloat(document.getElementById('fourth-val').value);
    var fifthVal = parseFloat(document.getElementById('fifth-val').value);
    var result = document.getElementById('result');

    if (firstVal >= secondVal) {
        if (firstVal >= thirdVal) {
            if (firstVal >= fourthVal) {
                if (firstVal >= fifthVal) {
                    result.innerHTML = firstVal;
                }
            }
        }

    }
    if (secondVal >= firstVal) {
        if (secondVal >= thirdVal) {
            if (secondVal >= fourthVal) {
                if (secondVal >= fifthVal) {
                    result.innerHTML = secondVal;
                }
            }
        }

    }
    if (thirdVal >= firstVal) {
        if (thirdVal >= secondVal) {
            if (thirdVal >= fourthVal) {
                if (thirdVal >= fifthVal) {
                    result.innerHTML = thirdVal;
                }
            }
        }
    }
    if (fourthVal >= firstVal) {
        if (fourthVal >= secondVal) {
            if (fourthVal >= thirdVal) {
                if (fourthVal >= fifthVal) {
                    result.innerHTML = fourthVal;
                }
            }
        }
    }
    if (fifthVal >= firstVal) {
        if (fifthVal >= secondVal) {
            if (fifthVal >= thirdVal) {
                if (fifthVal >= fourthVal) {
                    result.innerHTML = fifthVal;
                }
            }
        }
    }
});
