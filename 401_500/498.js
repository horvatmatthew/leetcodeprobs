/**
 * @param {number[][]} mat
 * @return {number[]}
 */
 var findDiagonalOrder = function(mat) {
    let result = [];
    let rows = mat.length -1;
    let cols = mat[0].length -1;
    let increasing = true;

    let row = 0;
    let col = 0;

    while(row <= rows && col <= cols) {
        result.push(mat[row][col]);
        if(increasing) {
            if(row - 1 >= 0 && col + 1 <= cols) {
                col++;
                row--;
            } else {
                increasing = false;
                if(col != cols) {
                    col++;
                } else {
                    row++;
                }
            }
        } else {
            if(row + 1 <= rows && col -1 >= 0) {
                row++;
                col--;
            } else {
                increasing = true;
                if(row != rows) {
                    row++;
                } else {
                    col++;
                }
            }
        }
    }

    return result;


    
};

console.log(findDiagonalOrder([[1,2,3], [4,5,6], [7,8,9]]));
console.log(findDiagonalOrder([[1,2], [3,4]]));