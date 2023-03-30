using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Cafe_Management_Program
{
    public class phieuThuCT
    {
        public int iSoPhieuThu, iMaTU, soLuong;
        public float fDonGia;
        public phieuThuCT(int iSoPhieuThu, int iMaTU, int soLuong, float fDonGia)
        {
            this.iSoPhieuThu = iSoPhieuThu;
            this.iMaTU = iMaTU;
            this.soLuong = soLuong;
            this.fDonGia = fDonGia;
        }

        public phieuThuCT(DataRow row)
        {
            this.iSoPhieuThu = (int)row["iSoPhieuThu"];
            this.iMaTU = (int)row["iMaTU"];
            this.soLuong = (int)row["soLuong"];
            this.fDonGia = Convert.ToSingle(row["fDonGia"]);
        }
    }
}
