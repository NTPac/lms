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
    public partial class CTDG : Form
    {
        string iD;
        DGMod dg = new DGMod();
        DataTable a ;
        DataTable dt = new DataTable();
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();
        public CTDG(string id)
        {
            InitializeComponent();
            iD = id;
        }

        private void CTDG_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            dt = dg.searchData(iD);
            label1.Text = dt.Rows[0][0].ToString();
            label3.Text = dt.Rows[0][1].ToString();
            label5.Text = dt.Rows[0][2].ToString();
            label16.Text = dt.Rows[0][3].ToString();
            label6.Text = dt.Rows[0][4].ToString();
            label8.Text = dt.Rows[0][6].ToString();
            label10.Text = dt.Rows[0][5].ToString();
            label12.Text = dt.Rows[0][7].ToString();
            label14.Text = dt.Rows[0][8].ToString();
            pictureBox1.Image = Image.FromFile(dt.Rows[0][9].ToString());
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            a = dg.searchDatamuon(iD);
            dataGridView1.DataSource = a;
        }

        public string demDangMuon(string id)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select COUNT(*) from MuonSach where maDG = '" + id + "' and trangthai = 'dang muon'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            con.OpenConn();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            string x = dt.Rows[0][0].ToString();
            return x;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa", "xóa sách", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);

            switch (result)
            {
                case DialogResult.Abort:
                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Yes:
                    if (xoa())
                    {
                        this.Close();
                        break;
                    }
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    break;
            }
        }

        private bool xoa()
        {
            if (demDangMuon(iD) == "0")
            {
                dg.DelData(iD);
                return true;
            }
            else
            {
                MessageBox.Show("Độc giả chưa trả sách không được xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
