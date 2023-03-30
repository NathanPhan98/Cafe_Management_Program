using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Cafe_Management_Program
{
    public class orderDetail
    {
        public int idOrder, idTU, SoLuong;
        public string GhiChu;
        public orderDetail(int idOrder, int idTU, int SoLuong, string GhiChu)
        {
            this.idOrder = idOrder;
            this.idTU = idTU;
            this.SoLuong = SoLuong;
            this.GhiChu = GhiChu;
        }

        public orderDetail(DataRow row)
        {
            this.idOrder = (int)row["iSoPhieuTU"];
            this.idTU = (int)row["iMaTU"];
            this.SoLuong = (int)row["iSoLuong"];
            this.GhiChu = row["iGhiChu"].ToString();
        }

   
    }
}
