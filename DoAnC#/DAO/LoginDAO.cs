using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using DTO;



namespace DAO
{
    public class LoginDAO
    {
        public bool checkLoginAD(string email, string password)
        {
            using (SqlConnection conn = DataConnect.TaoKetNoi())
            {
                conn.Open();
                // Tạo SqlCommand với Stored Procedure
                SqlCommand cmd = new SqlCommand("CheckLoginAD", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                // Truyền tham số an toàn
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();//đọc dữ liệu trong database
                    var admin = SessionUser.ghiDuLieu<AdminDTO>(dr);
                    SessionUser.ganSession(admin);
                    return true;
                }
                return false;
            }
        }
        public bool checkLoginNV(string email, string password)
        {
            using (SqlConnection conn = DataConnect.TaoKetNoi())
            {
                conn.Open();
                // Tạo SqlCommand với Stored Procedure
                SqlCommand cmd = new SqlCommand("CheckLoginNV", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                // Truyền tham số an toàn
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    var nhanVien = SessionUser.ghiDuLieu<NhanVienDTO>(dr);
                    SessionUser.ganSession(nhanVien);
                    return true;
                }
                return false;
            }
        }
        
    }
}
