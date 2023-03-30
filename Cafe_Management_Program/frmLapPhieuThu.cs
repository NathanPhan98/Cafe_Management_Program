using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cafe_Management_Program
{
    public partial class frmLapPhieuThu : Form
    {
        public frmLapPhieuThu()
        {
            InitializeComponent();
        }

        private void frmLapPhieuThu_Load(object sender, EventArgs e)
        {
            loadHeaderLapPhieuThu(AppEnv.idPhieuTT);
            loadDetailLapPhieuThu(AppEnv.idPhieuTT);
            txtThanhTien.Text = tongTien.ToString();
        }

        void loadHeaderLapPhieuThu(string idPhieuTU)
        {
            DataTable dt = DataProvider.Instance.ExecQuery("select * from phieuThucUong where iSoPhieuTU = " + idPhieuTU);

            txtNgayThu.Text = DateTime.Now.ToString();
            txtPhieuTU.Text = dt.Rows[0]["iSoPhieuTU"].ToString();

            DataTable dtUser = DataProvider.Instance.ExecQuery("select * from nhanVien where iMaNV = "+AppEnv.currentUser);
            txtNVThu.Text = dtUser.Rows[0]["vTenNV"].ToString();
            idNVThu = int.Parse(dtUser.Rows[0]["iMaNV"].ToString());

        }
        int tongTien = 0;
        int idNVThu;
        void loadDetailLapPhieuThu(string idPhieuTU)
        {
            DataTable dt = getLstCTPhieuTU(idPhieuTU);
            dgvCTPhieuTU.DataSource = dt;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tongTien += int.Parse(dt.Rows[i]["fDonGia"].ToString());
            }
            txtTongTien.Text = tongTien.ToString();
        }

        private void txtPhiPV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhiPV_Leave(object sender, EventArgs e)
        {
            int thanhTien = int.Parse(txtTongTien.Text) + int.Parse(txtPhiPV.Text);
            txtThanhTien.Text = thanhTien.ToString();
        }

        private void btnLapPhieuThu_Click(object sender, EventArgs e)
        {
            //them phieu thu
            addPhieuThu(idNVThu, int.Parse(txtPhieuTU.Text),float.Parse(txtTongTien.Text), float.Parse(txtPhiPV.Text), float.Parse(txtThanhTien.Text));
            MessageBox.Show("Lập phiếu thu thành công");
            DataProvider.Instance.ExecNonQuery("update phieuThucUong set iTrangThaiPhieu = 4 where iSoPhieuTU = " + txtPhieuTU.Text);
            //them chi tiet phieu thu
            
            DataTable dt = getLstCTPhieuTU(AppEnv.idPhieuTT);

            DataTable soPhieuThu = DataProvider.Instance.ExecQuery("select iSoPhieuThu from phieuThu where iSoPhieuTU ="+ AppEnv.idPhieuTT);
            int spt = int.Parse(soPhieuThu.Rows[0]["iSoPhieuThu"].ToString());
            MessageBox.Show(soPhieuThu.Rows[0]["iSoPhieuThu"].ToString());
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int maTU = int.Parse(dt.Rows[i]["iMaTU"].ToString());
                int soLuong = int.Parse(dt.Rows[i]["soLuong"].ToString());
                int donGia = int.Parse(dt.Rows[i]["fDonGia"].ToString());
                addCTPhieuThu(spt, maTU, soLuong, donGia);
            }

            DataTable Ban = DataProvider.Instance.ExecQuery("select iMaBan from phieuThucUong where iSoPhieuTU =" + AppEnv.idPhieuTT);
            int maBan = int.Parse(Ban.Rows[0]["iMaBan"].ToString());
            DataProvider.Instance.ExecNonQuery("update ban set iTrangThaiBan = 1 where iMaBan = " + maBan);
            this.Close();
        }

        DataTable getLstCTPhieuTU(string id)
        {
            return DataProvider.Instance.ExecQuery(
                "select iSoPhieuTU,chiTietPhieuThucUong.iMaTU, sum(iSoluong) as soLuong,sum(fDonGia) as fDonGia " +
                "from chiTietPhieuThucUong, danhMucThucUong " +
                "where chiTietPhieuThucUong.iMaTU = danhMucThucUong.iMaTU and iSoPhieuTU = " + id + " " +
                "group by iSoPhieuTU, chiTietPhieuThucUong.iMaTU,fDonGia " +
                "order by iSoPhieuTU");
        }

        void addPhieuThu(int idNV, int soPhieuTU, float tongTien, float phiPhucVu,float thanhTien)
        {
            DataProvider.Instance.ExecNonQuery("exec r_addPhieuThu @manv= "+idNV+",@sophieutu= "+soPhieuTU+ " ,@tongtien= " + tongTien + " ,@phiphucvu= " + phiPhucVu + " ,@thanhtien= " + thanhTien);
        }
        void addCTPhieuThu(int iSoPhieuThu,int iMaTU, int iSoLuong, int iDonGia)
        {
            DataProvider.Instance.ExecNonQuery("exec r_addCTPhieuThu @iSoPhieuThu= " + iSoPhieuThu + ",@iMaTU= " + iMaTU + " ,@iSoLuong= " + iSoLuong + " ,@iDonGia= " + iDonGia);
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
