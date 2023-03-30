using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Cafe_Management_Program
{
    public class DataProvider
    {
        string conStr = @"Data Source=.\sqlexpress;Initial Catalog=db_quanlybanhang;Integrated Security=True";


        // mỗi lần muốn lấy data ra chúng ta đều phải new 1 cái DataProvider, như vậy có thể phát sinh vấn đề
        // là 1 lần sẽ có nhiều connection string 1 lúc.
        // Câu hỏi đặt ra: làm sao tại 1 thời điểm chỉ có duy nhất 1 instance (1 thể hiện của 1 thằng nào đó) được tạo ra ?
        // câu trả lời : dùng static (vì tính chất của static là duy nhất)
        private static DataProvider instance; // bất cứ thứ gì mà thông qua 'instance' để lấy ra thì nó là "duy nhất"

        // phím tắt tạo đóng gói nhanh : ctrl + r + e (lưu ý nhớ trỏ vào proberty trước)
        public static DataProvider Instance 
        {   //kiến trúc singleton
            get {
                if (instance == null) instance = new DataProvider();  // như vầy thôi k cần new mỗi cái nữa
                    return DataProvider.instance; 
                }
            private set { DataProvider.instance = value; } // thêm private để nội bộ class thôi được set thôi,
                                                           // bên ngoài ko được sài tới
        }
        // Muốn tạo đói tượng chỉ đơn giản như vậy 
        //dgv.DataSource = DataProvider.Instance.ExecQuery(query);
        // chứ ko cần như vậy nữa 
        //DataProvider provider = new DataProvider();
        //dgv.DataSource = provider.ExecQuery(query);


        private DataProvider() // cho hàm dựng của nó là private , để đảm bảo bên ngoài không thể nào tác động 
        {                      // được, chỉ có lấy ra thôi 
        } 

        public DataTable ExecQuery(string query) // Dùng cho Select 
        {
            DataTable data = new DataTable();

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open(); //lưu ý nhớ mở connection ra như thế này

                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command); // thằng này là thằng trung gian để lấy dữ liệu

                adapter.Fill(data);// có dữ liệu rồi thì đổ dữ liệu vào "data"

                conn.Close(); // mở ra nhớ đóng lại
            }
            // khi ko sài using nếu chưa tới bước conn.Close() mà các bước trên bị lỗi thì thì nó sẽ dẩn tới các row
            // phía sau bị lỗi. Cho nên phải tự giải phóng bộ nhớ 

            // "Using" : cho dù vấn đề gì đi nữa, khi mà kết thúc khối lệnh trong using rồi thì dữ liệu được khai báo
            // trong () nó sẽ tự được giải phóng 

            return data; //  "Trả về DataTable"
        }

        public int ExecNonQuery(string query) // Dùng cho insert, update, delete (dùng int vì trả ra số dòng thành công)
        {
            int data = 0;

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);

                data = command.ExecuteNonQuery();

                conn.Close();
            }

            return data; // khi insert, update, delete,... thì sẽ trả ra số dòng thành công 
            // làm vậy để khỏi trả cả 1 table cho nặng dữ lịu
        }

        public object ExecScalar(string query) // dùng cho câu query Count *
        {
            object data = 0;

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open(); 

                SqlCommand command = new SqlCommand(query, conn);

                data = command.ExecuteScalar(); // thực hiện query và trả về cột đầu tiên của dòng trong kết quả
                                                // có nghĩa là ô đầu tiên   
                conn.Close(); 
            }

            return data;
        }

   
    }
}
