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
    public partial class DoiMK : Form
    {
        string iD;
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();

        public DoiMK(string id)
        {
            InitializeComponent();
            iD = id;
        }

        private void DoiMK_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == checkmk(iD))
            {
                if(textBox2.Text == textBox3.Text)
                {
                    if(UpdMK(textBox2.Text,iD))
                        MessageBox.Show("Doi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("co loi, vui long kiem tra lai!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("mật khẩu cũ không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public string checkmk(string ma) //xoa du lieu
        {
            cmd.CommandText = "select matkhau from thuthu Where matt = '" + ma + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                    return dt.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                dt = null;
                string mex = ex.Message;
            }
            return dt.Rows.ToString();
        }

        public bool UpdMK(string mk, string id) //sua du lieu
        {
            cmd.CommandText = "Update thuthu set matkhau = '"+mk+"' where matt =" + id;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }
    }
}
