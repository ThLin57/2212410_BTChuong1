namespace _2212410_WDF52
{
    partial class frmListBox
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
            this.btChon = new System.Windows.Forms.Button();
            this.lbDanhSach = new System.Windows.Forms.Label();
            this.lbDanhSachChon = new System.Windows.Forms.Label();
            this.listBoxDanhSach = new System.Windows.Forms.ListBox();
            this.listBoxDachSachChon = new System.Windows.Forms.ListBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btChon
            // 
            this.btChon.Location = new System.Drawing.Point(291, 120);
            this.btChon.Name = "btChon";
            this.btChon.Size = new System.Drawing.Size(75, 34);
            this.btChon.TabIndex = 0;
            this.btChon.Text = "Chọn";
            this.btChon.UseVisualStyleBackColor = true;
            this.btChon.Click += new System.EventHandler(this.btChon_Click);
            // 
            // lbDanhSach
            // 
            this.lbDanhSach.AutoSize = true;
            this.lbDanhSach.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbDanhSach.Location = new System.Drawing.Point(55, 48);
            this.lbDanhSach.Name = "lbDanhSach";
            this.lbDanhSach.Size = new System.Drawing.Size(148, 16);
            this.lbDanhSach.TabIndex = 2;
            this.lbDanhSach.Text = "Danh sách sinh viên lớp";
            // 
            // lbDanhSachChon
            // 
            this.lbDanhSachChon.AutoSize = true;
            this.lbDanhSachChon.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbDanhSachChon.Location = new System.Drawing.Point(389, 48);
            this.lbDanhSachChon.Name = "lbDanhSachChon";
            this.lbDanhSachChon.Size = new System.Drawing.Size(191, 16);
            this.lbDanhSachChon.TabIndex = 3;
            this.lbDanhSachChon.Text = "Danh sách sinh viên được chọn";
            // 
            // listBoxDanhSach
            // 
            this.listBoxDanhSach.FormattingEnabled = true;
            this.listBoxDanhSach.ItemHeight = 16;
            this.listBoxDanhSach.Items.AddRange(new object[] {
            "Luan",
            "Khanh",
            "Khoa",
            "Linh",
            "Dieu",
            "Nhu"});
            this.listBoxDanhSach.Location = new System.Drawing.Point(58, 76);
            this.listBoxDanhSach.Name = "listBoxDanhSach";
            this.listBoxDanhSach.Size = new System.Drawing.Size(213, 244);
            this.listBoxDanhSach.TabIndex = 4;
            this.listBoxDanhSach.SelectedIndexChanged += new System.EventHandler(this.listBoxDanhSach_SelectedIndexChanged);
            // 
            // listBoxDachSachChon
            // 
            this.listBoxDachSachChon.FormattingEnabled = true;
            this.listBoxDachSachChon.ItemHeight = 16;
            this.listBoxDachSachChon.Location = new System.Drawing.Point(392, 76);
            this.listBoxDachSachChon.Name = "listBoxDachSachChon";
            this.listBoxDachSachChon.Size = new System.Drawing.Size(213, 244);
            this.listBoxDachSachChon.TabIndex = 5;
            this.listBoxDachSachChon.SelectedIndexChanged += new System.EventHandler(this.listBoxDachSachChon_SelectedIndexChanged);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(291, 249);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 34);
            this.btXoa.TabIndex = 6;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // frmListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 442);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.listBoxDachSachChon);
            this.Controls.Add(this.listBoxDanhSach);
            this.Controls.Add(this.lbDanhSachChon);
            this.Controls.Add(this.lbDanhSach);
            this.Controls.Add(this.btChon);
            this.Name = "frmListBox";
            this.Text = "ListBox";
            this.Load += new System.EventHandler(this.frmListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btChon;
        private System.Windows.Forms.Label lbDanhSach;
        private System.Windows.Forms.Label lbDanhSachChon;
        private System.Windows.Forms.ListBox listBoxDanhSach;
        private System.Windows.Forms.ListBox listBoxDachSachChon;
        private System.Windows.Forms.Button btXoa;
    }
}

