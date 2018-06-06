using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringGraph
{
    public class Graph
    {
        public List<Node> Nodes { get; set; } = new List<Node>();
        public void AddNode(string value, int x, int y) => Nodes.Add(new Node(value, x, y, this));
        public void RemoveNode(Node node)
        {
            if (node.Graph != this)
                throw new ArgumentException();
            node.RemoveAllEdges();
            Nodes.Remove(node);
        }
        public void ClearWas()
        {
            for (int i = 0; i < Nodes.Count; i++)
            {
                Nodes[i].Was = false;
            }
        }
        public void ClearEdges()
        {
            for (int i = 0; i < Nodes.Count; i++)
            {
                for (int j = 0; j < Nodes[i].Nodeflags.Count; j++)
                {
                    Nodes[i].Nodeflags[j] = false;
                }
            }
        }
        public void Compare(Graph graph)
        {
            ClearWas();
            ClearEdges();
            graph.ClearEdges();
            graph.ClearWas();
            for (int i = 0; i < Nodes.Count; i++)
                for (int j = 0; j < graph.Nodes.Count; j++)
                    if (Nodes[i].Value == graph.Nodes[j].Value && !Nodes[i].Was)
                    {
                        Queue<Node> queue = new Queue<Node>();
                        queue.Enqueue(Nodes[i]);
                        queue.Enqueue(graph.Nodes[j]);
                        while (queue.Count!= 0)
                        {
                            Node A = queue.Dequeue();
                            Node B = queue.Dequeue();
                            A.Was = true;
                            B.Was = true;
                            for (int n = 0; n < A.Nodes.Count; n++)
                                for (int k = 0; k < B.Nodes.Count; k++)
                                    if (A.Nodes[n].Value == B.Nodes[k].Value && !A.Nodes[n].Was)
                                    {
                                        A.Nodeflags[n] = true;
                                        B.Nodeflags[k] = true;
                                        queue.Enqueue(A.Nodes[n]);
                                        queue.Enqueue(B.Nodes[k]);
                                    }
                        }
                    }
        }
    }
}
