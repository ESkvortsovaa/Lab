using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StringGraph
{
    public class GraphFile
    {
        public string Path { get; set; }
        public GraphFile(string path) => Path = path;
        public void Write(Graph graph)
        {
            FileStream file = new FileStream(Path, FileMode.Create);
            BinaryWriter writer = new BinaryWriter(file);
            int N = graph.Nodes.Count;
            writer.Write(N);
            List<Node> nodes = graph.Nodes;
            foreach (Node item in nodes)
            {
                WriteStr(item.Value, writer);
                writer.Write(item.X);
                writer.Write(item.Y);
            }
            for (int i = 0; i < N; i++)
                for (int j = i+1; j < N; j++)
                {
                    writer.Write(nodes[i].Nodes.Contains(nodes[j]));
                }
            writer.Close();
            file.Close();
        }
        public Graph Read()
        {
            FileStream file = new FileStream(Path,FileMode.Open);
            BinaryReader reader = new BinaryReader(file);
            Graph graph = new Graph();
            int N = reader.ReadInt32();
            for (int i = 0; i < N; i++)
            {
                string s = ReadStr(reader);
                int X = reader.ReadInt32();
                int Y = reader.ReadInt32();
                graph.AddNode(s, X, Y);
            }
            for (int i = 0; i < N; i++)
                for (int j = i+1; j < N; j++)
                    if(reader.ReadBoolean())
                    {
                        graph.Nodes[i].AddEdgeTo(graph.Nodes[j]);
                    }
            reader.Close();
            file.Close();
            return graph;
        }
        private void WriteStr(string s, BinaryWriter writer)
        {
            writer.Write(s.Length);
            Encoder encoder = Encoding.Unicode.GetEncoder();
            byte[] bytes = new byte[s.Length * 2];
            encoder.GetBytes(s.ToCharArray(), 0, s.Length, bytes, 0, true);
            writer.Write(bytes);
        }
        private string ReadStr(BinaryReader reader)
        {
            int N = reader.ReadInt32();
            byte[] bytes = reader.ReadBytes(N * 2);
            Decoder decoder = Encoding.Unicode.GetDecoder();
            char[] data = new char[N];
            decoder.GetChars(bytes, 0, N * 2, data, 0);
            return new string(data);
        }
    }
}
