var addBinary = function(a, b) {
    let num1Ptr = a.length-1;
    let num2Ptr = b.length-1;
    let result = '';
    let carryOver = 0;

    console.log(a + ' ' + b);

    while(num1Ptr >= 0 && num2Ptr >= 0) {
       //console.log(a[num1Ptr] + ' ' + b[num2Ptr] + ' ' + carryOver);
       //console.log('----');
       let tempSum = Number(a[num1Ptr]) + Number(b[num2Ptr]) + carryOver;
       //console.log(tempSum);
       if(tempSum >= 2) {
          result = (tempSum-2).toString() + result;
          carryOver = 1;
       } else if(tempSum == 0) {
        result = '0' + result;
        carryOver = 0;   
       }else {
           result = '1' + result;
           carryOver = 0;
       }
       num1Ptr--;
       num2Ptr--;
    }

    if(num1Ptr < 0 && num2Ptr >= 0) {
        for(let i = num2Ptr; i >= 0; i-- ) {
            let tempSum = Number(b[i]) + carryOver;
            if(tempSum >= 2) {
                result = (tempSum-2).toString() + result;
                carryOver = 1;
            } else if(tempSum == 0) {
                result = '0' + result;
                carryOver = 0;   
            }else {
                result = '1' + result;
                carryOver = 0;
            }
        }
    } else if(num2Ptr < 0 && num1Ptr >= 0) {
        for(let i = num1Ptr; i >= 0; i-- ) {
            let tempSum = Number(a[i]) + carryOver;
            if(tempSum >= 2) {
                result = (tempSum-2).toString() + result;
                carryOver = 1;
            } else if(tempSum == 0) {
                result = '0' + result;
                carryOver = 0;   
            }else {
                result = '1' + result;
                carryOver = 0;
            }
        }
    } 

    if(carryOver !== 0) {
        result = carryOver.toString() + result;
    }


    return result;
};

console.log(addBinary("11","1"));      // 100
console.log(addBinary("1010","1011")); // 10101
console.log(addBinary("0", "0")); // 0