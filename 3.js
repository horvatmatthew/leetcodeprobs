/**
 * @param {string} s
 * @return {number}
 */
 var lengthOfLongestSubstring = function(s) {
    let a_pointer = 0;
    let b_pointer = 0;
    let count = 0;
    let max = 0;

    let table = {};

    while(b_pointer < s.length) {
        if(!table[s[b_pointer]] || table[s[b_pointer] == 0]) {
            table[s[b_pointer]] = 0;
            table[s[b_pointer]]++;
            count++;
            b_pointer++;
            max = Math.max(max, count);
        } else {
            table[s[a_pointer]] = 0;
            count--;
            a_pointer++;
        }
    }

    return max;
};

console.log(lengthOfLongestSubstring('pwwkew'));