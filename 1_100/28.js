/**
 * @param {string} haystack
 * @param {string} needle
 * @return {number}
 */

 var strStr = function(haystack, needle) {
    if(needle.length === 0) {
        return 0;
    }

    if(needle.length > haystack.length) {
        return -1;
    }

    let kmpTable = new Array(needle.length).fill(0)

    let length = 0;
    let i = 1;
    while(i < needle.length) {
        if(needle[i] === needle[length]) {
            length++;
            kmpTable[i] = length;
            i++;
        } else if(length) {
            length = kmpTable[length-1];            
        } else {
            kmpTable[i] = 0;
            i++;
        }
    }
  
    let needlePointer = 0;
    let haystackPointer = 0;   
    
    while(haystackPointer < haystack.length) {
        if(haystack[haystackPointer] === needle[needlePointer]) {
            haystackPointer++;
            needlePointer++
        } else {
            if(needlePointer > 0) {
                needlePointer = kmpTable[needlePointer - 1];
            } else {
                // must compare at start
                haystackPointer++;
            }
         } 

         if(needlePointer === needle.length) {
             //found
             return (haystackPointer - needlePointer);
         }
    }

    
    
    return -1;
    
};

console.log(strStr('hello', 'll'));
console.log(strStr('aaaaa', 'baa'));
console.log(strStr('', '')); 
console.log(strStr('mississippi', 'issip'));
console.log(strStr('aabaaabaaac', 'aabaaac'));