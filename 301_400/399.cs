public class Solution
{
    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
    {
        var uf = new UnionFind();
        for (var i = 0; i < equations.Count; i++)
        {
            uf.Union(equations[i][0], equations[i][1], values[i]);
        }

        var answers = new double[queries.Count];
        for (var i = 0; i < queries.Count; i++)
        {
            var node1 = uf.Find(queries[i][0]);
            var node2 = uf.Find(queries[i][1]);

            if (node1 == null || node2 == null || !node1.Divisor.Equals(node2.Divisor))
            {
                answers[i] = -1.0;
            }
            else
            {
                answers[i] = node1.Quotient / node2.Quotient;
            }
        }

        return answers;
    }
}

public class Node
{
    public string Divisor;
    public double Quotient;

    public Node(string divisor, double quotient)
    {
        Divisor = divisor;
        Quotient = quotient;
    }
}

public class UnionFind
{
    private Dictionary<string, Node> _map;

    public UnionFind()
    {
        _map = new Dictionary<string, Node>();
    }

    public Node Find(string dividend)
    {
        if (!_map.ContainsKey(dividend)) return null;

        var node = _map[dividend];
        if (!node.Divisor.Equals(dividend))
        {
            var nextNode = Find(node.Divisor);
            node.Divisor = nextNode.Divisor;
            node.Quotient *= nextNode.Quotient;
        }

        return node;
    }

    public void Union(string dividend, string divisor, double quotient)
    {
        var hasDividend = _map.ContainsKey(dividend);
        var hasDivisor = _map.ContainsKey(divisor);

        if (!hasDividend && !hasDivisor)
        {
            _map[dividend] = new Node(divisor, quotient);
            _map[divisor] = new Node(divisor, 1.0);
        }
        else if (!hasDividend)
        {
            _map[dividend] = new Node(divisor, quotient);
        }
        else if (!hasDivisor)
        {
            _map[divisor] = new Node(dividend, 1.0 / quotient);
        }
        else
        {
            var node1 = Find(dividend);
            var node2 = Find(divisor);

            node1.Divisor = node2.Divisor;
            node1.Quotient = quotient / node1.Quotient * node2.Quotient;
        }
    }
}