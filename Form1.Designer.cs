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
            this.Figures = new System.Windows.Forms.PictureBox();
            this.CtrlCheckBox = new System.Windows.Forms.CheckBox();
            this.OverlayCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Figures)).BeginInit();
            this.SuspendLayout();
            // 
            // Figures
            // 
            this.Figures.Location = new System.Drawing.Point(1, 135);
            this.Figures.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Figures.Name = "Figures";
            this.Figures.Size = new System.Drawing.Size(1102, 681);
            this.Figures.TabIndex = 1;
            this.Figures.TabStop = false;
            this.Figures.Paint += new System.Windows.Forms.PaintEventHandler(this.Figures_Paint);
            this.Figures.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Figures_MouseClick);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 816);
            this.Controls.Add(this.OverlayCheckBox);
            this.Controls.Add(this.CtrlCheckBox);
            this.Controls.Add(this.Figures);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Figures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Figures;
        private System.Windows.Forms.CheckBox CtrlCheckBox;
        private System.Windows.Forms.CheckBox OverlayCheckBox;
    }
}

