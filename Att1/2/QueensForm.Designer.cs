namespace _2
{
    partial class QueensForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV = new System.Windows.Forms.DataGridView();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GetPositions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AllowUserToResizeColumns = false;
            this.DGV.AllowUserToResizeRows = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.ColumnHeadersVisible = false;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A,
            this.B,
            this.C,
            this.D,
            this.E,
            this.F,
            this.G,
            this.H});
            this.DGV.Location = new System.Drawing.Point(12, 55);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(325, 300);
            this.DGV.TabIndex = 3;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // A
            // 
            this.A.Frozen = true;
            this.A.HeaderText = "A";
            this.A.Name = "A";
            this.A.ReadOnly = true;
            this.A.Width = 30;
            // 
            // B
            // 
            this.B.Frozen = true;
            this.B.HeaderText = "B";
            this.B.Name = "B";
            this.B.ReadOnly = true;
            this.B.Width = 30;
            // 
            // C
            // 
            this.C.Frozen = true;
            this.C.HeaderText = "C";
            this.C.Name = "C";
            this.C.ReadOnly = true;
            this.C.Width = 30;
            // 
            // D
            // 
            this.D.Frozen = true;
            this.D.HeaderText = "D";
            this.D.Name = "D";
            this.D.ReadOnly = true;
            this.D.Width = 30;
            // 
            // E
            // 
            this.E.Frozen = true;
            this.E.HeaderText = "E";
            this.E.Name = "E";
            this.E.ReadOnly = true;
            this.E.Width = 30;
            // 
            // F
            // 
            this.F.Frozen = true;
            this.F.HeaderText = "F";
            this.F.Name = "F";
            this.F.ReadOnly = true;
            this.F.Width = 30;
            // 
            // G
            // 
            this.G.Frozen = true;
            this.G.HeaderText = "G";
            this.G.Name = "G";
            this.G.ReadOnly = true;
            this.G.Width = 30;
            // 
            // H
            // 
            this.H.Frozen = true;
            this.H.HeaderText = "H";
            this.H.Name = "H";
            this.H.ReadOnly = true;
            this.H.Width = 30;
            // 
            // GetPositions
            // 
            this.GetPositions.Location = new System.Drawing.Point(12, 12);
            this.GetPositions.Name = "GetPositions";
            this.GetPositions.Size = new System.Drawing.Size(186, 37);
            this.GetPositions.TabIndex = 4;
            this.GetPositions.Text = "Получить расстановку";
            this.GetPositions.UseVisualStyleBackColor = true;
            this.GetPositions.Click += new System.EventHandler(this.GetPositions_Click);
            // 
            // QueensForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 371);
            this.Controls.Add(this.GetPositions);
            this.Controls.Add(this.DGV);
            this.Name = "QueensForm";
            this.Text = "Queens";
            this.Load += new System.EventHandler(this.QueensForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn D;
        private System.Windows.Forms.DataGridViewTextBoxColumn E;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
        private System.Windows.Forms.DataGridViewTextBoxColumn G;
        private System.Windows.Forms.DataGridViewTextBoxColumn H;
        private System.Windows.Forms.Button GetPositions;
    }
}

