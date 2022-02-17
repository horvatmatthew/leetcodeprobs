var quadratic = function(x, a, b, c) {
    return (a * Math.pow(x,2)) + (b * x) + c;
}

var sortTransformedArray = function(nums, a, b, c) {
    let left = 0;
    let right = nums.length-1;
    
    let pointer = a >= 0 ? nums.length-1 : 0;

    let output = new Array(nums.length).fill(0);

    while(left <= right) {
        let leftQuadratic = quadratic(nums[left],a,b,c);
    
        let rightQuadratic = quadratic(nums[right],a,b,c);
        if(a >= 0) {
            if(leftQuadratic > rightQuadratic) {                
                output[pointer]  = leftQuadratic;                
                pointer--;
                left++;
            } else {                
                output[pointer]  = rightQuadratic;                
                pointer--;
                right--;
            }
        } else {
            if(leftQuadratic < rightQuadratic) {                
                output[pointer]  = leftQuadratic;                
                pointer++;
                left++;
            } else {                
                output[pointer]  = rightQuadratic;                
                pointer++;
                right--;
            }
        }
    }

    return output;
    
};

console.log(sortTransformedArray([-4, -2,2,4],-1,3,5));