public class Solution {
    public string[] FindRestaurant(string[] list1, string[] list2) {
        if(list1 == null || list2 == null) {
            return null;
        }
        
        List<string> commonInterests = new List<string>();
        Dictionary<string, int> interests = new Dictionary<string, int>();
        int minIndex = Int32.MaxValue;
        
        for(int i = 0; i < list1.Length; i++)
        {
          interests.Add(list1[i], i);   
        }
        
        for(int i = 0; i < list2.Length;i++) {
            if(interests.ContainsKey(list2[i])) {
                var index = interests[list2[i]] + i;
                if(index < minIndex) {
                    commonInterests.Clear();
                    commonInterests.Add(list2[i]);
                    minIndex = index;
                } else if(index == minIndex) {
                    commonInterests.Add(list2[i]);
                }
            }
        }   
            return commonInterests.ToArray();
         
    }
}