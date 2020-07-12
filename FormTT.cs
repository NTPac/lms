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
    public partial class FormTT : Form
    {
        string iD;
        AccountMod acc = new AccountMod();
        DGMod dg = new DGMod();
        DataTable dt = new DataTable();
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();
        DataGridViewCheckBoxColumn clm = new DataGridViewCheckBoxColumn();

        public FormTT(string id)
        {
            InitializeComponent();
            this.iD = id;
        }

        private void FormTT_Load(object sender, EventArgs e)
        {
            hienThiTen();
            loadgrvdg();
        }
         
        private void hienThiTen()
        {
            dt = acc.GetTen(iD);
            if(dt != null)
            {
                label1.Text = dt.Rows[0][0].ToString();
            }
            else this.Close();
        }

        private void loadgrvdg()
        {
            string id;
            dt = dg.GetData();
            dataGridView2.DataSource = dt;
            for (int i = 0; i < dataGridView2.RowCount -1 ; i++)
            {
                id = dt.Rows[i][0].ToString();
                dataGridView2.Rows[i].Cells["qh"].Value = dem(id);
                dataGridView2.Rows[i].Cells["muon"].Value = demDangMuon(id);
            }
            dataGridView1.DataSource = GetData();
        }

        public string dem(string id)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select COUNT(*) from MuonSach where maDG='"+id+"' and han < GETDATE() and trangthai = 'dang muon'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            con.OpenConn();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            string x = dt.Rows[0][0].ToString();
            return x;
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

        public DataTable GetData()  //lấy dữ liệu
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select mas,tens,sl from Sach";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddSach addSach = new AddSach(label1.Text);
            addSach.ShowDialog();
            loadgrvdg();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn clm = new DataGridViewCheckBoxColumn();
            clm.Name = "cot1";
            clm.HeaderText = "cot1";
            this.dataGridView1.Columns.Add(clm);
            button8.Visible = false;
            button12.Visible = true;
            button9.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    bool checkedCell = (bool)row.Cells[3].Value;
                    if (checkedCell)
                    {
                        string id = row.Cells["maS"].Value.ToString();
                        SachMod sach = new SachMod();
                        sach.DelData(id);
                        sach.DelDatatl(id);
                    };
                };
            };
            loadgrvdg();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Visible = false;
            button12.Visible = false;
            button8.Visible = true;
            dataGridView1.Columns.Remove("cot1");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddDG addDG = new AddDG();
            addDG.ShowDialog();
            loadgrvdg();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn clm = new DataGridViewCheckBoxColumn();
            clm.Name = "cot1";
            clm.HeaderText = "cot1";
            this.dataGridView2.Columns.Add(clm);
            button5.Visible = false;
            button14.Visible = true;
            button13.Visible = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button14.Visible = false;
            button13.Visible = false;
            button5.Visible = true;
            dataGridView2.Columns.Remove("cot1");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string x = "";
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    bool checkedCell = (bool)row.Cells[4].Value;
                    if (checkedCell)
                    {
                        if (row.Cells[2].Value.ToString() != "0")
                        {
                            string id = row.Cells["maDG"].Value.ToString();
                            DGMod sach = new DGMod();
                            sach.DelData(id);
                        }
                        else
                        {
                            x = x + row.Cells["maDG"].Value.ToString() + " " + row.Cells["ten"].Value.ToString() + ", ";
                        }    
                    };
                };
            };
            if(x != "")
            {
                MessageBox.Show("Độc giả "+ x +"  chưa trả sách không được xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            loadgrvdg();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            CTS cts = new CTS(id,label1.Text);
            cts.ShowDialog();
            loadgrvdg();
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView2.Rows[e.RowIndex].Cells["maDG"].Value.ToString();
            CTDG cts = new CTDG(id);
            cts.ShowDialog();
            loadgrvdg();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.Text == "Độc giả")
            {
                comboBox2.Items.Add("mã độc giả");
                comboBox2.Items.Add("tên độc giả");
            }
            if(comboBox1.Text == "Sách")
            {
                comboBox2.Items.Add("mã sách");
                comboBox2.Items.Add("số lượng");
                comboBox2.Items.Add("tên sách");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string x ="";
            string a ="";
            if(comboBox1.Text == "Độc giả")
            {
                x = "docgia";
                if (comboBox2.Text == "mã độc giả")
                    a = "madg like '%" + txbND.Text +"%'";
                else
                if(comboBox2.Text == "tên độc giả")
                    a = "tendg like '%" + txbND.Text + "%'";
                }
            else
            if(comboBox1.Text == "Sách")
            {
                x = "sach";
                if(comboBox2.Text == "mã sách")
                    a= "mas like '%" + txbND.Text + "%'";
                else
                if(comboBox2.Text == "số lượng")
                    a= "sl like '%" + txbND.Text + "%'";
                else
                if(comboBox2.Text == "tên sách")
                    a = "tens like '%" + txbND.Text + "%'";
            }
            if(x != "")
            {
                if (a != "") 
                {
                    if (x == "Độc giả")
                        dataGridView2.DataSource = searchcuatt(x, a);
                    else
                        dataGridView1.DataSource = searchcuatt(x, a);
                }
                else
                    MessageBox.Show("vui lòng chọn tiêu chí!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
                MessageBox.Show("vui lòng chọn tiêu chí!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public DataTable searchcuatt(string x,string a) // tim kiem
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from "+x+" where " + a;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
