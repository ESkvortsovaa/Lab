using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;

namespace _3._1
{
    public partial class BracesForm : Form
    {
        public BracesForm()
        {
            InitializeComponent();
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Input.Text))
                Output.Text = "";
            else
            {
                BracesChecker braces = new BracesChecker(Input.Text);
                if (braces.Check())
                    Output.Text = "расстановка скобок верна";
                else 
                    Output.Text = "расстановка скобок не верна";
            }
        }
    }
}
