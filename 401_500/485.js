var findMaxConsecutiveOnes = function(nums) {
    let maxOnes = 0;
    let current = 0;

    for(let i = 0; i < nums.length;i++) {
        if(nums[i] === 1) {
          current++;
          maxOnes = Math.max(maxOnes, current);   
        } else if(nums[i] === 0)  {
            current = 0;
        }
    }

    return maxOnes;
};

console.log(findMaxConsecutiveOnes([1,1,0,1,1,1]));
console.log(findMaxConsecutiveOnes([1,0,1,1,0,1]));