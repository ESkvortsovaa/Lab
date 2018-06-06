using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19
{
    public partial class NodeText : Form
    {
        public NodeText()
        {
            InitializeComponent();
        }

        private void NodeText_Load(object sender, EventArgs e) => Input.Text = S;
        public String S { get; set; }
        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Input.Text))
                throw new Exception();
            S = Input.Text;
        }
    }
}
