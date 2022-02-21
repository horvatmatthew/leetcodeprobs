var moveZeroes = function(nums) {
    let index = 0;

    for(let i = 0; i < nums.length;i++){
        if(nums[i] !== 0) {            
            nums[index++] = nums[i]
        }       
    }

    for(let i = index; i < nums.length;i++) {
        nums[i] = 0;
    }

    return nums;
};

 //console.log(moveZeroes([0,1,0,3,12]));
 //console.log(moveZeroes([0]));
 console.log(moveZeroes([0,0,1]));