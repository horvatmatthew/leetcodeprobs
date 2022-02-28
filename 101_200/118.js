/**
 * @param {number} numRows
 * @return {number[][]}
 */
 var generate = function(numRows) {
    let result = [];

    if(numRows === 0) {
        return result;
    }

    let first_row = [1].fill(1);
    result.push(first_row);

    for(let i = 1; i <numRows; i++) {
        let prevRow = result[i-1];
        let currRow = [];

        currRow.push(1);
        for(let j = 1; j < i; j++) {
            currRow.push(prevRow[j-1] + prevRow[j]);
        }

        currRow.push(1);
        result.push(currRow);
    }

    return result;
};

console.log(generate(5));
console.log(generate(1));