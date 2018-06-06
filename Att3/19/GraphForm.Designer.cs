namespace _19
{
    partial class GraphForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RemoveBtn = new System.Windows.Forms.RadioButton();
            this.AddBtn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EdgeBtn = new System.Windows.Forms.RadioButton();
            this.NodeBtn = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.InputA = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.InputB = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.откытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenA = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenB = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveA = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveB = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.WorkBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputA)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputB)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RemoveBtn);
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(94, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.AutoSize = true;
            this.RemoveBtn.Location = new System.Drawing.Point(6, 42);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(65, 17);
            this.RemoveBtn.TabIndex = 2;
            this.RemoveBtn.TabStop = true;
            this.RemoveBtn.Text = "удалить";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            this.AddBtn.AutoSize = true;
            this.AddBtn.Checked = true;
            this.AddBtn.Location = new System.Drawing.Point(6, 19);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(72, 17);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.TabStop = true;
            this.AddBtn.Text = "добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EdgeBtn);
            this.groupBox2.Controls.Add(this.NodeBtn);
            this.groupBox2.Location = new System.Drawing.Point(112, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(94, 72);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // EdgeBtn
            // 
            this.EdgeBtn.AutoSize = true;
            this.EdgeBtn.Location = new System.Drawing.Point(6, 42);
            this.EdgeBtn.Name = "EdgeBtn";
            this.EdgeBtn.Size = new System.Drawing.Size(54, 17);
            this.EdgeBtn.TabIndex = 2;
            this.EdgeBtn.TabStop = true;
            this.EdgeBtn.Text = "грань";
            this.EdgeBtn.UseVisualStyleBackColor = true;
            // 
            // NodeBtn
            // 
            this.NodeBtn.AutoSize = true;
            this.NodeBtn.Checked = true;
            this.NodeBtn.Location = new System.Drawing.Point(6, 19);
            this.NodeBtn.Name = "NodeBtn";
            this.NodeBtn.Size = new System.Drawing.Size(48, 17);
            this.NodeBtn.TabIndex = 1;
            this.NodeBtn.TabStop = true;
            this.NodeBtn.Text = "ноду";
            this.NodeBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.InputA);
            this.groupBox3.Location = new System.Drawing.Point(18, 105);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(410, 452);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // InputA
            // 
            this.InputA.Location = new System.Drawing.Point(6, 19);
            this.InputA.Name = "InputA";
            this.InputA.Size = new System.Drawing.Size(394, 399);
            this.InputA.TabIndex = 0;
            this.InputA.TabStop = false;
            this.InputA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Input_MouseClick);
            this.InputA.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Input_MouseDoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.InputB);
            this.groupBox4.Location = new System.Drawing.Point(480, 105);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(410, 452);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // InputB
            // 
            this.InputB.Location = new System.Drawing.Point(6, 19);
            this.InputB.Name = "InputB";
            this.InputB.Size = new System.Drawing.Size(394, 399);
            this.InputB.TabIndex = 0;
            this.InputB.TabStop = false;
            this.InputB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Input_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(902, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.откытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "файл";
            // 
            // откытьToolStripMenuItem
            // 
            this.откытьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenA,
            this.OpenB});
            this.откытьToolStripMenuItem.Name = "откытьToolStripMenuItem";
            this.откытьToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.откытьToolStripMenuItem.Text = "откыть";
            // 
            // OpenA
            // 
            this.OpenA.Name = "OpenA";
            this.OpenA.Size = new System.Drawing.Size(82, 22);
            this.OpenA.Text = "A";
            this.OpenA.Click += new System.EventHandler(this.Open_Click);
            // 
            // OpenB
            // 
            this.OpenB.Name = "OpenB";
            this.OpenB.Size = new System.Drawing.Size(82, 22);
            this.OpenB.Text = "B";
            this.OpenB.Click += new System.EventHandler(this.Open_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveA,
            this.SaveB});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.сохранитьToolStripMenuItem.Text = "сохранить";
            // 
            // SaveA
            // 
            this.SaveA.Name = "SaveA";
            this.SaveA.Size = new System.Drawing.Size(82, 22);
            this.SaveA.Text = "A";
            this.SaveA.Click += new System.EventHandler(this.Save_Click);
            // 
            // SaveB
            // 
            this.SaveB.Name = "SaveB";
            this.SaveB.Size = new System.Drawing.Size(82, 22);
            this.SaveB.Text = "B";
            this.SaveB.Click += new System.EventHandler(this.Save_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Граф (*.dat)|*.dat|Все файлы|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Граф (*.dat)|*.dat|Все файлы|*.*";
            // 
            // WorkBtn
            // 
            this.WorkBtn.Location = new System.Drawing.Point(801, 27);
            this.WorkBtn.Name = "WorkBtn";
            this.WorkBtn.Size = new System.Drawing.Size(89, 36);
            this.WorkBtn.TabIndex = 7;
            this.WorkBtn.Text = "совмещение";
            this.WorkBtn.UseVisualStyleBackColor = true;
            this.WorkBtn.Click += new System.EventHandler(this.WorkBtn_Click);
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 630);
            this.Controls.Add(this.WorkBtn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GraphForm";
            this.Text = "Graph";
            this.Load += new System.EventHandler(this.GraphForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InputA)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InputB)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RemoveBtn;
        private System.Windows.Forms.RadioButton AddBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton EdgeBtn;
        private System.Windows.Forms.RadioButton NodeBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox InputA;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox InputB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem откытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenA;
        private System.Windows.Forms.ToolStripMenuItem OpenB;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveA;
        private System.Windows.Forms.ToolStripMenuItem SaveB;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button WorkBtn;
    }
}

