var sortArrayByParity = function(nums) {
    let index = 0;

    for(let i = 0; i < nums.length;i++) {        
        if(nums[i] % 2 === 0) {
            let temp = nums[index];
            nums[index++] = nums[i];
            nums[i] = temp;        
        }
    }

    return nums;
};

console.log(sortArrayByParity([3,1,2,4]));
console.log(sortArrayByParity([0]));