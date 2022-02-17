/* var moveFromEnd = function(nums, pointer) {
    for(let i = nums.length-1; i > pointer;i--) {
        nums[i] = nums[i-1];            
    }
    return nums;
}

var merge = function(nums1, m, nums2, n) {
    let first = 0;
    let second = 0;

    while(first < nums1.length && second < n) {
        if(nums1[first] === 0 && first > m) {
            nums1[first] = nums2[second];
            first++;            
            second++;
        }
        else if(nums1[first] < nums2[second]) {            
            first++;            
        } 
        else if(nums1[first] == nums2[second]) {   
            nums1 = moveFromEnd(nums1, first);
            nums1[first] = nums2[second];
            second++;
            first++;
        } else {
            nums1 = moveFromEnd(nums1, first);
            nums1[first] = nums2[second];
            second++;
        }
    }

    return nums1;

}; */

var merge = function(nums1, m, nums2, n) {
   let endPtr = nums1.length -1;
   let first = m-1;
   let second = n-1;

   while(endPtr >= 0) {
      if(first < 0) {
          nums1[endPtr] = nums2[second];
          second--;
      } else if (second < 0) {
        nums1[endPtr] = nums1[first];
        first--;
      } else {
        if(nums1[first]  > nums2[second]) {
            nums1[endPtr] = nums1[first];        
            first--;  
          } else {
              nums1[endPtr] = nums2[second];
            second--;
        }
      }
      endPtr--;
    }

    return nums1;
}

console.log(merge([0], 0, [1], 1));