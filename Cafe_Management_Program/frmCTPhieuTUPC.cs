using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cafe_Management_Program
{
    public partial class frmCTPhieuTUPC : Form
    {
        public frmCTPhieuTUPC()
        {
            InitializeComponent();
        }
   
        private void frmCTPhieuTUPC_Load(object sender, EventArgs e)
        {
            showCTPhieuTUchoPC(AppEnv.idPhieu);
            txtPhieuTU.Text = AppEnv.idPhieu;
        }

        void showCTPhieuTUchoPC(string id)
        {
            DataTable ds = DataProvider.Instance.ExecQuery("select * from chiTietPhieuThucUong where iTrangThaiMon = 1 and iSoPhieuTU =" + id);
            dgvCTPhieuTU.DataSource = ds;
        }

        private void btnXacNhanXong_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExecNonQuery("update chiTietPhieuThucUong set iTrangThaiMon = 2 where iSoPhieuTU =" + AppEnv.idPhieu + " and iSoTTTU =" + txtThucUong.Text);
            MessageBox.Show("Xac nhan mon xong!");
            showCTPhieuTUchoPC(AppEnv.idPhieu);
            int sLTU = (int)DataProvider.Instance.ExecScalar("select count(*) as sl from chiTietPhieuThucUong where iTrangThaiMon = 1 and iSoPhieuTU = " + AppEnv.idPhieu);
            if (sLTU == 0)
            {
                //DataProvider.Instance.ExecNonQuery("update phieuThucUong set iTrangThaiPhieu = 2 where iSoPhieuTU = "+ AppEnv.idPhieu);
                MessageBox.Show("Phieu da hoan thanh");
                this.Close();
            }
        }

        private void dgvCTPhieuTU_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = dgvCTPhieuTU.CurrentCell.RowIndex;
            try
            {
                txtThucUong.Text = dgvCTPhieuTU.Rows[indexRow].Cells[0].Value.ToString();
            }
            catch { return; }

            
        }

        private void btnXacNhanXongTatCa_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExecNonQuery("update chiTietPhieuThucUong set iTrangThaiMon = 2 where iSoPhieuTU =" + AppEnv.idPhieu);
            MessageBox.Show("Phieu da hoan thanh");
            this.Close();
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
