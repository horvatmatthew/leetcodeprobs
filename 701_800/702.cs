/**
 * // This is ArrayReader's API interface.
 * // You should not implement it, or speculate about its implementation
 * class ArrayReader {
 *     public int Get(int index) {}
 * }
 */

class Solution {
    public int Search(ArrayReader reader, int target) {
        int left = 0;
        int right = 1;
        
        while(reader.Get(right) < target) {
            right *= 2;
        }
        
        
        while(left <= right) {
            int mid = left + (right - left) / 2;
            int num = reader.Get(mid);
            
            if(num == target) {
                return mid;
            }
            else if(num < target) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }
        
        
        return -1;
    }
}