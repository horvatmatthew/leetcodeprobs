 /**
 * @param {number[]} nums
 * @return {number}
 */
 var dominantIndex = function(nums) {
    let largestNumber = -1;
    let largestIndex = 0;
    let possible = true;

    if(nums.length === 1) {
        return 0;
    }

    for(let i = 0; i < nums.length; i++) {
        if(nums[i] > largestNumber) {
            largestIndex = i;
            largestNumber = nums[i]
        }
    }

    for(let j = 0; j < nums.length; j++) {
        if(j !== largestIndex) {
            if(largestNumber < nums[j] * 2) {
                possible = false;
            }
        }
    }

    if(possible) {
        return largestIndex;
    } else {
        return -1;
    }
};

console.log(dominantIndex([3,6,1,0]));
console.log(dominantIndex([1,2,3,4]));
console.log(dominantIndex([1]));