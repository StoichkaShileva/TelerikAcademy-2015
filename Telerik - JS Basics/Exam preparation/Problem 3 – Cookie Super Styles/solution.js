function solve(args) {
    // Your solution here
    var allCode = args;
    var asString = '';

    function getIndicesOf(searchStr, str, caseSensitive) {
        var startIndex = 0, searchStrLen = searchStr.length;
        var index, indices = [];
        if (!caseSensitive) {
            str = str.toLowerCase();
            searchStr = searchStr.toLowerCase();
        }
        while ((index = str.indexOf(searchStr, startIndex)) > -1) {
            indices.push(index);
            startIndex = index + searchStrLen;
        }
        return indices;
    }

    function minify(arr) {
        var asString = '';
        for (var x = 0; x < arr.length; x += 1) {
            var newstr = '';
            var patter = /{$/;
            var resulter = allCode[x].match(patter);

            if (resulter != null) {
                if (resulter.index > -1) {
                    var findNewSpaces = / {/;
                    var findSpecialSpaces1 = /\+ /;
                    var findSpecialSpaces2 = / \+/;
                    var findSpecialSpaces3 = /\> /;
                    var findSpecialSpaces4 = / \>/;
                    var findSpecialSpaces5 = /\~ /;
                    var findSpecialSpaces6 = / \~/;
                    //var resultOfNewSpaces = allCode[x].match(findNewSpaces);
                    newstr = allCode[x].replace(/ +?/g, '');
                    allCode[x] = newstr.trim();

                    newstr = allCode[x].replace(findNewSpaces, '{');
                    allCode[x] = newstr.trim();
                    newstr = allCode[x].replace(findSpecialSpaces1, '+');
                    allCode[x] = newstr.trim();
                    newstr = allCode[x].replace(findSpecialSpaces2, '+');
                    allCode[x] = newstr.trim();
                    newstr = allCode[x].replace(findSpecialSpaces3, '>');
                    allCode[x] = newstr.trim();
                    newstr = allCode[x].replace(findSpecialSpaces4, '>');
                    allCode[x] = newstr.trim();
                    newstr = allCode[x].replace(findSpecialSpaces5, '~');
                    allCode[x] = newstr.trim();
                    newstr = allCode[x].replace(findSpecialSpaces6, '~');
                    allCode[x] = newstr.trim();
                    asString += allCode[x].trim();
                }
                else {
                    newstr = allCode[x].replace(/ +?/g, '');
                    allCode[x] = newstr.trim();
                    asString += allCode[x].trim();
                }
            }
            else {
                newstr = allCode[x].replace(/ +?/g, '');
                allCode[x] = newstr.trim();
                asString += allCode[x].trim();
            }
        }
        return asString;
    }

    minify(allCode);
    var isInBrackets = false;
    for (var l = 0; l < allCode.length; l += 1) {
        if (isInBrackets) {
            var pettern = /}/;
            var r = allCode[l + 1].match(pettern);
            if (r != null) {
                if (r.index > -1) {
                    var res = allCode[l].replace(';', '');
                    allCode[l] = res;
                    isInBrackets = false;
                }

            }
        }
        var patt = /{$/;
        var result = allCode[l].match(patt);

        if (result != null) {
            if (result.index > -1) {
                isInBrackets = true;
                continue;
            }
        }
    }
    function specialMinify(arr) {
        var str = '';
        for (var j = 0; j < arr.length; j += 1) {
            str += arr[j];
        }
        return str;
    }

    var finalResult = specialMinify(allCode);
    for (var y = 0; y < allCode.length; y += 1) {
        var patternForTag = /{$/;
        var resultFa = allCode[y].match(patternForTag);

        if (resultFa != null) {
            if (resultFa.index > -1) {
                var currentA = [];
                var inBracketsSpec = false;
                for (var t = y+1; t < allCode.length; t += 1) {
                    if (allCode[t] == allCode[y]) {
                        inBracketsSpec = true;
                        allCode.splice(t, 1);
                        continue;
                    }
                    if (inBracketsSpec) {
                        var resultPa = allCode[t].match(patternForTag);
                        if (resultPa != null) {
                            if (resultPa.index > -1) {
                                inBracketsSpec = false;
                                allCode.splice(t - 1, 1);
                                break;
                            }
                            else {
                                //currentA.push(allCode[t - 1]);
                                //allCode.splice(t,1);
                                var a = allCode.splice(t - 1, 1);
                                t--;
                                currentA.push(a[0]);
                            }
                        }
                        else {
                            var a = allCode.splice(t - 1, 1);
                            t--;
                            currentA.push(a[0]);
                        }
                    }
                }
                for (var g = 0; g < currentA.length; g += 1) {
                    var s = 0;
                    for (var z = y+1; z < allCode.length; z+=1) {
                        var resultPa = allCode[z + 1].match(patternForTag);
                        if (resultPa == null) {
                            s++;
                        }
                        else {
                            break;
                        }
                     }
                    allCode.splice(y + s+1, 0, currentA[g]);
                }
            }
        }
    }

    finalResult = minify(allCode);
    console.log(finalResult);
}
solve(['#the-big-b{', '    color: yellow;', '    size: big;', '}', '.muppet{', '    powers: all;', '    skin: fluffy;', '}', '.water-spirit {', '    powers: water;', '    alignment : not-good;', '}', 'all{', '    meant-for: nerdy-childj', '}', '.muppet {', '    powers: everything;', 'smth: alo;', '}', 'all .muppet {', '    alignment : good ;', '}', '.muppet+ .water-spirit{', '    power: everything-a-muppet-can-do-and-water;', '}']);