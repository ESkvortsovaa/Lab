using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace _2
{
    public partial class QueensForm : Form
    {
        public QueensForm()
        {
            InitializeComponent();
        }

        private void QueensForm_Load(object sender, EventArgs e)
        {
            DGV.RowCount = 8;
            for (int i = 0; i < 8; i++)
                DGV.Rows[i].Height = 30;
        }

        private void GetPositions_Click(object sender, EventArgs e)
        {
            QueensPosition queens = new QueensPosition();
            List<Position> positions = queens.GetPositions();
            SetDGV(positions);
        }
        private void SetDGV(List<Position>pos)
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    DGV[i, j].Value = "";
            for (int i = 0; i < pos.Count; i++)
                DGV[pos[i].X, pos[i].Y].Value = "  Q";
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            QueensPosition queens = new QueensPosition();
            List<Position> positions = queens.GetPositions(new Position(e.ColumnIndex,e.RowIndex),out bool res);
            if (res)
                SetDGV(positions);
            else
                MessageBox.Show("расстановка невозможна");
        }
    }
}
