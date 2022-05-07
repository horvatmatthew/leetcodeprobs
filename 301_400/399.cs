public class Solution {
    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries) {
        double[] res = new double[queries.Count];
        Dictionary<string,string> root = new Dictionary<string,string>();
        Dictionary<string,double> dist = new Dictionary<string,double>();
        
        for(int i=0;i<equations.Count;i++)
        {
            string r1=Find(equations[i][0]);
            string r2=Find(equations[i][1]);
            
            root[r1]=r2;
            dist[r1]=dist[equations[i][1]] * values[i] / dist[equations[i][0]];
        }
        
        for(int i=0;i<queries.Count;i++)
        {
            if(!root.ContainsKey(queries[i][0]) || !root.ContainsKey(queries[i][1]))
            {
                res[i]=-1.0;
                continue;
            }
            
            string r1 = Find(queries[i][0]);
            string r2 = Find(queries[i][1]);
            if(!r1.Equals(r2))
            {
                res[i]=-1.0;
                continue;
            }
            res[i]= (double) dist[queries[i][0]]/dist[queries[i][1]];
        }
        
        string Find(string s)
        {
            if(!root.ContainsKey(s))
            {
                root.Add(s,s);
                dist.Add(s,1.0);
                return s;
            }
            
            string lastP = root[s];
            if(lastP.Equals(s)) return s;
            
            string p = Find(lastP);
            root[s]=p;
            dist[s]=dist[s]*dist[lastP];
            return p;
        }
        
        return res;
    }
}
}