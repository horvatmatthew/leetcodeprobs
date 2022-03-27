/**
 * @param {string[]} strs
 * @return {string}
 */
 var longestCommonPrefix = function(strs) {
    let minLength = Number.MAX_VALUE;
    for(let i = 0; i < strs.length;i++) {
        minLength = Math.min(minLength, strs[i].length);        
    }
    let longestStr = "";

    for(let i = 0; i < minLength;i++) {
        let validMatch = true;
        let current = strs[0][i];
        for(let j = 0;j < strs.length;j++) {
           if(strs[j][i] !== current) {
               validMatch = false;
               break;
           }
        }

        if(validMatch) {
            longestStr += current;
        } else {
            break;
        }
    }

    return longestStr;
};

console.log(longestCommonPrefix(['flower', 'flow', 'flight']));
console.log(longestCommonPrefix(['dog', 'racecar', 'car']));