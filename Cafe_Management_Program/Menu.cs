using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Cafe_Management_Program
{
    class Menu
    {
        public int soLuong;
        public string tenTU;
        public float donGia, thanhtien;

        public Menu( string tenTU, int soLuong, float thanhtien, float donGia)
        {
            this.tenTU = tenTU;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.thanhtien = thanhtien;   
        }

        public Menu(DataRow row)
        {
            this.tenTU = row["vTenTU"].ToString();
            this.soLuong = (int)row["iSoLuong"];
            this.donGia = float.Parse(row["fDonGia"].ToString());
            this.thanhtien = float.Parse(row["thanhtien"].ToString());
        }


    }
}
