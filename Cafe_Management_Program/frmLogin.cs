using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cafe_Management_Program
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (login(txtUsername.Text,txtPassword.Text))
            { 
            frmMain objfrm = new frmMain();
            this.Hide();
            objfrm.ShowDialog();
            this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }
        }

        bool login(string uname, string pwd)
        {
            string query = "exec r_checkLogin @username ='" + uname + "',@password = '" + pwd + "'";
            DataTable rs = DataProvider.Instance.ExecQuery(query);
            AppEnv.currentUser = int.Parse(rs.Rows[0]["iMaNV"].ToString());
            //AppEnv.nameOfUser = rs.Rows[0]["vTenNV"].ToString();
            AppEnv.role = int.Parse(rs.Rows[0]["iQuyen"].ToString());

            return rs.Rows.Count > 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
