var removeDuplicates = function(nums) {
    let seens = {};

    for(let i = 0; i < nums.length; i++) {
        if(seens[nums[i]]) {
            nums.splice(i,1);
            --i;
        } else {
            seens[nums[i]] = 0;
            seens[nums[i]]++;
        }
    }

    return nums.length;
}

console.log(removeDuplicates([1,1,2]));
console.log(removeDuplicates([0,0,1,1,2,2,3,3,4]));