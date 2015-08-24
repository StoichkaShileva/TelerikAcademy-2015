// function solve() {
//     return function(selector, isCaseSensitive) {
//         //isCaseSensitive = isCaseSensitive || false;
//         var itemsList = document.createElement('div');
//         itemsList.className = 'items-list';

//         var element = document.querySelector(selector);
//         element.className = 'items-control';

//         //Search text
//         var enterTextElement = document.createElement('label');
//         enterTextElement.innerHTML = 'Enter text';

//         //Search box
//         var enterTextInput = document.createElement('input');

//         var btn = document.createElement('button');
//         btn.innerHTML = 'Add';
//         btn.className = 'button';

//         btn.addEventListener('click', function() {
//             var currentItemListElement = document.createElement('div');
//             currentItemListElement.className = 'list-item';
//             currentItemListElement.innerHTML = enterTextInput.value;
//             var innerButton = document.createElement('button');
//             innerButton.className = 'button';
//             innerButton.innerHTML = 'X';

//             currentItemListElement.appendChild(innerButton);
//             itemsList.appendChild(currentItemListElement);
//             innerButton.addEventListener('click', function() {
//                 currentItemListElement.parentNode.removeChild(currentItemListElement);
//             })
//         })

//         //Adding elements part
//         var addElementsPart = document.createElement('div');
//         addElementsPart.className = 'add-controls';
//         addElementsPart.appendChild(enterTextElement);
//         addElementsPart.appendChild(enterTextInput)
//         addElementsPart.appendChild(btn);

//         //Search controls part
//         var searchControlsPart = document.createElement('div');
//         searchControlsPart.className = 'search-controls';
//         var labelSearch = document.createElement('label');
//         labelSearch.innerHTML = 'Search:';
//         var inputSearch = document.createElement('input');



//         // var minLength = Math.min(currentValue.length, secondHTML.length);
//         // if(currentValue.length > secondHTML.length) {
//         //  minLength = Math.max(currentValue.length, secondHTML.length);
//         // }
//         //          for (var j = 0; j < minLength; j += 1) {
//         //              if (secondHTML[j] != currentValue[j]) {
//         //                  if(elements[i] instanceof HTMLElement) {
//         // elements[i].style.display = 'none';
//         //                  }
//         //                  hasToBreak = true;
//         //                  break;
//         //              }
//         //          }


//         //Result
//         var resultElement = document.createElement('div');
//         resultElement.className = 'result-controls';
//         resultElement.appendChild(itemsList);

//         //final
//         searchControlsPart.appendChild(labelSearch);
//         searchControlsPart.appendChild(inputSearch);
//         element.appendChild(addElementsPart);
//         element.appendChild(searchControlsPart);
//         element.appendChild(resultElement);
//         inputSearch.addEventListener('input', function() {
//             var currentValue = inputSearch.value;
//             console.log(currentValue);
//             var elements = document.getElementsByClassName('list-item');
//             for (var i = 0; i < elements.length; i++) {
//                 var currentHTML = elements[i].innerHTML;
//                 var secondHTML = "";
//                 if (currentHTML != undefined) {
//                     for (var q = 0; true; q += 1) {
//                         if (currentHTML[q] == '<') {
//                             break;
//                         }
//                         secondHTML += currentHTML[q];
//                     }
//                 }
//                 if (!isCaseSensitive) {
//                     currentValue = currentValue.toLowerCase();
//                     secondHTML = secondHTML.toLowerCase();
//                 }

//                 if (!(secondHTML.indexOf(currentValue) > -1)) {
//                     elements[i].style.display = 'none';

//                 } else {
//                     elements[i].style.display = 'block';
//                 }
//             }
//         })
//     };
// }

/////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////Another way
/////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////

// function solve() {
//   return function (selector, isCaseSensitive) {
//     var counter;
//     var root = document.querySelector(selector);
//     var isSearchCaseSensitive = isCaseSensitive || false;
//     var fragment = document.createDocumentFragment();

//     var itemsControl = document.createElement('div');
//     itemsControl.className = 'items-control';

//     // ADD CONTROLS
//     var addControls = document.createElement('div');
//     addControls.className = 'add-controls';

//     var inputAdd = document.createElement('input');
//     //inputAdd.type = "text";

//     var labelAdd = document.createElement("label");
//     //labelAdd.for = inputAdd;
//     labelAdd.innerHTML = "Enter text";

//     var buttonAdd = document.createElement('button');
//     buttonAdd.innerHTML = "Add";
//     //buttonAdd.setAttribute('type', 'button');
//     //buttonAdd.setAttribute('value', 'Add');
//     buttonAdd.className = 'button';

//     addControls.appendChild(labelAdd);
//     addControls.appendChild(inputAdd);
//     addControls.appendChild(buttonAdd);

//     // SEARCH CONTROLS
//     var searchControls = document.createElement('div');
//     searchControls.className = 'search-controls';

//     var inputSearch = document.createElement('input');
//     //inputSearch.type = "text";

//     var labelSearch = document.createElement("label");
//     //labelSearch.for = labelSearch;
//     labelSearch.innerHTML = "Search:";

//     inputSearch.appendChild(labelSearch);
//     searchControls.appendChild(inputSearch);

//     // RESULT CONTROLS
//     var resultControls = document.createElement('div');
//     resultControls.className = 'result-controls';

//     var listOfItems = document.createElement('ul');
//     listOfItems.className = 'items-list';

//     resultControls.appendChild(listOfItems);

//     // Append controls to ItemsControl
//     itemsControl.appendChild(addControls);
//     itemsControl.appendChild(searchControls);
//     itemsControl.appendChild(resultControls);
//     fragment.appendChild(itemsControl);
//     root.appendChild(fragment);

//     // Remove element on click
//     listOfItems.addEventListener('click', function(ev){
//       var target = ev.target;
//       if(target.tagName === 'INPUT'){
//         target.parentNode.parentNode.removeChild(target.parentNode);
//       };
//     },false);
    
//     // Search on 'enter'
//     inputSearch.addEventListener('input', function(ev){
//       var text = ev.target.value;
//       var liChildren = listOfItems.getElementsByTagName('li');

//       for (var i= 0, len = liChildren.length; i < len; i++){
//         var currentLi = liChildren[i];
//         var textCurrentLi = currentLi.innerHTML.substring(0, currentLi.innerHTML.indexOf('<button class="button">X</button>'));

//         if(isSearchCaseSensitive){
//           if(textCurrentLi.lastIndexOf(text) >= 0){
//             currentLi.style.display = 'block';
//           } else{
//             currentLi.style.display = 'none';
//           }
//         } else{
//             if(textCurrentLi.toLocaleLowerCase().lastIndexOf(text.toLocaleLowerCase()) >= 0){
//               currentLi.style.display = 'block';
//             } else{
//               currentLi.style.display = 'none';       
//             }
//         }
//       }
//     }, false);
    

//     // Add new element on Click
//     buttonAdd.addEventListener('click', function(ev) {
//             var listItem = document.createElement('li');
//             listItem.className = 'list-item';
//             listItem.innerHTML = inputAdd.value;

//             var buttonRemove = document.createElement('button');
//             buttonRemove.innerHTML = 'X';
//             buttonRemove.addEventListener('click', function() {
//                 this.parentNode.parentNode.removeChild(this.parentNode);
//             })
//             buttonRemove.className = 'button';

//             listItem.appendChild(buttonRemove);
//             listOfItems.appendChild(listItem);
//         }, false);
//   };
// }

module.exports = solve;
