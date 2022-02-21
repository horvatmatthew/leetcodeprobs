var replaceElements = function(arr) {
    let max = -1;    

    for(let i = arr.length-1; i >= 0; i--) {        
        let temp = max;        
        max = Math.max(max, arr[i]);             
        arr[i] = temp; 
    }

    return arr;
};

console.log(replaceElements([17,18,5,4,6,1]));
console.log(replaceElements([400]));