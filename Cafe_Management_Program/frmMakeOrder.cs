using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cafe_Management_Program
{
    public partial class frmMakeOrder : Form
    {
        public static int selectedTable;
        public static object listTag;

        public frmMakeOrder()
        {
            InitializeComponent();
        }

        private void frmMakeOrder_Load(object sender, EventArgs e)
        {
            showDMTU();
            //MessageBox.Show("du hast Tisch ' " + selectedTable.ToString() + " ' gewählt");
            listPhieuTU(selectedTable);
            lblMaBan.Text = selectedTable.ToString();
            lblTenNV.Text = AppEnv.currentUser.ToString();

            try
            {
                int idOrder = (int)DataProvider.Instance.ExecScalar("select * from phieuThucUong where iTrangThaiPhieu < 4 and imaban =" + selectedTable + " order by isophieutu desc");
                int statusPhieu = (int)DataProvider.Instance.ExecScalar("select count(*) as trangThai from phieuThucUong where iTrangThaiPhieu = 3 and iSoPhieuTU =" + idOrder);
                
                //MessageBox.Show(idOrder.ToString());
                //MessageBox.Show(statusPhieu.ToString());
    
                if (statusPhieu == 0)
                {
                    btnAddTU.Enabled = true;
                }
                else
                {
                    btnAddTU.Enabled = false;
                }     
            }
            catch
            {
                return;
            }

            


        }
        DataTable dataTU = DataProvider.Instance.ExecQuery("select * from danhMucThucUong");
        public void showDMTU()
        {
            dgvListTU.DataSource = dataTU;
        }

        private void btnAddTU_Click(object sender, EventArgs e)
        {
            // tu table chon lay dc cai order (l85)
            // xu ly cac truong hop (kt 26:29)
           
            Table bang = listTag as Table; // lấy ra table hiện tại 

            int idOrder = getUncheckoutOrderByTableId(bang.maban); // lấy ra id order hiện tại 
            // nếu table ko có thì nó trả về -1 

            // muốn insert thì phải lấy đc id order ( getLastIdOrder() )
            if (idOrder == -1)　// trường hợp ko có order 
            {
                AddOrder(bang.maban);  // xác nhận đây là order đầu tiên(ko trùng) thì mới add vào
                ManageOrderDetail(getLastIdOrder(), int.Parse(txtTenTU.Text), int.Parse(txtSL.Text), 1);
                lstOrderDetail.Items.Clear();
                listPhieuTU(selectedTable);
                MessageBox.Show("them phieu tu va ct phieu tu");
            }
            else if (idOrder != -1) // có order rồi 
            {
                // idOrder chứa các id order đã tồn tại rồi 
  
                ManageOrderDetail(idOrder, int.Parse(txtTenTU.Text), int.Parse(txtSL.Text), 1);
                DataProvider.Instance.ExecNonQuery("update phieuThucUong set iTrangThaiPhieu = 1 where iSoPhieuTU = " + getUncheckoutOrderByTableId(selectedTable));
                // chua them dc 
                lstOrderDetail.Items.Clear();
                listPhieuTU(selectedTable);
               

                MessageBox.Show("them ct phieu TU");
            }
        }

        void listPhieuTU(int ma) // show order cho table 
        {
            List<Menu> lstOrderDetails = getListMenuOrderDetail(getUncheckoutOrderByTableId(ma));
            //          getUncheckout.. lấy ra id để getList... lấy ra dc Return ds orderdetail
            //lstOrderDetail.Items.Clear();

            float tongTien = 0;
            foreach (Menu od in lstOrderDetails)
            {
                ListViewItem lsvItem = new ListViewItem(od.tenTU.ToString());
                lsvItem.SubItems.Add(od.soLuong.ToString());
                lsvItem.SubItems.Add(od.donGia.ToString());
                lsvItem.SubItems.Add(od.thanhtien.ToString());
                tongTien += od.thanhtien;

                lstOrderDetail.Items.Add(lsvItem);
            }
            txtTongTien.Text = tongTien.ToString();
        }

        List<Menu> getListMenuOrderDetail(int id)
        {
            List<Menu> lstMenu = new List<Menu>();

            DataTable data = DataProvider.Instance.ExecQuery
                ("select ptu.isophieutu,dmtu.vTenTU,ctptu.isoluong,dmtu.fdongia, dmtu.fdongia*ctptu.isoluong as thanhtien " +
                "from phieuThucUong as ptu, chiTietPhieuThucUong as ctptu, danhMucThucUong as dmtu " +
                "where ptu.iSoPhieuTU = ctptu.iSoPhieuTU and ctptu.iMaTU = dmtu.iMaTU " +
                "and iTrangThaiPhieu = 1 and ctptu.iSoPhieuTU =" + id);

            foreach (DataRow r in data.Rows)
            {
                Menu mnu = new Menu(r);
                lstMenu.Add(mnu);
            }
            return lstMenu;
        }

        public int getUncheckoutOrderByTableId(int id) //lấy ra dc id cua phieu thuc uong
        {
            string query = "select * from phieuThucUong where imaban =" + id + " and iTrangThaiPhieu between 1 and 2 ";
            // lay ra phieu chua lap hoa don
            // (lấy ra những bàn có phiếu chưa thanh toán )

            DataTable data = DataProvider.Instance.ExecQuery(query);

            
            if (data.Rows.Count > 0) 
            {
                
                order phieuTU = new order(data.Rows[0]);
                //MessageBox.Show("getUncheck"+phieuTU.idOrder.ToString());
                //MessageBox.Show(phieuTU.idOrder.ToString());
                return phieuTU.idOrder;
                //thành công trả về mã order
               
            }

            return -1; // thất bại trả về -1
            // -1 có nghĩa là id = -1 , có nghĩa là ko có thằng nào hết 
        }

        void AddOrder(int id)
        {
            DataProvider.Instance.ExecNonQuery("exec r_addOrder @imaban=" + id);

            DataProvider.Instance.ExecNonQuery("update ban set iTrangThaiBan = 2 where iMaBan ="+ id);

            // them luon ma nhan vien o day(sua lai store procedure 2 tham so)
        }

        void ManageOrderDetail(int idPhieu, int idTU, int sl, int mode)
        {
            if (mode == 1) // insert
                DataProvider.Instance.ExecNonQuery("exec r_addOrderDetail @iSoPhieuTU =" + idPhieu + " , @iMaTU =" + idTU + ", @iSoLuong =" + sl);
            
            
            else if (mode == 2) // update (ko cho update nua)
                DataProvider.Instance.ExecNonQuery("exec r_updateOrderDetail @iSoPhieuTU =" + idPhieu + " , @iMaTU =" + idTU + ", @iSoLuong =" + sl);
        }

        private int getLastIdOrder()
        {

            return (int)DataProvider.Instance.ExecScalar("select top(1)iSoPhieuTU from phieuThucUong order by iSoPhieuTU desc");
            // loi thi quay ve 31:21
        }

        private void dgvListTU_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = dgvListTU.CurrentCell.RowIndex;
            txtTenTU.Text = dgvListTU.Rows[indexRow].Cells[0].Value.ToString();
        }


        private void txtSearchTU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataView dv = dataTU.DefaultView;
                dv.RowFilter = string.Format("vTenTU like '%{0}%'", txtSearchTU.Text);
                dgvListTU.DataSource = dv.ToTable();
            }
        }

        private void btnXNBanTrong_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExecNonQuery("update ban set iTrangThaiBan = 1 where iMaBan =" + selectedTable);
            this.Close();
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
