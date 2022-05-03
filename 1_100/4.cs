public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int totalLength = nums1.Length+nums2.Length;
        int[] sortedArray = new int[totalLength];
        int position = 0;
        int num1Location = 0;
        int num2Location = 0;
        
        while(num1Location < nums1.Length || num2Location < nums2.Length) {
            if(num1Location >= nums1.Length) {
                sortedArray[position] = nums2[num2Location];
                num2Location++;
                position++;               
            } else if(num2Location >= nums2.Length) {
                sortedArray[position] = nums1[num1Location];
                num1Location++;
                position++;               
            } else if(nums1[num1Location] < nums2[num2Location]) {
                sortedArray[position] = nums1[num1Location];
                num1Location++;
                position++;
            } else if (nums2[num2Location] < nums1[num1Location]) {
                sortedArray[position] = nums2[num2Location];
                num2Location++;
                position++;
            } else if (nums1[num1Location] == nums2[num2Location]) {
                sortedArray[position] = nums1[num1Location];
                position++;
                num1Location++;
                sortedArray[position] = nums2[num2Location];
                position++;
                num2Location++;
            }
        }
        
        if(totalLength%2 == 0) {
            int center = (totalLength/2);
            int centerLeft = center -1;
            return (sortedArray[center] + sortedArray[centerLeft])/2.0;
            
        } else {
            int center = (totalLength/2);    
            return sortedArray[center];
        }
        
        

        
        
    }
}