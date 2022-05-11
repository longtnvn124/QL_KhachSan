using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKSpj.DAO
{
    public class dataprovider
    {
        public static string sqlstring = "Data Source=ADMIN-PC\\PIKA;Initial Catalog=QLKS;Integrated Security=True";
    
        public static DataTable ExQuery(string query)
        {
            SqlConnection ketNoi = new SqlConnection(sqlstring);
            //query = "SELECT * FROM KhachHang ";

            ketNoi.Open();
            SqlCommand command = new SqlCommand(query, ketNoi);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table); 
            ketNoi.Close();
            return table;
        }
        public static void addconnect(string query)
        {
            //try
            //{
                SqlConnection connection = new SqlConnection(sqlstring);
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery(); //Chạy lệnh sql
                command.Dispose(); //Giải phóng bộ nhớ
                connection.Close();
                
           // }
           // catch
            //{
              //  MessageBox.Show("Có lỗi xảy ra! Vui lòng kiểm tra lại!");
           // }
        }
    }
}
