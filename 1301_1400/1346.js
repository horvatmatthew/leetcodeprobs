var checkIfExist = function(arr) {
    for(let i = 0; i < arr.length; i++) {
        let answer = 2 * arr[i];
        for(let j = 0; j < arr.length; j++) {
            if(i != j && arr[j] === answer) {
                return true;
            }
        }
    }

    return false;
};

console.log(checkIfExist([10,2,5,3]));
console.log(checkIfExist([7,1,14,11]));
console.log(checkIfExist([3,1,7,11]));