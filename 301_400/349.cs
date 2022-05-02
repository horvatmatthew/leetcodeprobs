public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> set = new HashSet<int>();
        for(int i = 0; i < nums1.Length;i++) {
            set.Add(nums1[i]);
        }
        
        HashSet<int> intersection = new HashSet<int>();
        for(int i = 0; i < nums2.Length;i++) {
            if(set.Contains(nums2[i])) {
                intersection.Add(nums2[i]);
            }
        }
        
        int[]  result = new int[intersection.Count];
        int index = 0;
        foreach(var item in intersection) {
            result[index] = item;
            index++;
        }
        
        return result;
    }
}