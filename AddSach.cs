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
    public partial class AddSach : Form
    {
        private string iD;
        private string ids = "";
        SachMod sach = new SachMod();
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        

        public AddSach(string id)
        {
            InitializeComponent();
            this.iD = id;
        }

        public AddSach(string id,string ids)
        {
            InitializeComponent();
            this.iD = id;
            this.ids = ids;
        }

        private void AddSach_Load(object sender, EventArgs e)
        {
            label10.Text = iD;
            if (ids != "")
            {
                button2.Visible = false;
                button3.Visible = false;
                dt = sach.searchData(ids);
                textBox5.Text = dt.Rows[0][1].ToString();
                textBox4.Text = dt.Rows[0][3].ToString();
                textBox1.Text = dt.Rows[0][4].ToString();
                textBox2.Text = dt.Rows[0][5].ToString();
                txbAnh.Text = dt.Rows[0][6].ToString();
                textBox6.Text = dt.Rows[0][9].ToString();
                textBox7.Text = dt.Rows[0][7].ToString();
                textBox8.Text = dt.Rows[0][8].ToString();
                textBox9.Text = dt.Rows[0][10].ToString();
                dt = sach.searchDatatl(ids);
                if (dt.Rows[0][1].ToString() == "'true'")
                {
                    ckbHH.Checked = true;
                };
                if (dt.Rows[0][2].ToString() == "1")
                {
                    ckbNL.Checked = true;
                };
                if (dt.Rows[0][3].ToString() == "1")
                {
                    ckbPL.Checked = true;
                };
                if (dt.Rows[0][4].ToString() == "1")
                {
                    ckbHH.Checked = true;
                };
                if (dt.Rows[0][5].ToString() == "1")
                {
                    ckbDrama.Checked = true;
                };
                if (dt.Rows[0][6].ToString() == "1")
                {
                    ckbFan.Checked = true;
                };
                if (dt.Rows[0][7].ToString() == "1")
                {
                    ckbLS.Checked = true;
                };
                if (dt.Rows[0][8].ToString() == "1")
                {
                    ckbCG.Checked = true;
                };
                if (dt.Rows[0][9].ToString() == "1")
                {
                    ckbCT.Checked = true;
                };
                if (dt.Rows[0][10].ToString() == "1")
                {
                    ckbKDi.Checked = true;
                };
                if (dt.Rows[0][11].ToString() == "1")
                {
                    ckbTra.Checked = true;
                };
                if (dt.Rows[0][12].ToString() == "1")
                {
                    ckbBiAn.Checked = true;
                };
                if (dt.Rows[0][13].ToString() == "1")
                {
                    ckbTrinhT.Checked = true;
                };
                if (dt.Rows[0][14].ToString() == "1")
                {
                    ckbGGan.Checked = true;
                };
                if (dt.Rows[0][15].ToString() == "1")
                {
                    ckbLM.Checked = true;
                };
                if (dt.Rows[0][16].ToString() == "1")
                {
                    ckbLN.Checked = true;
                };
                if (dt.Rows[0][18].ToString() == "1")
                {
                    ckbHT.Checked = true;
                };
            }

            else
            {
                button4.Visible = false;
                button5.Visible = false;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = taomas();
            string x = "";
            string tl = "";
            if (ckbHD.Checked == true)
            {
                tl = tl + "hanh dong, ";
                x = x + "'True',";
            }
            else x = x + "'False',";
            if (ckbNL.Checked == true)
            {
                tl = tl + "nguoi lon, ";
                x = x + "'True',";
            }
            else x = x + "'False',";
            if (ckbPL.Checked == true)
            {
                tl = tl + "phieu lieu, ";
                x = x + "'True',";
            }
            else x = x + "'False',";
            if (ckbHH.Checked == true)
            {
                tl = tl + "hai huoc, ";
                x = x + "'True',";
            }
            else x = x + "'False',";
            if (ckbDrama.Checked == true)
            {
                tl = tl + "drama, ";
                x = x + "'True',";
            }
            else x = x + "'False',";
            if (ckbFan.Checked == true)
            {
                tl = tl + "fantasy, ";
                x = x + "'True',";
            }
            else x = x + "'False',";
            if (ckbLS.Checked == true)
            {
                tl = tl + "lich su, ";
                x = x + "'True',";
            }
            else x = x + "'False',";
            if (ckbCG.Checked == true)
            {
                tl = tl + "con gai, ";
                x = x + "'True',";
            }
            else x = x + "'False',";
            if (ckbCT.Checked == true)
            {
                tl = tl + "contrai, ";
                x = x + "'True',";
            }
            else x = x + "'False',";
            if (ckbKDi.Checked == true)
            {
                tl = tl + "kinh di, ";
                x = x + "'True',";
            }
            else x = x + "'False',";
            if (ckbTra.Checked == true)
            {
                tl = tl + "tragedy, ";
                x = x + "'True',";
            }
            else x = x + "'False',";
            if (ckbBiAn.Checked == true)
            {
                tl = tl + "bi an, ";
                x = x + "'True',";
            }
            else x = x + "'False',";
            if (ckbTrinhT.Checked == true)
            {
                tl = tl + "trinh tham, ";
                x = x + "'True',";
            }
            else x = x + "'False',";
            if (ckbGGan.Checked == true)
            {
                tl = tl + "giat gan, ";
                x = x + "'True',";
            }
            else x = x + "'False',";
            if (ckbLM.Checked == true)
            {
                tl = tl + "lang man, ";
                x = x + "'True',";
            }
            else x = x + "'False',";
            if (ckbLN.Checked == true)
            {
                tl = tl + "lightnovel, ";
                x = x + "'True',";
            }
            else x = x + "'False',";
            if (ckbHT.Checked == true)
            {
                tl = tl + "hoc thuat, ";
                x = x + "'True',";
            }
            else x = x + "'False'";
            sach.AddDataTL(a, x);

            if (sach.AddData(a,textBox5.Text,tl,textBox4.Text,textBox2.Text,textBox1.Text,txbAnh.Text,textBox7.Text,textBox8.Text,textBox6.Text,textBox9.Text))
            { MessageBox.Show("Them thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);}
            else
                MessageBox.Show("Vui long nhap day du cac muc co danh dau *!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                txbAnh.Text = _openFileDialog.FileName;//đường dẫn của file trong textbox

            }
        }

        public string taomas()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select COUNT(*) from Sach ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            con.OpenConn();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            string x = "S"+dt.Rows[0][0].ToString();
            return x;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string x = "";
            string tl = "";
            if (ckbHD.Checked == true)
            {
                tl = tl + "hanh dong, ";
                x = x + " hanhdong = 'True',";
            }
            else x = x + " hanhdong = 'False',";
            if (ckbNL.Checked == true)
            {
                tl = tl + "nguoi lon, ";
                x = x + " nguoilon = 'True',";
            }
            else x = x + "nguoilon = 'False',";
            if (ckbPL.Checked == true)
            {
                tl = tl + "phieu lieu, ";
                x = x + " phieuluu = 'True',";
            }
            else x = x + " phieuluu 'False',";
            if (ckbHH.Checked == true)
            {
                tl = tl + "hai huoc, ";
                x = x + " haihuoc =  'True',";
            }
            else x = x + " haihuoc = 'False',";
            if (ckbDrama.Checked == true)
            {
                tl = tl + "drama, ";
                x = x + " drama = 'True',";
            }
            else x = x + " drama = 'False',";
            if (ckbFan.Checked == true)
            {
                tl = tl + "fantasy, ";
                x = x + " fantasy = 'True',";
            }
            else x = x + " fantasy = 'False',";
            if (ckbLS.Checked == true)
            {
                tl = tl + "lich su, ";
                x = x + " lichsu = 'True',";
            }
            else x = x + " lichsu = 'False',";
            if (ckbCG.Checked == true)
            {
                tl = tl + "con gai, ";
                x = x + " congai ='True',";
            }
            else x = x + " congai = 'False',";
            if (ckbCT.Checked == true)
            {
                tl = tl + "contrai, ";
                x = x + " contrai = 'True',";
            }
            else x = x + " contrai = 'False',";
            if (ckbKDi.Checked == true)
            {
                tl = tl + "kinh di, ";
                x = x + " kinhdi = 'True',";
            }
            else x = x + " kinhdi = 'False',";
            if (ckbTra.Checked == true)
            {
                tl = tl + "tragedy, ";
                x = x + " tragedy = 'True',";
            }
            else x = x + " tragedy = 'False',";
            if (ckbBiAn.Checked == true)
            {
                tl = tl + "bi an, ";
                x = x + " bian = 'True',";
            }
            else x = x + " bian = 'False',";
            if (ckbTrinhT.Checked == true)
            {
                tl = tl + "trinh tham, ";
                x = x + " trinhtham = 'True',";
            }
            else x = x + " trinhtham = 'False',";
            if (ckbGGan.Checked == true)
            {
                tl = tl + "giat gan, ";
                x = x + " giatgan = 'True',";
            }
            else x = x + " giatgan = 'False',";
            if (ckbLM.Checked == true)
            {
                tl = tl + "lang man, ";
                x = x + " lanman = 'True',";
            }
            else x = x + " lanman = 'False',";
            if (ckbLN.Checked == true)
            {
                tl = tl + "lightnovel, ";
                x = x + " lightnovel = 'True',";
            }
            else x = x + " lightnovel = 'False',";
            if (ckbHT.Checked == true)
            {
                tl = tl + "hoc thuat, ";
                x = x + " sachht = 'True',";
            }
            else x = x + " sachht = 'False'";

            if (sach.UpdData(textBox5.Text, tl, textBox4.Text, textBox1.Text, textBox2.Text, txbAnh.Text, textBox7.Text, textBox8.Text, textBox6.Text, textBox9.Text, ids))
                if(sach.UpdDatatl(x, ids))
                {
                    MessageBox.Show("Sua thanh cong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Vui long nhap day du cac muc co danh dau *!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
