using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringGraph
{
    public class Node
    {
        public Graph Graph { get; internal set; }
        public string Value { get; set; }
        public List<Node> Nodes { get; set; } = new List<Node>();
        public List<bool> Nodeflags { get; set; } = new List<bool>();
        public bool Was { get; set; } = false;
        public int X { get; set; }
        public int Y { get; set; }
        internal Node(string value, int x, int y,Graph gr)
        {
            Value = value;
            X = x;
            Y = y;
            Graph = gr;
        }
        public void AddEdgeTo(Node node)
        {
            if (node.Graph != Graph)
                throw new ArgumentException();
            if (Nodes.Contains(node))
                return;
            Nodes.Add(node);
            Nodeflags.Add(false);
            node.Nodes.Add(this);
            node.Nodeflags.Add(false);
        }
        public bool RemoveEdgeTo(Node node)
        {
            if (node.Graph != Graph)
                throw new ArgumentException();
            if (!Nodes.Contains(node))
                return false;
            Nodeflags.RemoveAt(Nodes.IndexOf(node));
            Nodes.Remove(node);
            node.Nodeflags.RemoveAt(node.Nodes.IndexOf(this));
            node.Nodes.Remove(this);
            return true;
        }
        internal void RemoveAllEdges()
        {
            for (int i = 0; i < Nodes.Count; i++)
            {
                Nodes[i].Nodeflags.RemoveAt(Nodes[i].Nodes.IndexOf(this));
                Nodes[i].Nodes.Remove(this);
            }
            Nodes.Clear();
        }
    }
}
