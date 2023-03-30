using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cafe_Management_Program
{
    public partial class frmPhieuTUDaXong : Form
    {
        public frmPhieuTUDaXong()
        {
            InitializeComponent();
        }

        private void frmPhieuTUDaXong_Load(object sender, EventArgs e)
        {
            showPhieuTUDaXong();

        }

        void showPhieuTUDaXong()
        {
            //DataTable ds = DataProvider.Instance.ExecQuery("select * from phieuThucUong where iTrangThaiPhieu = 2");
            DataTable ds;

            ds = DataProvider.Instance.ExecQuery("select chiTietPhieuThucUong.iSoPhieuTU, iMaBan,iTrangThaiMon from phieuThucUong, chiTietPhieuThucUong where phieuThucUong.iSoPhieuTU = chiTietPhieuThucUong.iSoPhieuTU and iTrangThaiPhieu < 3 and iTrangThaiMon = 2 group by chiTietPhieuThucUong.iSoPhieuTU,iMaBan, iTrangThaiMon");
            dgvPhieuTUDaXong.DataSource = ds;

        }

        void showCTPhieuTUDaXong(string IdPhieu)
        {
            DataTable ds = DataProvider.Instance.ExecQuery("select * from chiTietPhieuThucUong where iTrangThaiMon = 2 and iSoPhieuTU =" + IdPhieu);
            dgvCTPhieuTUDaXong.DataSource = ds;
        }

        private void dgvPhieuTUDaXong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = dgvPhieuTUDaXong.CurrentCell.RowIndex;
            //MessageBox.Show(dgvPhieuTUDaXong.Rows[indexRow].Cells[0].Value.ToString());
            try
            {
                txtPhieuTU.Text = dgvPhieuTUDaXong.Rows[indexRow].Cells[0].Value.ToString();
                showCTPhieuTUDaXong(txtPhieuTU.Text);
            }
            catch
            {
                return;
            }
        }

        private void btnYCTT_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExecNonQuery("update phieuThucUong set iTrangThaiPhieu = 3 where iSoPhieuTU = " + txtPhieuTU.Text);
            MessageBox.Show("Da gui yeu cau tinh tien!");
            showPhieuTUDaXong();
            dgvCTPhieuTUDaXong.DataSource=null;
          
        }

        private void dgvCTPhieuTUDaXong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
