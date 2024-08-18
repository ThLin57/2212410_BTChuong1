using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212410_WDF57
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ckMauChu_CheckedChanged(object sender, EventArgs e)
        {
            if(this.ckMauChu.Checked) 
                this.button.ForeColor = Color.Red;
            else
                this.button.ForeColor = Color.Black;
        }

        private void ckbMauNen_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ckbMauNen.Checked)
                this.buttonFlat.BackColor = Color.LightCyan;
            else
                this.buttonFlat.BackColor = this.buttonFlat.BackColor;
        }

        private void rbKieuFlat_CheckedChanged(object sender, EventArgs e)
        {
            if(this.rbKieuFlat.Checked)
                this.buttonFlat.FlatStyle = FlatStyle.Flat;
            else
            {
                this.buttonFlat.FlatStyle = FlatStyle.Popup;
            }

        }
    }
}
