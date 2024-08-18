namespace _2212410_WDF56
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.grbGiotinh = new System.Windows.Forms.GroupBox();
            this.grbGiotinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(71, 21);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(57, 20);
            this.rbNam.TabIndex = 0;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            this.rbNam.CheckedChanged += new System.EventHandler(this.rbNam_CheckedChanged);
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(71, 73);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(45, 20);
            this.rbNu.TabIndex = 1;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            this.rbNu.CheckedChanged += new System.EventHandler(this.rbNu_CheckedChanged);
            // 
            // grbGiotinh
            // 
            this.grbGiotinh.Controls.Add(this.rbNam);
            this.grbGiotinh.Controls.Add(this.rbNu);
            this.grbGiotinh.Location = new System.Drawing.Point(36, 25);
            this.grbGiotinh.Name = "grbGiotinh";
            this.grbGiotinh.Size = new System.Drawing.Size(213, 114);
            this.grbGiotinh.TabIndex = 2;
            this.grbGiotinh.TabStop = false;
            this.grbGiotinh.Text = "Giới Tính";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 183);
            this.Controls.Add(this.grbGiotinh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbGiotinh.ResumeLayout(false);
            this.grbGiotinh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.GroupBox grbGiotinh;
    }
}

