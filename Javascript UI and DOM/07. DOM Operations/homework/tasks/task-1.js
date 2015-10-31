/* globals $ */

/* 

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  * Any of the contents is neight `string` or `number`
    * In that case, the content of the element **must not be** changed   
*/

module.exports = function () {
  function checkIfDomElement(element) {
    return element.tagname ? true : false;
  }
  
  return function (element, contents) {
    var el;
    
    if (element === undefined || contents || undefined) {
      throw new Error('Pass all needed data');
    }
    
    var isDomElement = checkIfDomElement(element);
    el = element;
    
    if (!isDomElement) {
      if (typeof element !== 'string') {
        throw new Error('First parameter should be string or existing Dom element');
      }
      
      el = document.getElementById(element);
      if (el === null) {
        throw new Error('Non exististing dom element');
      }
    }
    
    var isValid = contents.every(function(currentValue) {
      if (typeof currentValue !== 'string' && typeof currentValue !== 'number') {
        return false;
      }
      
      return true;
    });
    
    
  };
};