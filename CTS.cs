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
    public partial class CTS : Form
    {
        string iD;
        string iDU  = "";
        ConnectToSQL f = new ConnectToSQL();
        SachMod sach = new SachMod();
        DataTable dt = new DataTable();
        public CTS(string id)
        {
            InitializeComponent();
            iD = id;
            dataGridView1.Visible = false;
        }

        public CTS(string id,string idu)
        {
            InitializeComponent();
            iD = id;
            iDU = idu;
            button1.Visible = true;
            button2.Visible = true;
        }


        private void CTS_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            dt = sach.searchData(iD);
            lbTenS.Text = dt.Rows[0][1].ToString();
            lbTL.Text= dt.Rows[0][2].ToString();
            lbTG.Text= dt.Rows[0][3].ToString();
            lbNamXB.Text= dt.Rows[0][4].ToString();
            lbnhaXB.Text = dt.Rows[0][5].ToString();
            anh.Image = Image.FromFile(dt.Rows[0][6].ToString());
            lbSL.Text = dt.Rows[0][7].ToString();
            lbDG.Text = dt.Rows[0][8].ToString();
            lbVT.Text = dt.Rows[0][9].ToString();
            txbReview.Text = dt.Rows[0][10].ToString();
            anh.SizeMode = PictureBoxSizeMode.StretchImage;
            if(iDU != "")
            {
                dataGridView1.DataSource = sach.xemcts(iD);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddSach sach = new AddSach(iDU,iD);
            this.Hide();
            sach.ShowDialog();
            this.Show();
            load();
        }

        private void button1_Click(object sender, EventArgs e)
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
                    sach.DelData(iD);
                    sach.DelDatatl(iD);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    break;
                default:
                    break;
            }
        }
    }
}
