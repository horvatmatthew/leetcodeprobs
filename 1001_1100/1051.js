var heightChecker = function(heights) {
    let expected = heights.slice().sort((a,b) => a-b);
    let differences = 0;
        
    for(let i = 0; i < heights.length; i++) {
        if(heights[i] != expected[i]) {
            differences++;
        }
    }

    return differences;
};

console.log(heightChecker([1,1,4,2,1,3]));
console.log(heightChecker([5,1,2,3,4]));
console.log(heightChecker([1,2,3,4,5]));