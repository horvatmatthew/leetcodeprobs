var sortedSquares = function(nums) {
    let left = 0;
    let right = nums.length-1;
    let pointer = nums.length-1;

    let output = new Array(nums.length).fill(0);

    while(left <= right) {
        if(Math.pow(nums[left],2) > Math.pow(nums[right],2)) {
            output[pointer]  = Math.pow(nums[left],2);
            pointer--;
            left++;
        } else {
            output[pointer]  = Math.pow(nums[right],2);
            pointer--;
            right--;
        }
    }

    return output;
    
};

console.log(sortedSquares([-7,-3,2,3,11]));