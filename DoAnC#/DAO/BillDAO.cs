using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class BillDAO
    {
        private StoreManegerDAO storeManegerDAO = new StoreManegerDAO();
        public DataTable showData()
        {
            try
            {
                using (SqlConnection conn = DataConnect.TaoKetNoi())
                {
                    string query = "SELECT p.Name, bi.Gia, bi.SoLuong, bi.ThanhTien " +
                                        "FROM bill as b, billInfo as  bi, Products as p " +
                                        "WHERE b.ID = bi.BillID and bi.ProductsID = p.ID and b.TableID = @TableID and b.Status = 0 ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TableID", Session.tablesID);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
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
        public object LayGroupTableID()
        {
            using (SqlConnection conn = DataConnect.TaoKetNoi())
            {
                string query = "SELECT GroupTableID FROM dbo.bill WHERE TableID = @TableID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TableID", Session.tablesID);

                conn.Open();
                object result = cmd.ExecuteScalar();

                // Trả về null nếu cột là NULL trong SQL
                if (result == DBNull.Value)
                    return null;

                return result; // Có thể là int, string... tùy kiểu dữ liệu trong CSDL
            }
        }
        public bool xacNhanThanhToan(decimal tienDua, decimal tienTra, decimal sum)
        {
            try
            {
                using (SqlConnection conn = DataConnect.TaoKetNoi())
                {
                    conn.Open();
                    DateTime timeOut = DateTime.Now;
                    string updateBill = "UPDATE dbo.bill " +
                                            "SET Sum = @Sum , TienKhachDua = @TienKhachDua , TienTraKhach = @TienTraKhach , Status = @Status , TimeOutBill = @TimeOutBill " +
                                            "WHERE TableID = @TableID and Status = 0";
                    SqlCommand cmd = new SqlCommand(updateBill, conn);
                    cmd.Parameters.AddWithValue("@TienKhachDua", tienDua);
                    cmd.Parameters.AddWithValue("@TienTraKhach", tienTra);
                    cmd.Parameters.AddWithValue("@Status", 1);
                    cmd.Parameters.AddWithValue("@TimeOutBill", timeOut);
                    cmd.Parameters.AddWithValue("TableID", Session.tablesID);
                    cmd.Parameters.AddWithValue("@Sum", sum);
                    object groupID = LayGroupTableID();
                    if (groupID != null)
                    {
                        storeManegerDAO.updateTable(Convert.ToInt32(groupID));
                    }
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
