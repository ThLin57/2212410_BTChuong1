namespace _2212410_WDF57
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
            this.button = new System.Windows.Forms.Button();
            this.buttonFlat = new System.Windows.Forms.Button();
            this.ckMauChu = new System.Windows.Forms.CheckBox();
            this.ckbMauNen = new System.Windows.Forms.CheckBox();
            this.rbKieuFlat = new System.Windows.Forms.RadioButton();
            this.rbKieuPopup = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.Location = new System.Drawing.Point(146, 87);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(116, 23);
            this.button.TabIndex = 0;
            this.button.Text = "Button";
            this.button.UseVisualStyleBackColor = true;
            // 
            // buttonFlat
            // 
            this.buttonFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFlat.Location = new System.Drawing.Point(146, 187);
            this.buttonFlat.Name = "buttonFlat";
            this.buttonFlat.Size = new System.Drawing.Size(116, 23);
            this.buttonFlat.TabIndex = 1;
            this.buttonFlat.Text = "Button Flat";
            this.buttonFlat.UseVisualStyleBackColor = true;
            // 
            // ckMauChu
            // 
            this.ckMauChu.AutoSize = true;
            this.ckMauChu.Location = new System.Drawing.Point(333, 89);
            this.ckMauChu.Name = "ckMauChu";
            this.ckMauChu.Size = new System.Drawing.Size(135, 20);
            this.ckMauChu.TabIndex = 2;
            this.ckMauChu.Text = "Thay đổi màu chữ";
            this.ckMauChu.UseVisualStyleBackColor = true;
            this.ckMauChu.CheckedChanged += new System.EventHandler(this.ckMauChu_CheckedChanged);
            // 
            // ckbMauNen
            // 
            this.ckbMauNen.AutoSize = true;
            this.ckbMauNen.Location = new System.Drawing.Point(333, 125);
            this.ckbMauNen.Name = "ckbMauNen";
            this.ckbMauNen.Size = new System.Drawing.Size(136, 20);
            this.ckbMauNen.TabIndex = 3;
            this.ckbMauNen.Text = "Thay đổi màu nền";
            this.ckbMauNen.UseVisualStyleBackColor = true;
            this.ckbMauNen.CheckedChanged += new System.EventHandler(this.ckbMauNen_CheckedChanged);
            // 
            // rbKieuFlat
            // 
            this.rbKieuFlat.AutoSize = true;
            this.rbKieuFlat.Location = new System.Drawing.Point(333, 187);
            this.rbKieuFlat.Name = "rbKieuFlat";
            this.rbKieuFlat.Size = new System.Drawing.Size(79, 20);
            this.rbKieuFlat.TabIndex = 4;
            this.rbKieuFlat.TabStop = true;
            this.rbKieuFlat.Text = "Kiểu Flat";
            this.rbKieuFlat.UseVisualStyleBackColor = true;
            this.rbKieuFlat.CheckedChanged += new System.EventHandler(this.rbKieuFlat_CheckedChanged);
            // 
            // rbKieuPopup
            // 
            this.rbKieuPopup.AutoSize = true;
            this.rbKieuPopup.Location = new System.Drawing.Point(333, 243);
            this.rbKieuPopup.Name = "rbKieuPopup";
            this.rbKieuPopup.Size = new System.Drawing.Size(97, 20);
            this.rbKieuPopup.TabIndex = 5;
            this.rbKieuPopup.TabStop = true;
            this.rbKieuPopup.Text = "Kiểu Popup";
            this.rbKieuPopup.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbKieuPopup);
            this.Controls.Add(this.rbKieuFlat);
            this.Controls.Add(this.ckbMauNen);
            this.Controls.Add(this.ckMauChu);
            this.Controls.Add(this.buttonFlat);
            this.Controls.Add(this.button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button buttonFlat;
        private System.Windows.Forms.CheckBox ckMauChu;
        private System.Windows.Forms.CheckBox ckbMauNen;
        private System.Windows.Forms.RadioButton rbKieuFlat;
        private System.Windows.Forms.RadioButton rbKieuPopup;
    }
}

