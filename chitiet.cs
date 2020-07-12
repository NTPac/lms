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
    public partial class chitiet : Form
    {
        DataTable dT = new DataTable();
        public chitiet(DataTable dt)
        {
            InitializeComponent();
            dT = dt;
        }

        private void chitiet_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dT;
        }
    }
}
