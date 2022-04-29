/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if(node == null) {
            return null;
        }
        
        Node cloneNode = new Node(node.val);
        Queue<Node> needToExplore = new Queue<Node>();
        Dictionary<Node, Node> mappings = new Dictionary<Node, Node>();
        
        needToExplore.Enqueue(node);
        mappings.Add(node, cloneNode);
        
        while(needToExplore.Any()) {            
            var exploreNode = needToExplore.Dequeue();
            var theClone = mappings[exploreNode];
            foreach(var edge in exploreNode.neighbors) {
                if(!mappings.ContainsKey(edge)) {
                    needToExplore.Enqueue(edge);
                    Node newNode = new Node(edge.val);
                    mappings.Add(edge, newNode);
                }
                if(!theClone.neighbors.Contains(mappings[edge])) {              
                    theClone.neighbors.Add(mappings[edge]);
                    mappings[edge].neighbors.Add(theClone);
                }
            
            }                            
           
        }
        
        return cloneNode;
    }
}