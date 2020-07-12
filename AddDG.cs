using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class AddDG : Form
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();
        DGMod dg = new DGMod();
        string iD = "";
        DataTable dt = new DataTable();
        public AddDG()
        {
            InitializeComponent();
            button4.Visible = false;
            button5.Visible = false;
        }

        public AddDG(string id)
        {
            InitializeComponent();
            iD = id;
            button2.Visible = false;
            button3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (gioitinh() == "")
            {
                MessageBox.Show("Vui long nhap day du cac muc co danh dau *!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dg.AddData(taoma(), textBox1.Text, textBox2.Text,gioitinh(),textBox3.Text,textBox4.Text,textBox5.Text,textBox6.Text,textBox7.Text,textBox8.Text))
                { MessageBox.Show("Them thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else
                    MessageBox.Show("Vui long nhap day du cac muc co danh dau *!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public string taoma()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select COUNT(*) from DocGia ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            con.OpenConn();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            string x = "S" + dt.Rows[0][0].ToString();
            return x;
        }

        public string gioitinh()
        {
            string x = "";
            if(checkBox1.Checked == true || checkBox2.Checked == true)
            {
                if (checkBox1.Checked == true)
                {
                    x = "nam";
                }
                else if (checkBox2.Checked == true)
                {
                    x = "nữ";
                }
                else
                    x = "khác";
            };
            return x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog _openFileDialog = new OpenFileDialog();

            _openFileDialog.Title = "Chọn Ảnh";

            _openFileDialog.InitialDirectory = @"C:\Users\phong\Pictures\qltts";//Thư mục mặc định khi mở

            _openFileDialog.Filter = "Image files (*.png;*.jpg)|*.png;*.jpg|All files (*.*)|*.*";// Lọc ra những file cần hiển thị

            _openFileDialog.FilterIndex = 1;//chúng ta có All files là 1,exe là 2 

            _openFileDialog.RestoreDirectory = true;



            if (_openFileDialog.ShowDialog() == DialogResult.OK)

            {

                textBox8.Text = _openFileDialog.FileName;//đường dẫn của file trong textbox

            }
        }

        private void AddDG_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            
            if (iD != "") 
            {
                dt = dg.searchData(iD);
                textBox1.Text = dt.Rows[0][1].ToString();
                textBox2.Text = dt.Rows[0][2].ToString();
                if (dt.Rows[0][3].ToString() == "nam") 
                {
                    checkBox1.Checked = true;
                };
                if (dt.Rows[0][3].ToString() == "nữ")
                {
                    checkBox2.Checked = true;
                };
                if (dt.Rows[0][3].ToString() == "khác")
                {
                    checkBox1.Checked = true;
                    checkBox2.Checked = true;
                };
                textBox3.Text = dt.Rows[0][4].ToString();
                textBox4.Text = dt.Rows[0][5].ToString();
                textBox5.Text = dt.Rows[0][6].ToString();
                textBox6.Text = dt.Rows[0][7].ToString();
                textBox7.Text = dt.Rows[0][8].ToString();
                textBox8.Text = dt.Rows[0][9].ToString();
            };
        }
    }
}
