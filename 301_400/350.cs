public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        int[] first;
        int[] second;
        
        if(nums1.Length > nums2.Length) {
            first = nums1;
            second = nums2;
        } else {
            first = nums2;
            second = nums1;
        }
        
        Dictionary<int, int> set = new Dictionary<int, int>();
        for(int i = 0; i < first.Length;i++) {
            if(!set.ContainsKey(first[i])) {
                set.Add(first[i], 0);
            }
            
            set[first[i]]++;
        }

        List<int> intersection = new List<int>();
        for(int i = 0; i < second.Length;i++) {
            if(set.ContainsKey(second[i])) {
                if(set[second[i]] > 0) {
                    intersection.Add(second[i]);
                    set[second[i]]--;
                }
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