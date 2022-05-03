/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<IList<int>> LevelOrder(Node root) {
        var result = new List<IList<int>>();
        if (root == null) return result;

        var queue = new Queue<Node>();
        queue.Enqueue(root);

        while (queue.Any()) {
            var size = queue.Count;

            var tempList = new List<int>();
            for (int s = 0; s < size; s++) {
                var cur = queue.Dequeue();
                tempList.Add(cur.val);

                foreach (var child in cur.children) {
                    queue.Enqueue(child);
                }
            }
            result.Add(tempList);
        }
        return result;
    }
}