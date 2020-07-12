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
    public partial class Form1 : Form
    {
        DataTable dtDS = new System.Data.DataTable();
        SachMod f = new SachMod();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string xa = "";
            if (comboBox2.Text == "Tên sách")
                xa = "tens";
            if (comboBox2.Text == "Tên Tác giả")
                xa = "tentg";
            if (comboBox2.Text == "Thể Loại")
                xa = "theloai";
            if (comboBox2.Text == "Năm Xuất Bản")
                xa = "namxb";
            if (comboBox2.Text == "Nhà Xuất bản")
                xa = "nhaxb";
            if(xa!="")
            dataGridView1.DataSource = f.searchData(xa,textBox1.Text);
            else
            dataGridView1.DataSource = f.searchDataten(textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loaddata();
            
        }

        private void loaddata()  //hàm load du liệu
        {
            dtDS = f.GetData();
            dataGridView1.DataSource = dtDS;
            txbID.Clear();
            txbID.DataBindings.Add("Text", dataGridView1.DataSource, "maS");
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CTS cts = new CTS(txbID.Text);
            cts.Show();
        }

        private void btn_TKNC_Click(object sender, EventArgs e)
        {

        }
    }
}
