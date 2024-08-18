using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212410_WDF60
{
    public partial class frmDemoCheckList : Form
    {
        public frmDemoCheckList()
        {
            InitializeComponent();
        }

        private void cblMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection items;
            items = this.cblMonHoc.CheckedItems;
            string s = "";
            foreach (object ob in items)
            {
                s += ob.ToString() + ",";
            }
            MessageBox.Show("Danh sach mon hoc:" + s);
        }
        }
        //private void cblMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string s = "";
        //    for (int i = 0; i < cblMonHoc.Items.Count; i++)
        //    {
        //        if (this.cblMonHoc.GetItemChecked(i) == true)
        //        {
        //            s += this.cblMonHoc.Items[i].ToString() + ",";
        //        }
        //        MessageBox.Show("Danh sach mon hoc:" + s);
        //    }
        //}
    }
}
