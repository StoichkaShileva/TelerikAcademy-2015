var btn = document.getElementById('print-nums-button');
btn.addEventListener('click', function() {
	var resultElement = document.getElementById('result');
    var doc = window.document;
    var win = window;
    var nav = window.navigator;
    var documentProperties = new Array();
    var windowProperties = new Array();
    var navigatorProperties = new Array();
    iterateOverProperties(doc, documentProperties);
    iterateOverProperties(win, windowProperties);
    iterateOverProperties(nav, navigatorProperties);
    function iterateOverProperties(obj, array) {
        for (var prop in obj) {
            array.push(prop);
        }
    }
    documentProperties.sort();
    windowProperties.sort();
    navigatorProperties.sort();
    resultElement.innerHTML += "Document MIN element: " + documentProperties.shift() + " <br />";
    resultElement.innerHTML += "Document MAX element: " + documentProperties.pop() + " <br />";
    resultElement.innerHTML += "Window MIN element: " + windowProperties.shift() + " <br />";
    resultElement.innerHTML += "Window MAX element: " + windowProperties.pop() + " <br />";
    resultElement.innerHTML += "Navigator MIN element: " + navigatorProperties.shift() + " <br />";
    resultElement.innerHTML += "Navigator MAX element: " + navigatorProperties.pop() + " <br />";
})
