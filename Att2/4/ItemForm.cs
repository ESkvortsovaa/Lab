using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class ItemForm : Form
    {
        public ItemForm()
        {
            InitializeComponent();
        }
        public double X { get; set; }
        public bool Remove { get; private set; } = false;
        private void OkBtn_Click(object sender, EventArgs e)
        {
            X = double.Parse(Input.Text);
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            Remove = true;
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            Input.Text = X.ToString();
        }
    }
}
