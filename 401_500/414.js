var thirdMax = function(nums) {
    let max = null;
    let second_max = null;
    let third_max = null;

    for(let i = 0; i < nums.length; i++) {
        if(nums[i] !== max && nums[i] !== second_max && nums[i] !== third_max) {
            if(max == null || nums[i] > max) {
                third_max = second_max;
                second_max = max;
                max = nums[i]
            } else if(second_max == null || nums[i] > second_max) {
                third_max = second_max;
                second_max = nums[i];
            } else if(third_max == null || nums[i] > third_max) {
                third_max = nums[i];
            }
        }
    }

    return third_max != null ? third_max : max;
};

console.log(thirdMax([3,2,1]));
console.log(thirdMax([1,2]));
console.log(thirdMax([2,2,3,1]));