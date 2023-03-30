using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cafe_Management_Program
{
    public partial class frmQLDMTU : Form
    {
        public frmQLDMTU()
        {
            InitializeComponent();
        }

        private void frmQLDMTU_Load(object sender, EventArgs e)
        {
            loadDMTU();
        }

        void loadDMTU()
        {
            DataTable dt = DataProvider.Instance.ExecQuery("select * from danhmucthucuong");
            dgvDMTU.DataSource = dt;
        }

        private void dgvDMTU_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = dgvDMTU.CurrentCell.RowIndex;
            txtMaTU.Text = dgvDMTU.Rows[indexRow].Cells[0].Value.ToString();
            txtTenTU.Text = dgvDMTU.Rows[indexRow].Cells[1].Value.ToString();
            txtDonGia.Text = dgvDMTU.Rows[indexRow].Cells[2].Value.ToString();
            txtGhiChu.Text = dgvDMTU.Rows[indexRow].Cells[3].Value.ToString();
            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e) // chưa được , lỗi @dongia 
        {
            DataProvider.Instance.ExecNonQuery("exec r_addDMTU @vTenTU=N'"+txtTenTU.Text+"' ,@fDonGia= "+int.Parse(txtDonGia.Text) + " ,@vGhiChu= N'" + txtGhiChu.Text+"'");
            MessageBox.Show("Thêm thức uống thành công");
            loadDMTU();
            clearTextBox();
        }

        void clearTextBox()
        {
            txtMaTU.Text = "";
            txtTenTU.Text = "";
            txtDonGia.Text = "";
            txtGhiChu.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMaTU.Text = "";
            txtTenTU.Text = "";
            txtDonGia.Text = "";
            txtGhiChu.Text = "";
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
        }
    }
}
