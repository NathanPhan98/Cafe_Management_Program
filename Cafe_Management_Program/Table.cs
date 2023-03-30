using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Cafe_Management_Program
{
    public class Table
    {
        public int maban;
        public string tenban;
        public int trangthai;

        public Table(int maban, string tenban, int trangthai)
        {
            this.maban = maban;
            this.tenban = tenban;
            this.trangthai = trangthai;
        }
        public Table(DataRow row) // hàm dựng (khởi tạo) để xử lý datarow đưa vào 
        {
            this.maban = (int)row["iMaBan"];
            this.tenban = row["vTenBan"].ToString();
            this.trangthai = (int)row["iTrangThaiBan"];
        }

    }
}
