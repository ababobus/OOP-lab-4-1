namespace WindowsFormsApp1
{
    partial class Form1
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
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.CtrlCheckBox = new System.Windows.Forms.CheckBox();
            this.OverlayCheckBox = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(1, 135);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(1102, 681);
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            this.PictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            this.PictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseClick);
            // 
            // CtrlCheckBox
            // 
            this.CtrlCheckBox.AutoSize = true;
            this.CtrlCheckBox.Location = new System.Drawing.Point(59, 28);
            this.CtrlCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CtrlCheckBox.Name = "CtrlCheckBox";
            this.CtrlCheckBox.Size = new System.Drawing.Size(76, 24);
            this.CtrlCheckBox.TabIndex = 2;
            this.CtrlCheckBox.Text = "CTRL";
            this.CtrlCheckBox.UseVisualStyleBackColor = true;
            // 
            // OverlayCheckBox
            // 
            this.OverlayCheckBox.AutoSize = true;
            this.OverlayCheckBox.Location = new System.Drawing.Point(59, 76);
            this.OverlayCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OverlayCheckBox.Name = "OverlayCheckBox";
            this.OverlayCheckBox.Size = new System.Drawing.Size(112, 24);
            this.OverlayCheckBox.TabIndex = 3;
            this.OverlayCheckBox.Text = "OVERLAY";
            this.OverlayCheckBox.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(1, 135);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 816);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.OverlayCheckBox);
            this.Controls.Add(this.CtrlCheckBox);
            this.Controls.Add(this.PictureBox);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.CheckBox CtrlCheckBox;
        private System.Windows.Forms.CheckBox OverlayCheckBox;
        private System.Windows.Forms.ListBox listBox1;
    }
}

