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

public class Codec {
    // Encodes a tree to a single string.
    public string serialize(Node root) {
        
        if(root == null) return "N";
        Queue<Node> queue = new Queue<Node>();
        StringBuilder sb = new StringBuilder();
        
        queue.Enqueue(root);
        
        sb.Append(root.val + ",N");
        
        while(queue.Count > 0) {
            Node temp = queue.Dequeue();

            foreach(var child in temp.children) {
                queue.Enqueue(child);
                sb.Append("," + child.val);
            }
            
            sb.Append(",N");
        }
        
        Console.WriteLine(sb.ToString());
        
        return sb.ToString();
        
    }
	
    // Decodes your encoded data to tree.
    public Node deserialize(string data) {
       if(data == "N") return null;
        
        var items = data.Split(",");
        
        Queue<Node> queue = new Queue<Node>();
        var root = new Node(int.Parse(items[0].ToString()), new List<Node>());
        queue.Enqueue(root);
        
        var item = 2;
        
        while(queue.Count > 0) {
            var temp = queue.Dequeue();
            if(items[item].ToString() == "N") {
                item++;
            }
            
            while(item < items.Length && items[item].ToString() != "N") {
                var child = new Node(int.Parse(items[item]), new List<Node>());
                temp.children.Add(child);
                queue.Enqueue(child);
                item++;
            }
        }
        
        return root;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();