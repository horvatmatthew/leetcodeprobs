var pivotIndex = function(nums) {
    let leftTotal = 0;
    let rightTotal = 0;
    let pivotIndex = 0;

    for(let i = 0; i < nums.length; i++) {
        rightTotal += nums[i];
    }

    while(pivotIndex < nums.length) {
        rightTotal -= nums[pivotIndex];
        if(rightTotal === leftTotal) {
            return pivotIndex;
        } 

        leftTotal += nums[pivotIndex];
        pivotIndex++;
    }

    if(pivotIndex === nums.length) {
        return -1;
    }
    
};

console.log(pivotIndex([1,7,3,6,5,6]));
console.log(pivotIndex([1,2,3]));
console.log(pivotIndex([2,1,-1]));