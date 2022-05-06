public class Solution {
    public IList<IList<int>> GetSkyline(int[][] buildings)
    {
        var result = new List<IList<int>>();
        var skyLines = new List<int[]>();
        for (int i = 0; i < buildings.Length; i++)
        {
            skyLines.Add(new int[] { buildings[i][0], -buildings[i][2] });
            skyLines.Add(new int[] { buildings[i][1], buildings[i][2] });
        }
        
        skyLines.Sort((x, y) =>
        {
            if (x[0] != y[0])
                return x[0].CompareTo(y[0]);
            return x[1].CompareTo(y[1]);
        });
        
        SortedSet<int> sortedSet = new SortedSet<int>();
        Dictionary<int, int> dic = new Dictionary<int, int>();
        var preHeight = 0;
        for (int i = 0; i < skyLines.Count; i++)
        {
            if (skyLines[i][1] < 0)
            {
                var currentSky = -skyLines[i][1];
                if (!dic.ContainsKey(currentSky))
                    dic.Add(currentSky, 0);
                
                sortedSet.Add(currentSky);
                dic[currentSky]++;
            }
            else
            {
                var currentSky = skyLines[i][1];
                dic[currentSky]--;
                
                if (dic[currentSky] <= 0)
                    sortedSet.Remove(currentSky);
            }
            int curHeight = sortedSet.Max;
            if (preHeight != curHeight)
            {
                result.Add(new int[] { skyLines[i][0], curHeight });
                preHeight = curHeight;
            }
        }
        
        return result;
    }
}