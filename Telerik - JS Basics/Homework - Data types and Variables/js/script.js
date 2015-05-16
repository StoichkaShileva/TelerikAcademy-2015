///// ----- PROBLEMS HERE ----- \\\\\

//Problem 1. JavaScript literals
var intLiteral = 5;
var floatLiteral = 20.4332;
var arrayLiteral = [124, "woho"];
var booleanLiteral = true;
var objLiteral = {
	pesho: "ludaka"
}
var stringLiteral = "DAMNNN";
var nullLiteral = null;
var undefinedLiteral = undefined;


//Problem 2. Quoted text
var quotedText = "`'How you doin'?', Joey said'.";

//Problem 3. Typeof variables
var typeIntLiteral = typeof(intLiteral);
var typeFloatLiteral = typeof(floatLiteral);
var typeArrayLiteral = typeof(arrayLiteral);
var typeBooleanLiteral = typeof(booleanLiteral);
var typeObjectLiteral = typeof(objLiteral);
var typeStringLiteral = typeof(stringLiteral);

//Problem 4. Typeof null
var typeNullLiteral = typeof(nullLiteral);
var typeUndefinedLiteral = typeof(undefinedLiteral);


///// ---- Code below is only for displaying the information via html ---- \\\\\

var firstProblemElement = document.getElementById('first-problem');
var secondProblemElement = document.getElementById('second-problem');
var thirdProblemElement = document.getElementById('third-problem');
var fourthProblemElement = document.getElementById('fourth-problem');
firstProblemElement.innerHTML += "Integer Literal = " + intLiteral + " <br />";
firstProblemElement.innerHTML += "Floating point number Literal = " + floatLiteral + " <br />";
firstProblemElement.innerHTML += "Array Literal = [" + arrayLiteral + "] <br />";
firstProblemElement.innerHTML += "Boolean Literal = " + booleanLiteral + " <br />";
firstProblemElement.innerHTML += "Object Literal = " + JSON.stringify(objLiteral) + " <br />";
firstProblemElement.innerHTML += "String Literal = \"" + stringLiteral + "\" <br />";
firstProblemElement.innerHTML += "Null Literal = " + nullLiteral + " <br />";
firstProblemElement.innerHTML += "Undefined Literal = " + undefinedLiteral;
secondProblemElement.innerHTML += quotedText;
thirdProblemElement.innerHTML += "typeof(intLiteral) = " + typeIntLiteral + " <br />";
thirdProblemElement.innerHTML += "typeof(floatLiteral) = " + typeFloatLiteral  +" <br />";
thirdProblemElement.innerHTML += "typeof(arrayLiteral) = " + typeArrayLiteral  +" <br />";
thirdProblemElement.innerHTML += "typeof(booleanLiteral) = " + typeBooleanLiteral + " <br />";
thirdProblemElement.innerHTML += "typeof(objLiteral) = " + typeObjectLiteral  +" <br />";
thirdProblemElement.innerHTML += "typeof(stringLiteral) = " + typeStringLiteral + " <br />";
thirdProblemElement.innerHTML += "typeof(nullLiteral) = " + typeNullLiteral  +" <br />";
thirdProblemElement.innerHTML += "typeof(undefinedLiteral) = " + typeUndefinedLiteral;
fourthProblemElement.innerHTML += "typeof Null = " + typeNullLiteral + " <br />";
fourthProblemElement.innerHTML += "typeof Undefined = " + typeUndefinedLiteral;