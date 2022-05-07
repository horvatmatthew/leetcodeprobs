public class Solution {
    public string SmallestStringWithSwaps(string s, IList<IList<int>> pairs) {        
        var indexes = Enumerable.Range(0, s.Length).ToArray();
        var uf = new UF(indexes);
        foreach (var pair in pairs) {
            uf.Union(pair[0], pair[1]);
        }
        
           var sorted = indexes
            .GroupBy(x => uf.Parent(x))
            .ToDictionary(x => x.Key, x => x.OrderByDescending(x => s[x]).ToList());
        
        return string.Join("", indexes.Select(x => {
            var idx = uf.Parent(x);
            var result = sorted[idx].Last();
            sorted[idx].RemoveAt(sorted[idx].Count - 1);
            return s[result];
        }));
    }
  
}

    public class UF {
        private int[] parent;
        public UF(int[] indexes) => parent = indexes.Select(x => x).ToArray();
        public int Parent(int x) {
            if (parent[x] == x) {
                return x;
            }
            
            parent[x] = Parent(parent[x]);
            return parent[x];
        }
        
        public void Union(int x, int y) {
            var px = Parent(x);
            var py = Parent(y);
            if (px == py) {
                return;
            }
            
            // input is pretty small, no need for union by rank,
            // we already do path compression, so let's just link
            // them willy-nilly
            parent[px] = py;
        }
    }