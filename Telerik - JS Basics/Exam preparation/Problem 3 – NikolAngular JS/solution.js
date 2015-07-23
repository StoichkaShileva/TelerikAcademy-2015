function solve(params) {
    var firstNumbers = parseInt(params[0]);
    var commands = [];
    for (var j = 1; j < firstNumbers + 1; j += 1) {
        var current = params[j].split('-');
        var arr = current[1].split(';');
        current[1] = arr;
        commands.push(current);
    }
    var html = [];
    for (var x = firstNumbers + 2; x < (parseInt(params[firstNumbers + 1]) + firstNumbers - 1); x += 1) {
        html.push(params[x]);
    }

    var templates = [];
    var index = 0;
    var fakehtml = [];
    for (var p = 0; p < html.length; p+=1) {
        fakehtml.push(html[p].trim());
    }
    function checkForCommand(line, command) {
        if(line.indexOf(command) > -1) {
            return true;
        }
        else {
            return false;
        }
    }
    var commandOpenTemplateTag = "<nk-template name=";
    var commandClosedTemplateTag = "</nk-template>";
    while (true) {
        var current = [];
        var currentHtml = "";
        var name = "";
        console.log(fakehtml[index]);
        debugger;
        if (checkForCommand(fakehtml[index], commandOpenTemplateTag)) {
        }
        current.push(name);
        for (var x = 0; index < fakehtml.length - 1; x += 1, index += 1) {
            if (fakehtml[index][1] != "/") {
                currentHtml += html[index]+"\n";;
            }
            else {
                currentHtml += html[index]+"\n";;
                break;
            }
        }

        if(name != "" && currentHtml != "") {
            templates.push([name, currentHtml]);
        }
        index++;
        if (fakehtml[index] == "<!DOCTYPE html>") {
            break;
        }

    }
    var finalHtml = "";
    for (var x = index; x < html.length; x+=1) {
        if(fakehtml[x][3] != "-") {
            finalHtml += html[x]+"\n";
        } // Template
        else if(fakehtml[x][4] == "t" &&fakehtml[x][5] == "e" &&fakehtml[x][6] == "m" &&fakehtml[x][7] == "p" &&fakehtml[x][8] == "l" &&fakehtml[x][9] == "a" &&fakehtml[x][10] == "t" &&fakehtml[x][11] == "e" ){
            var templateName = "";
            for (var r = 21; true; r+=1) {
                if(fakehtml[x][r] != "\"") {
                    templateName += fakehtml[x][r];
                }
                else {
                    break;
                }
             }

            if(templateName != "") {
                for (var k = 0; k < templates.length; k+=1) {
                    if(templates[k][0] == templateName) {
                        finalHtml += templates[k][1];
                    }
                 }
            }
        } // Model
        //else if(fakehtml[x][4] == "m" && fakehtml[x][5] == "o" && fakehtml[x][6] == "d" && fakehtml[x][7] == "e" && fakehtml[x][8] == "l") {
        //    debugger;
        //    var nameOfTheModel = "";
        //    for (var o = 10; true; o+=1) {
        //        if(fakehtml[x][o] != "<" && fakehtml[x][o+1] != "/") {
        //            nameOfTheModel += fakehtml[x][o];
        //        }
        //        else {
        //            nameOfTheModel += fakehtml[x][o];
        //            break;
        //        }
        //     }
        //    if(nameOfTheModel != "") {
        //        for (var u = 0; u < commands.length; u+=1) {
        //            if(commands[u][0] == nameOfTheModel) {
        //                finalHtml += commands[u][1];
        //            }
        //         }
        //    }
        //}
     }
    console.log(finalHtml);

}
var arr = [
    //'6',
    //'title-Telerik Academy',
    //'showSubtitle-true',
    //'subTitle-Free training',
    //'showMarks-false',
    //'marks-3;4;5;6',
    //'students-Ivan;Gosho;Pesho',
    //'42',
    //' <nk-template name="menu">',
    //'     <ul id="menu">',
    //'     <li>Home</li>',
    //'     <li>About us</li>',
    //' </ul>',
    //' </nk-template>',
    //' <nk-template name="footer">',
    //'     <footer>',
    //'     Copyright Telerik Academy 2014',
    //' </footer>',
    //' </nk-template>',
    //' <!DOCTYPE html>',
    //' <html>',
    //' <head>',
    //' <title>Telerik Academy</title>',
    //' </head>',
    //' <body>',
    //' <nk-template render="menu" />',
    //'     <h1><nk-model>title</nk-model></h1>',
    //' <nk-if condition="showSubtitle">',
    //'     <h2><nk-model>subTitle</nk-model></h2>',
    //' <div>{{<nk-model>subTitle</nk-model>}} ;)</div>',
    //' </nk-if>',
    //' <ul>',
    //'     <nk-repeat for="student in students">',
    //'         <li>',
    //'         <nk-model>student</nk-model>',
    //'         </li>',
    //'         <li>Multiline <nk-model>title</nk-model></li>',
    //'     </nk-repeat>',
    //'     </ul>',
    //'     <nk-if condition="showMarks">',
    //'         <div>',
    //'         <nk-model>marks</nk-model>',
    //'         </div>',
    //'    </nk-if>',
    //'<nk-template render="footer" />',
    //'    </body>',
    //'    </html>'
'0',
'21',
'<nk-template name="first">',
'    <ul>',
'    <li>',
'    In section UL',
'</li>',
'<li>',
'Still in section UL',
'</li>',
'</ul>',
'</nk-template>',
'<nk-template name="second">',
'     <div>',
'     Second section :)',
' </div>',
' </nk-template>',
' <div>',
' <nk-template render="first" />',
'     <nk-template render="second" />',
'     </div>',
];
solve(arr);