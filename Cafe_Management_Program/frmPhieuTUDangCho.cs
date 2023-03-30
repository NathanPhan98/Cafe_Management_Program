using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cafe_Management_Program
{
    public partial class frmPhieuTUDangCho : Form
    {
        public frmPhieuTUDangCho()
        {
            InitializeComponent();
        }

        private void frmPhieuTUDangCho_Load(object sender, EventArgs e)
        {
            showPhieuTUDangCho();
        }

        void showPhieuTUDangCho()
        {
            DataTable ds = DataProvider.Instance.ExecQuery("select * from phieuThucUong where iTrangThaiPhieu = 1");
            dgvPhieuTUDangCho.DataSource = ds;
        }

        private void dgvPhieuTUDangCho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = dgvPhieuTUDangCho.CurrentCell.RowIndex;
            AppEnv.idPhieu = dgvPhieuTUDangCho.Rows[indexRow].Cells[0].Value.ToString();

            frmCTPhieuTUPC frm = new frmCTPhieuTUPC();
            frm.ShowDialog();
            showPhieuTUDangCho();
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
