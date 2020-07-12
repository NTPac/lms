namespace LMS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_TK = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_TKNC = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_TK
            // 
            this.btn_TK.Location = new System.Drawing.Point(619, 93);
            this.btn_TK.Name = "btn_TK";
            this.btn_TK.Size = new System.Drawing.Size(75, 23);
            this.btn_TK.TabIndex = 0;
            this.btn_TK.Text = "Tìm kiếm";
            this.btn_TK.UseVisualStyleBackColor = true;
            this.btn_TK.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(290, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(323, 20);
            this.textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maS,
            this.Anh,
            this.tens,
            this.theloai,
            this.tenTG,
            this.namXB,
            this.nhaXB});
            this.dataGridView1.Location = new System.Drawing.Point(12, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(833, 289);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // maS
            // 
            this.maS.HeaderText = "maS";
            this.maS.Name = "maS";
            this.maS.Visible = false;
            // 
            // Anh
            // 
            this.Anh.DataPropertyName = "anh";
            this.Anh.HeaderText = "Anh";
            this.Anh.Name = "Anh";
            this.Anh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Anh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tens
            // 
            this.tens.DataPropertyName = "tenS";
            this.tens.HeaderText = "TenSach";
            this.tens.Name = "tens";
            this.tens.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tens.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tens.Width = 200;
            // 
            // theloai
            // 
            this.theloai.DataPropertyName = "theLoai";
            this.theloai.HeaderText = "The loai";
            this.theloai.Name = "theloai";
            this.theloai.Width = 200;
            // 
            // tenTG
            // 
            this.tenTG.DataPropertyName = "tenTG";
            this.tenTG.HeaderText = "Tác giả";
            this.tenTG.Name = "tenTG";
            this.tenTG.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // namXB
            // 
            this.namXB.DataPropertyName = "namXB";
            this.namXB.HeaderText = "năm xuất bản";
            this.namXB.Name = "namXB";
            this.namXB.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nhaXB
            // 
            this.nhaXB.DataPropertyName = "nhaXB";
            this.nhaXB.HeaderText = "Nhà xuất bản";
            this.nhaXB.Name = "nhaXB";
            this.nhaXB.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btn_TKNC
            // 
            this.btn_TKNC.Location = new System.Drawing.Point(0, 0);
            this.btn_TKNC.Name = "btn_TKNC";
            this.btn_TKNC.Size = new System.Drawing.Size(117, 23);
            this.btn_TKNC.TabIndex = 4;
            this.btn_TKNC.Text = "Tìm kiếm nâng cao";
            this.btn_TKNC.UseVisualStyleBackColor = true;
            this.btn_TKNC.Click += new System.EventHandler(this.btn_TKNC_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Tên sách",
            "Tên Tác giả",
            "Thể Loại",
            "Năm Xuất Bản",
            "Nhà Xuất bản"});
            this.comboBox2.Location = new System.Drawing.Point(163, 95);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thu vien xxx xin kinh chao quy khach";
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(582, 13);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(100, 20);
            this.txbID.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btn_TKNC);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_TK);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TK;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_TKNC;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tens;
        private System.Windows.Forms.DataGridViewTextBoxColumn theloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn namXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaXB;
        private System.Windows.Forms.TextBox txbID;
    }
}

