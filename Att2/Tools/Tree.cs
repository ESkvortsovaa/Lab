using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{

    public class Node
    {
        public Node Parent { get; set; }
        public double Value { get; set; }
        public List<Node> Nodes { get; set; }
        public int GetCount(double X, int K)
        {
            int Count = (K == 0&& Value<X) ? 1 : 0;
            for (int i = 0; i < Nodes.Count; i++)
                Count += Nodes[i].GetCount(X, Math.Max(K - 1, 0));
            return Count;
        }
        public int GetLevelCount()
        {
            if (Nodes.Count == 0)
                return 1;
            else
            {
                int max = 0;
                for (int i = 0; i < Nodes.Count; i++)
                    max = Math.Max(max, Nodes[i].GetLevelCount());
                return max+1;
            }
        }

        public Node(double value = 0,Node parent = null)
        {
            Value = value;
            Parent = parent;
            Nodes = new List<Node>();
        }
        public void Add(double value)
        {
            Nodes.Add(new Node(value, this));
        }
    }
    public class Tree
    {
        public Node Root { get; set; }
        public int GetCount(double X, int K)
        {
            if (K < 0)
                throw new ArgumentException();
            return Root.GetCount(X, K);
        }

        public int GetLevelCount() => Root.GetLevelCount();

        public Tree()
        {
            Root = new Node();
        }
    }
}
