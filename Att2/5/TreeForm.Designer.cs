namespace _5
{
    partial class TreeForm
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
            this.components = new System.ComponentModel.Container();
            this.InputX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputY = new System.Windows.Forms.TextBox();
            this.GetCountBtn = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputX
            // 
            this.InputX.Location = new System.Drawing.Point(48, 22);
            this.InputX.Name = "InputX";
            this.InputX.Size = new System.Drawing.Size(100, 22);
            this.InputX.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "X = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "K = ";
            // 
            // InputY
            // 
            this.InputY.Location = new System.Drawing.Point(193, 22);
            this.InputY.Name = "InputY";
            this.InputY.Size = new System.Drawing.Size(100, 22);
            this.InputY.TabIndex = 3;
            // 
            // GetCountBtn
            // 
            this.GetCountBtn.Location = new System.Drawing.Point(299, 17);
            this.GetCountBtn.Name = "GetCountBtn";
            this.GetCountBtn.Size = new System.Drawing.Size(170, 33);
            this.GetCountBtn.TabIndex = 5;
            this.GetCountBtn.Text = " посчитать кол-во";
            this.GetCountBtn.UseVisualStyleBackColor = true;
            this.GetCountBtn.Click += new System.EventHandler(this.GetCountBtn_Click);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(475, 25);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(12, 17);
            this.Output.TabIndex = 6;
            this.Output.Text = " ";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddBtn,
            this.RemoveBtn});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(146, 52);
            // 
            // AddBtn
            // 
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(145, 24);
            this.AddBtn.Text = "Добавить";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(145, 24);
            this.RemoveBtn.Text = "Удалить";
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // TreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 406);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.GetCountBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputX);
            this.Name = "TreeForm";
            this.Text = "Tree";
            this.Load += new System.EventHandler(this.TreeForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TreeForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TreeForm_MouseDown);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox InputX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputY;
        private System.Windows.Forms.Button GetCountBtn;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AddBtn;
        private System.Windows.Forms.ToolStripMenuItem RemoveBtn;
    }
}

