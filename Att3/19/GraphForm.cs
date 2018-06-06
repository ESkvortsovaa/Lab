using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StringGraph;
using DrawGraph;
namespace _19
{
    public partial class GraphForm : Form
    {
        public GraphForm()
        {
            InitializeComponent();
        }
        Graph A;
        Graph B;
        DrawGr DrawA;
        DrawGr DrawB;
        private void Open_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    GraphFile file = new GraphFile(openFileDialog.FileName);
                    if(sender == OpenA)
                    {
                        A = file.Read();
                        DrawA.Graph = A;
                        InputA.Image = DrawA.Draw();
                    }
                    else
                    {
                        B = file.Read();
                        DrawB.Graph = B;
                        InputB.Image = DrawB.Draw();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    GraphFile file = new GraphFile(saveFileDialog.FileName);
                    if (sender == SaveA)
                    {
                        file.Write(A);
                    }
                    else
                    {
                        file.Write(B);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        Node SelectedNode = null;
        List<string> wasA = new List<string>();
        List<string> wasB = new List<string>();

        private void Input_MouseClick(object sender, MouseEventArgs e)
        {
            DrawGr work = sender == InputA ? DrawA : DrawB;
            Graph graph = work.Graph;
            if(NodeBtn.Checked)
            {
                List<string> T = sender == InputA ? wasA : wasB;
                if(AddBtn.Checked&&work.Empty(e.X,e.Y))
                {
                    NodeText text = new NodeText();
                    try
                    {
                        if(text.ShowDialog() == DialogResult.OK)
                        {
                            if (!T.Contains(text.S))
                            {
                                T.Add(text.S);
                                graph.AddNode(text.S, e.X, e.Y);
                                ((PictureBox)sender).Image = work.Draw();
                            }
                            else
                                MessageBox.Show("Имя занято");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error");
                    }
                }
                if(RemoveBtn.Checked)
                {
                    SelectedNode = work.GetNode(e.X, e.Y);
                    T.Remove(SelectedNode.Value);
                    graph.RemoveNode(SelectedNode);
                    ((PictureBox)sender).Image = work.Draw();
                    SelectedNode = null;
                }
            }
            else
            {
                if (SelectedNode == null || SelectedNode.Graph != graph)
                    SelectedNode = work.GetNode(e.X, e.Y);
                else
                {
                    Node second = work.GetNode(e.X, e.Y);
                    if (second != null&& second!= SelectedNode)
                    {
                        if (AddBtn.Checked)
                        {
                            SelectedNode.AddEdgeTo(second);
                        }
                        else
                        {
                            SelectedNode.RemoveEdgeTo(second);
                        }
                        ((PictureBox)sender).Image = work.Draw();
                        
                    }
                    SelectedNode = null;
                }
            }
        }

        private void GraphForm_Load(object sender, EventArgs e)
        {
            A = new Graph();
            B = new Graph();
            DrawA = new DrawGr(InputA.Size, A);
            DrawB = new DrawGr(InputB.Size, B);
        }

        private void Input_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (NodeBtn.Checked&&AddBtn.Checked)
            {
                DrawGr work = sender == InputA ? DrawA : DrawB;
                Graph graph = work.Graph;
                List<string> T = sender == InputA ? wasA : wasB;
                SelectedNode = work.GetNode(e.X, e.Y);
                if(SelectedNode!=null)
                {
                    NodeText text = new NodeText
                    {
                        S = SelectedNode.Value
                    };
                    try
                    {
                        if (text.ShowDialog() == DialogResult.OK)
                        {
                            if (!T.Contains(text.S)||text.S == SelectedNode.Value)
                            {
                                T.Remove(SelectedNode.Value);
                                T.Add(text.S);
                                SelectedNode.Value = text.S;
                                ((PictureBox)sender).Image = work.Draw();
                            }
                            else
                                MessageBox.Show("Имя занято");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
        }

        private void WorkBtn_Click(object sender, EventArgs e)
        {
            A.Compare(B);
            InputA.Image = DrawA.Draw();
            InputB.Image = DrawB.Draw();
        }
    }
}
