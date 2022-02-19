var insertElementAt = function(arr, index) {
    let len = arr.length -1;
    for(let i = len; i >= index; i--) {
        arr[i + 1] = arr[i];
    }

    arr[index] = 0;
}

var duplicateZeros = function(arr) {
    let returnArrayLength = arr.length;
    for(let i = 0; i < arr.length;i++) {
        if(arr[i] === 0) {
            insertElementAt(arr, i);
            i++;
        }
    }

    arr.splice(returnArrayLength);
    return arr;
};

console.log(duplicateZeros([1,0,2,3,0,4,5,0]));
console.log(duplicateZeros([1,2,3]));