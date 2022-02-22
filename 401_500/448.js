var findDisappearedNumbers = function(nums) {
    let numList = {};
    let missingNumbers = [];

    for(let i = 0; i < nums.length;i++) {
        if(!numList[nums[i]]) {
            numList[nums[i]] = 1;
        }
    }

    for(let i = 1; i <= nums.length;i++) {
        if(!numList[i]) {
            missingNumbers.push(i);
        }
    }

    return missingNumbers;
};


console.log(findDisappearedNumbers([4,3,2,7,8,2,3,1]));
console.log(findDisappearedNumbers([1,1]));