using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cafe_Management_Program
{
    public partial class frmPhieuTUChoThanhToan : Form
    {
        public frmPhieuTUChoThanhToan()
        {
            InitializeComponent();
        }

        private void frmPhieuTUChoThanhToan_Load(object sender, EventArgs e)
        {
            showPhieuTUChoTT();
        }
        void showPhieuTUChoTT()
        {
            DataTable ds = DataProvider.Instance.ExecQuery("select * from phieuThucUong where iTrangThaiPhieu = 3");
            dgvPhieuTUChoTT.DataSource = ds;
        }

        private void dgvPhieuTUChoTT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = dgvPhieuTUChoTT.CurrentCell.RowIndex;
            //MessageBox.Show(dgvPhieuTUDaXong.Rows[indexRow].Cells[0].Value.ToString());
            try
            {
                txtPhieuTU.Text = dgvPhieuTUChoTT.Rows[indexRow].Cells[0].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        private void btnLapPhieuThu_Click(object sender, EventArgs e)
        {
            if(txtPhieuTU.Text == "")
            {
                MessageBox.Show("Vui lòng chọn phiếu cần lập phiếu thu!");
            }
            else
            {
                AppEnv.idPhieuTT = txtPhieuTU.Text;
                frmLapPhieuThu frm = new frmLapPhieuThu();
                frm.ShowDialog();
                showPhieuTUChoTT();
                txtPhieuTU.Text = "";
            }
        }

        private void btnInPhieuTU_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //in phieu tinh tien cho khach hàng
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
