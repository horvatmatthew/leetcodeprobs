/**
 * @param {number[][]} matrix
 * @return {number[]}
 */
 var spiralOrder = function(matrix) {
    let result = [];
    let top = 0;
    let bottom = matrix.length -1;
    let left = 0;
    let right = matrix[0].length - 1;
    let size = matrix.length * matrix[0].length;

    if(matrix == null || matrix.length == 0) {
        return result;
    } 

    while(result.length < size) {
        for(let i = left; i <= right && result.length < size; i++) {
            result.push(matrix[top][i]);
        }

        top++;

        for(let i = top; i <= bottom && result.length < size; i++) {
            result.push(matrix[i][right]);
        }

        right--;

        for(let i = right; i >= left && result.length < size; i--) {
            result.push(matrix[bottom][i]);
        }

        bottom--;

        for(let i = bottom; i >= top && result.length < size; i--) {
            result.push(matrix[i][left]);
        }

        left++;
    }

    return result;
};

console.log(spiralOrder([[1,2,3],[4,5,6],[7,8,9]]));
console.log(spiralOrder([[1,2,3,4],[5,6,7,8],[9,10,11,12]]));