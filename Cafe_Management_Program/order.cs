using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Cafe_Management_Program
{
    class order
    {
        public int idOrder, idBan, idNV, stt;
        public order(int idOrder, int idBan, int idNV, int stt)
        {
            this.idOrder = idOrder;
            this.idBan = idBan;
            this.idNV = idNV;
            this.stt = stt;
        }

        public order (DataRow row)
        {
            this.idOrder = (int)row["iSoPhieuTU"];
            this.idBan = (int)row["iMaBan"];
            this.idNV = (int)row["iMaNV"];
            this.stt = (int)row["iTrangThaiPhieu"];
        }
        
    }
}
