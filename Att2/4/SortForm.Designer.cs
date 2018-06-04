namespace _4
{
    partial class SortForm
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.SortBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InputA = new System.Windows.Forms.TextBox();
            this.ChangeABtn = new System.Windows.Forms.Button();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnY = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX,
            this.ColumnY});
            this.DGV.Location = new System.Drawing.Point(12, 60);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(459, 463);
            this.DGV.TabIndex = 0;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(385, 12);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(86, 42);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // SortBtn
            // 
            this.SortBtn.Location = new System.Drawing.Point(12, 12);
            this.SortBtn.Name = "SortBtn";
            this.SortBtn.Size = new System.Drawing.Size(126, 42);
            this.SortBtn.TabIndex = 2;
            this.SortBtn.Text = "отсортировать";
            this.SortBtn.UseVisualStyleBackColor = true;
            this.SortBtn.Click += new System.EventHandler(this.SortBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "A =";
            // 
            // InputA
            // 
            this.InputA.Location = new System.Drawing.Point(305, 22);
            this.InputA.Name = "InputA";
            this.InputA.Size = new System.Drawing.Size(65, 22);
            this.InputA.TabIndex = 4;
            this.InputA.Text = "1";
            // 
            // ChangeABtn
            // 
            this.ChangeABtn.Location = new System.Drawing.Point(144, 12);
            this.ChangeABtn.Name = "ChangeABtn";
            this.ChangeABtn.Size = new System.Drawing.Size(126, 42);
            this.ChangeABtn.TabIndex = 5;
            this.ChangeABtn.Text = "применить A";
            this.ChangeABtn.UseVisualStyleBackColor = true;
            this.ChangeABtn.Click += new System.EventHandler(this.ChangeABtn_Click);
            // 
            // ColumnX
            // 
            this.ColumnX.HeaderText = "X";
            this.ColumnX.Name = "ColumnX";
            this.ColumnX.ReadOnly = true;
            this.ColumnX.Width = 170;
            // 
            // ColumnY
            // 
            this.ColumnY.HeaderText = "Y";
            this.ColumnY.Name = "ColumnY";
            this.ColumnY.ReadOnly = true;
            this.ColumnY.Width = 170;
            // 
            // SortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 535);
            this.Controls.Add(this.ChangeABtn);
            this.Controls.Add(this.InputA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SortBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.DGV);
            this.Name = "SortForm";
            this.Text = "Sort";
            this.Load += new System.EventHandler(this.SortForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button SortBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputA;
        private System.Windows.Forms.Button ChangeABtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnY;
    }
}

