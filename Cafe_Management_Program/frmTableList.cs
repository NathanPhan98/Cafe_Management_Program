using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Linq;

namespace Cafe_Management_Program
{
    public partial class frmTableList : Form
    {
        public frmTableList()
        {
            InitializeComponent();
        }
        private void frmTableList_Load(object sender, EventArgs e)
        {
            loadTable();
        }
        void loadTable() // hiển thị ra những button
        {
            //string statusConvertString;
            List<Table> listTable = loadTableList();


            foreach (Table i in listTable)
            {
                FlowLayoutPanel box = new FlowLayoutPanel();
                Button btn = new Button();
                string transtt = "";

                btn.Tag = i; // Tag kiểu dữ liệu là object, dùng để xác định ID của mỗi button
                btn.Width = 200;
                btn.Height = 200;
                btn.Font = new Font("Bahnschrift", 12,FontStyle.Bold);
                if (i.trangthai == 1)
                {
                    btn.BackColor = Color.Green;
                    transtt = "Trống";
                }
                else if (i.trangthai == 2)
                {
                    btn.BackColor = Color.DarkRed;
                    transtt = "Có khách";
                }
                else if (i.trangthai == 3)
                {
                    btn.BackColor = Color.Yellow;
                    transtt = "Đã thanh toán";
                }
                btn.Text = i.tenban + "\n" + transtt;

                btn.Click += btnTable_Click;

                flpTable.Controls.Add(btn);

            }
        }
        List<Table> loadTableList() // chuyển DataTable thành List<Table>
        {
            string query = "select * from ban";
            List<Table> tableList = new List<Table>();

            // tạo 1 datatable để execute query
            DataTable data = DataProvider.Instance.ExecQuery(query);
            // Datatable nó sẽ lấy ra 1 cái bản có row và col (như sql server) => tức là sẽ có n cái Row
            // suy ra là chuyển từng row thành List<> là được

            foreach (DataRow i in data.Rows) // trong danh sách dòng (data.Rows) ta lấy ra từng dòng
            {
                Table table = new Table(i); // cái này gióng như Table table = new Table("mã","tên bàn","trạng thái");
                tableList.Add(table); // chuyển từng dataRow vào list table
            }

            return tableList;
        }
        private void btnTable_Click(object sender, EventArgs e)
        {
            frmMakeOrder.selectedTable = ((sender as Button).Tag as Table).maban; // co the chua nhan

            // mỗi khi click vào thằng nào thì listview sẽ tag vào thằng đó
            frmMakeOrder.listTag = (sender as Button).Tag; // => luu dc table vo (kt 19:52)

            frmMakeOrder objfrm = new frmMakeOrder();
            objfrm.ShowDialog();
            flpTable.Controls.Clear();
            loadTable();
        }


        private void closeForm_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
