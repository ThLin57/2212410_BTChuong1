namespace _2212410_WDF60
{
    partial class frmDemoCheckList
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
            this.cblMonHoc = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // cblMonHoc
            // 
            this.cblMonHoc.FormattingEnabled = true;
            this.cblMonHoc.Items.AddRange(new object[] {
            "CSDL ",
            "C",
            "B",
            "D",
            "E",
            "F",
            "G",
            "H"});
            this.cblMonHoc.Location = new System.Drawing.Point(28, 40);
            this.cblMonHoc.Name = "cblMonHoc";
            this.cblMonHoc.Size = new System.Drawing.Size(275, 140);
            this.cblMonHoc.TabIndex = 0;
            this.cblMonHoc.SelectedIndexChanged += new System.EventHandler(this.cblMonHoc_SelectedIndexChanged);
            // 
            // frmDemoCheckList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 216);
            this.Controls.Add(this.cblMonHoc);
            this.Name = "frmDemoCheckList";
            this.Text = "DemoCheckList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cblMonHoc;
    }
}

