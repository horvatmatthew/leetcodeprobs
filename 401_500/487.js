var findMaxConsecutiveOnes = function(nums) {
    let left = 0;
    let right = 0;
    let zeroes = 0;
    let longest = 0;

    while(right < nums.length && left <= right) {
        if(nums[right] == 0) {
            zeroes++;
        } 

        if(zeroes <= 1) {
            longest = Math.max(longest, right-left+1);
            right++;
        } else {
            if(nums[left] == 0) {
                zeroes--;
            }
            left++;
            zeroes--;
        }        
    }

    return longest;
};

console.log(findMaxConsecutiveOnes([1,0,1,1,0]));
console.log(findMaxConsecutiveOnes([1,0,1,1,0,1]));