using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ThongKeDAO
    {
        public DataTable showSPUTN()
        {
            try
            {
                using (SqlConnection conn = DataConnect.TaoKetNoi())
                {
                    conn.Open();
                    string query = "SELECT TOP 1 ProductsID, products.Name, products.MoTa, products.Gia, SUM(SoLuong) AS TongSoLuong " +
                        "FROM billInfo, products " +
                        "WHERE billInfo.ProductsID = products.ID " +
                        "GROUP BY ProductsID, products.Name, products.MoTa, products.Gia " +
                        "ORDER BY TongSoLuong DESC ";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public DataTable showNVBNN()
        {
            try
            {
                using (SqlConnection conn = DataConnect.TaoKetNoi())
                {
                    conn.Open();
                    string query = "SELECT TOP 1 " +
                        "UserID, " +
                        "COUNT(*) AS SoLuongBill, " +
                        "SUM(Sum) AS TongTienBanDuoc " +
                        "FROM bill " +
                        "WHERE UserID IS NOT NULL " +
                        "GROUP BY UserID " +
                        "ORDER BY SoLuongBill DESC ";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public DataTable showDT()
        {
            try
            {
                using (SqlConnection conn = DataConnect.TaoKetNoi())
                {
                    conn.Open();
                    string query = "SELECT " +
                        "b.ID AS MaHoaDon, " +
                        "b.UserID AS NhanVienBan, " +
                        "b.CreatedAt AS NgayTao, " +
                        "b.Sum AS TongTien " +
                        "FROM Bill b " +
                        "WHERE b.Status = 1 ";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
