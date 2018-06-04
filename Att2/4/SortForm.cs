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

namespace _4
{
    public partial class SortForm : Form
    {
        public SortForm()
        {
            InitializeComponent();
        }
        List<Measure> list = new List<Measure>();
        double A = 1;
        private void AddBtn_Click(object sender, EventArgs e)
        {
            ItemForm item = new ItemForm();
            try
            {
                if (item.ShowDialog() == DialogResult.OK)
                {
                    if (!item.Remove)
                        list.Add(new Measure(item.X, A));
                    SetDGV();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка ввода");
            }
        }
        private void SetDGV()
        {
            DGV.RowCount = list.Count;
            for (int i = 0; i < list.Count; i++)
            {
                DGV[0, i].Value = list[i].X;
                DGV[1, i].Value = list[i].Y;
            }
        }

        private void ChangeABtn_Click(object sender, EventArgs e)
        {
            try
            {
                A = double.Parse(InputA.Text);
                for (int i = 0; i < list.Count; i++)
                    list[i].A = A;
                SetDGV();
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка ввода");
            }
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ItemForm itemForm = new ItemForm();
                itemForm.X = list[e.RowIndex].X;
                if (itemForm.ShowDialog() == DialogResult.OK)
                    if (itemForm.Remove)
                        list.RemoveAt(e.RowIndex);
                    else
                        list[e.RowIndex].X = itemForm.X;
                SetDGV();
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка ввода");
            }
        }

        private void SortForm_Load(object sender, EventArgs e)
        {
            SetDGV();
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            Sorts sorts = new Sorts();
            sorts.QuicSort(list);
            list.Reverse();
            SetDGV();
        }
    }
}
