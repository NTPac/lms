using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class tra : Form
    {
        SachMod sach = new SachMod();
        DGMod dg = new DGMod();
        public tra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewButtonColumn clm = new DataGridViewButtonColumn();
            clm.Name = "cot1";
            clm.HeaderText = "cot1";
            this.dataGridView1.Columns.Add(clm);
            string madg = textBox1.Text;
            dataGridView1.DataSource = dg.searchDatamuon(madg);
        }
    }
}
