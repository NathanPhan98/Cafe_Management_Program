using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_Program
{
    public partial class frmMain : Form 
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            checkRole();
            sp1.Visible = false;
            sp2.Visible = false;
            sp3.Visible = false;
            sp4.Visible = false;
            sp5.Visible = false;
            sp6.Visible = false;
        }

        void checkRole()
        {
            if(AppEnv.role == 1) //admin
            {
                btnTableList.Visible = true;
                btnPhieuTUDaXong.Visible = true;
                btnPhieuTUDangCho.Visible = true;
                btnPhieuTUChoThanhToan.Visible = true;
                btnDSPhieuThu.Visible = true;
                btnQLDMTU.Visible = true;
            }
            else if(AppEnv.role == 2) // nhan vien chay ban
            {
                btnTableList.Visible = true;
                btnPhieuTUDaXong.Visible = true;
                btnPhieuTUDangCho.Visible = false;
                btnPhieuTUChoThanhToan.Visible = false;
                btnDSPhieuThu.Visible = false;
                btnQLDMTU.Visible = false;
            }
            else if(AppEnv.role == 3) // nhan vien pha che
            {
                btnTableList.Visible = false;
                btnPhieuTUDaXong.Visible = false;
                btnPhieuTUDangCho.Visible = true;
                btnPhieuTUChoThanhToan.Visible = false;
                btnDSPhieuThu.Visible = false;
                btnQLDMTU.Visible = false;
            }
            else if (AppEnv.role == 4)// nhan vien thu ngan
            {
                btnTableList.Visible = false;
                btnPhieuTUDaXong.Visible = false;
                btnPhieuTUDangCho.Visible = false;
                btnPhieuTUChoThanhToan.Visible = true;
                btnDSPhieuThu.Visible = true;
                btnQLDMTU.Visible = false;
            }
        }


        private Form currentFrmChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFrmChild != null)
            {
                currentFrmChild.Close();
            }
            currentFrmChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnTableList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTableList());
            lblFrmName.Text = "Danh sách bàn";
            if(AppEnv.role == 1)
            {
                sp1.Visible = true;
                sp2.Visible = false;
                sp3.Visible = false;
                sp4.Visible = false;
                sp5.Visible = false;
                sp6.Visible = false;
            }
        }

        private void panel_body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPhieuTUDaXong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmPhieuTUDaXong());
            lblFrmName.Text = "Phiếu Thức Uống Đã Xong";
            if (AppEnv.role == 1)
            {
                sp1.Visible = false;
                sp2.Visible = true;
                sp3.Visible = false;
                sp4.Visible = false;
                sp5.Visible = false;
                sp6.Visible = false;
            }
        }

        private void btnPhieuTUDangCho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmPhieuTUDangCho());
            lblFrmName.Text = "Phiếu Thức Uống Đang Chờ";
            if (AppEnv.role == 1)
            {
                sp1.Visible = false;
                sp2.Visible = false;
                sp3.Visible = true;
                sp4.Visible = false;
                sp5.Visible = false;
                sp6.Visible = false;
            }
        }

        private void btnPhieuTUChoThanhToan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmPhieuTUChoThanhToan());
            lblFrmName.Text = "Phiếu Thức Uống Chờ Thanh Toán";
            if (AppEnv.role == 1)
            {
                sp1.Visible = false;
                sp2.Visible = false;
                sp3.Visible = false;
                sp4.Visible = true;
                sp5.Visible = false;
                sp6.Visible = false;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnDSPhieuThu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDanhSachPhieuThu());
            lblFrmName.Text = "Danh Sách Phiếu Thu";
            if (AppEnv.role == 1)
            {
                sp1.Visible = false;
                sp2.Visible = false;
                sp3.Visible = false;
                sp4.Visible = false;
                sp5.Visible = true;
                sp6.Visible = false;
            }
        }

        private void btnQLDMTU_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLDMTU());
            lblFrmName.Text = "Quản Lý Danh Mục Thức Uống";
            if (AppEnv.role == 1)
            {
                sp1.Visible = false;
                sp2.Visible = false;
                sp3.Visible = false;
                sp4.Visible = false;
                sp5.Visible = false;
                sp6.Visible = true;
            }
        }
    }
}
