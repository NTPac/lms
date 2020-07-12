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
    public partial class TKNC : Form
    {
        public TKNC()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = "";
            string tl = "";
            if (ckbHD.Checked == true)
            {
                tl = tl + "hanh dong, ";
                x = x + " and hanhdong = 'True'";
            }
            if (ckbNL.Checked == true)
            {
                tl = tl + "nguoi lon, ";
                x = x + " and nguoilon = 'True'";
            }

            if (ckbPL.Checked == true)
            {
                tl = tl + "phieu lieu, ";
                x = x + " and phieuluu = 'True'";
            }

            if (ckbHH.Checked == true)
            {
                tl = tl + "hai huoc, ";
                x = x + " and haihuoc =  'True'";
            }

            if (ckbDrama.Checked == true)
            {
                tl = tl + "drama, ";
                x = x + " and drama = 'True'";
            }

            if (ckbFan.Checked == true)
            {
                tl = tl + "fantasy, ";
                x = x + " and fantasy = 'True'";
            }

            if (ckbLS.Checked == true)
            {
                tl = tl + "lich su, ";
                x = x + " and lichsu = 'True'";
            }
            if (ckbCG.Checked == true)
            {
                tl = tl + "con gai, ";
                x = x + " and congai ='True'";
            }
            if (ckbCT.Checked == true)
            {
                tl = tl + "contrai, ";
                x = x + " and contrai = 'True'";
            }

            if (ckbKDi.Checked == true)
            {
                tl = tl + "kinh di, ";
                x = x + "and kinhdi = 'True'";
            }

            if (ckbTra.Checked == true)
            {
                tl = tl + "tragedy, ";
                x = x + " and tragedy = 'True'";
            }

            if (ckbBiAn.Checked == true)
            {
                tl = tl + "bi an, ";
                x = x + " and bian = 'True'";
            }

            if (ckbTrinhT.Checked == true)
            {
                tl = tl + "trinh tham, ";
                x = x + "and trinhtham = 'True' ";
            }

            if (ckbGGan.Checked == true)
            {
                tl = tl + "giat gan, ";
                x = x + " and giatgan = 'True'";
            }

            if (ckbLM.Checked == true)
            {
                tl = tl + "lang man, ";
                x = x + " and lanman = 'True'";
            }

            if (ckbLN.Checked == true)
            {
                tl = tl + "lightnovel, ";
                x = x + " and lightnovel = 'True'";
            }

            if (ckbHT.Checked == true)
            {
                tl = tl + "hoc thuat, ";
                x = x + " and sachht = 'True'";
            }

            string sql = "tens like '%"+textBox1.Text+"%' and tentg like '%" +textBox2.Text+"%' and nhaxb like '%"+textBox3.Text+"%' and namxb like '%"+textBox4.Text+"%' "+x;
            SachMod s = new SachMod();
            DataTable dt = s.searchDataNC(sql);
            chitiet a = new chitiet(dt);
            a.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TKNC_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
