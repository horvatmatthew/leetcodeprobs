var validMountainArray = function(arr) {
   let i = 0;

   while(i < arr.length && i + 1 < arr.length && arr[i] < arr[i+1]) {
       i++;
   }

   if(i === 0 || i + 1 >= arr.length) {
       return false;
   }

   while(i < arr.length && i + 1 < arr.length) {
    if(arr[i] <= arr[i++ +1]) {
        return false;
    }
  }

  return true;
};

console.log(validMountainArray([2,1]));
console.log(validMountainArray([3,5,5]));
console.log(validMountainArray([0,3,2,1]));