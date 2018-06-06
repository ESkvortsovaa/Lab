using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using StringGraph;

namespace DrawGraph
{
    public class DrawGr
    {
        Bitmap Image { get; set; }
        Graphics G;
        public int Height { get; set; }
        public int Width { get; set; }
        public Size Size
        {
            get => new Size(Width, Height);
            set
            {
                Width = value.Width;
                Height = value.Height;
            }
        }
        public Graph Graph { get; set; }
        private int R = 30;
        public DrawGr(int height, int width, Graph graph)
        {
            Height = height;
            Width = width;
            this.Graph = graph;
        }
        public DrawGr(Size size, Graph graph)
        {
            Size = size;
            this.Graph = graph;
        }
        public Bitmap Draw()
        {
            Image = new Bitmap(Width, Height);
            G = Graphics.FromImage(Image);
            Graph.ClearWas();
            foreach (Node item in Graph.Nodes)
                DrawNode(item);
            return Image;
        }


        private void DrawNode(Node node)
        {
            node.Was = true;
            for (int i = 0; i < node.Nodes.Count; i++)
                if(!node.Nodes[i].Was)
                {
                    G.DrawLine(node.Nodeflags[i]?Pens.Blue:Pens.Black, node.X, node.Y, node.Nodes[i].X, node.Nodes[i].Y);
                }
            G.FillEllipse(Brushes.Red, node.X - R, node.Y - R, 2 * R, 2 * R);
            float t = 0;
            string text = node.Value.ToString();
            do
            {
                t += (float)0.2;
            }
            while (G.MeasureString(text, new Font("Microsoft Sans Serif", t)).Width < R*3/2);
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            G.DrawString(text, new Font("Microsoft Sans Serif", t), Brushes.Black, new Rectangle(node.X - R, node.Y - R, 2 * R, 2 * R), sf);
        }
        public Node GetNode(int X, int Y)
        {
            foreach (Node item in Graph.Nodes)
            {
                if (Math.Pow(item.X - X, 2) + Math.Pow(item.Y - Y, 2) < R * R)
                    return item;
            }
            return null;
        }
        public bool Empty(int X, int Y)
        {
            foreach (Node item in Graph.Nodes)
            {
                if (Math.Pow(item.X - X, 2) + Math.Pow(item.Y - Y, 2) < 4 * R)
                    return false;
            }
            return true;
        }
    }
}
