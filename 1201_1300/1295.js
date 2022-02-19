var findNumbers = function(nums) {
    let even = 0;
    for(let i = 0; i < nums.length;i++) {
        let str = nums[i].toString();
        if(str.length % 2 === 0) {
            even++;
        }
    }

    return even;
};

console.log(findNumbers([12,345,2,6,7896]));
console.log(findNumbers([555,901,482,1771]));