using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cafe_Management_Program
{
    public partial class frmDanhSachPhieuThu : Form
    {
        public frmDanhSachPhieuThu()
        {
            InitializeComponent();
        }

        int DataRow = 0;
        DataTable dt;

        private void frmDanhSachPhieuThu_Load(object sender, EventArgs e)
        {
            loadListPhieuThu();
            loadPhieuThu(DataRow);
            loadChiTietPhieuThu();
        }

        private void loadListPhieuThu()
        {
            dt = DataProvider.Instance.ExecQuery("select * from phieuThu order by iNgayThu");
            dgvListPhieuThu.DataSource = dt;
        }

        private void loadPhieuThu(int row)
        {

            dt = DataProvider.Instance.ExecQuery("select * from phieuThu order by iNgayThu");

            lblSLPhieuThu.Text = dt.Rows.Count.ToString();

            txtSoPhieuThu.Text = dt.Rows[row]["iSoPhieuThu"].ToString();
            txtNgayThu.Text = dt.Rows[row]["iNgayThu"].ToString();
            txtNVThu.Text = dt.Rows[row]["iMaNV"].ToString();
            txtPhieuTU.Text = dt.Rows[row]["iSoPhieuTU"].ToString();
            txtTongTien.Text = dt.Rows[row]["fTongTien"].ToString();
            txtPhiPV.Text = dt.Rows[row]["fPhiPhucVu"].ToString();
            txtThanhTien.Text = dt.Rows[row]["fThanhTien"].ToString();

        }

        private void loadChiTietPhieuThu()
        {
            string query = "select * from chiTietPhieuThu where iSoPhieuThu =" + txtSoPhieuThu.Text ;
            DataTable dt = DataProvider.Instance.ExecQuery(query);
            dgvCTPhieuTU.DataSource = dt;

            dgvCTPhieuTU.Columns[0].HeaderText = "Số phiếu thu";
            dgvCTPhieuTU.Columns[1].HeaderText = "Mã thức uống";
            dgvCTPhieuTU.Columns[2].HeaderText = "Số lượng";
            dgvCTPhieuTU.Columns[3].HeaderText = "Đơn giá";

        }

        // <Dieu huong>
        private void btnFirst_Click(object sender, EventArgs e)
        {
            DataRow = 0;
            loadPhieuThu(DataRow);
            loadChiTietPhieuThu();


        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (DataRow > 0)
                DataRow--;
            loadPhieuThu(DataRow);
            loadChiTietPhieuThu();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (DataRow < dt.Rows.Count - 1)
                DataRow++;

            loadPhieuThu(DataRow);
            loadChiTietPhieuThu();

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            DataRow = dt.Rows.Count - 1;
            loadPhieuThu(DataRow);
            loadChiTietPhieuThu();

        }

        // </Dieu huong>
        int vt = -1;
        private void dgvListPhieuThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1) return;
            loadPhieuThu(vt);
            loadChiTietPhieuThu();
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
