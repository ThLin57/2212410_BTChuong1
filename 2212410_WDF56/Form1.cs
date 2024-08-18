using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212410_WDF56
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbNam.Checked)
                MessageBox.Show("Gioi tinh ban la:" + rbNam.Text);
        }

        private void rbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbNu.Checked)
                MessageBox.Show("Gioi tinh ban la:" + rbNu.Text);

        }
    }
}
