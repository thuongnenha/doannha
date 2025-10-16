using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DTO;

namespace DAO
{
    public class StoreManegerDAO
    {
        public int demTables()
        {
            using (SqlConnection conn = DataConnect.TaoKetNoi())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM dbo.tables";
                SqlCommand cmd = new SqlCommand(query, conn);

                int count = (int)cmd.ExecuteScalar(); // Trả về số lượng dòng
                return count;
            }
        }
        public List<TablesDTO> taoTables()
        {
            List<TablesDTO> danhSachBan = new List<TablesDTO>();
            using (SqlConnection conn = DataConnect.TaoKetNoi())
            {
                conn.Open();
                string query = "SELECT * FROM dbo.tables";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TablesDTO table = new TablesDTO
                    {
                        ID = Convert.ToInt32(dr["ID"]),
                        Name = dr["Name"].ToString(),
                        Status = Convert.ToBoolean(dr["Status"])
                    };
                    danhSachBan.Add(table);
                }
                dr.Close();
            }
            return danhSachBan;
        }
        public List<ProductsDTO> LayDanhSachMon()
        {
            List<ProductsDTO> danhSachMon = new List<ProductsDTO>();
            string query = "SELECT * FROM dbo.products";

            using (SqlConnection conn = DataConnect.TaoKetNoi())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        danhSachMon.Add(new ProductsDTO
                        {
                            Name = dr["Name"].ToString(),
                            Gia = Convert.ToDecimal(dr["Gia"]),
                            CategoryID = (int)dr["CategoryID"],
                            MoTa = dr["MoTa"].ToString(),
                            ImageFood = dr["ImageFood"].ToString(),
                            TrangThai = Convert.ToBoolean(dr["TrangThai"]),
                            KhuyenMai = (int)dr["KhuyenMai"]
                        });
                    }
                    dr.Close();
                }
            }
            return danhSachMon;
        }
        public int checkSdt(string input)
        {
            using(SqlConnection conn = DataConnect.TaoKetNoi())
            {
                conn.Open();
                String query = "SELECT * FROM dbo.theTV WHERE PhoneNumber = @PhoneNumber";
                SqlCommand selectCmd = new SqlCommand(query, conn);
                selectCmd.Parameters.AddWithValue("@PhoneNumber", input);
                SqlDataReader dr = selectCmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    int id = (int)dr["ID"];
                    return id;
                }
                return 0;

            }
        }
        public int luuBill(SqlConnection conn, SqlTransaction tran, int theTV, decimal sum)
        {
            int newBillID = 0;

            String insertQuery = "INSERT INTO dbo.bill(TableID, UserID, TheID, Status, Sum) " +
                                    "VALUES (@TableID, @UserID, @TheID, @Status, @Sum) " +
                                    "SELECT SCOPE_IDENTITY()";
            try
            {
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn, tran))
                {
                    insertCmd.Parameters.AddWithValue("@TableID", Session.tablesID.ToString());
                    insertCmd.Parameters.AddWithValue("@UserID", Session.userID.ToString());
                    if(theTV != 0)
                    {
                        insertCmd.Parameters.AddWithValue("@TheID", theTV);
                    }
                    else
                    {
                        insertCmd.Parameters.AddWithValue("@TheID", DBNull.Value);
                    }
                    insertCmd.Parameters.AddWithValue("@Sum", sum);
                    insertCmd.Parameters.AddWithValue("@Status", false);
                    
                    newBillID = Convert.ToInt32(insertCmd.ExecuteScalar());
                    return newBillID;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }
        public int checkBillOpen(int tableID)
        {
            try
            {
                using (SqlConnection conn = DataConnect.TaoKetNoi())
                {
                    conn.Open();
                    string query = "SELECT TOP 1 ID FROM dbo.bill WHERE TableID = @TableID AND Status = 0 ORDER BY ID DESC";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TableID", tableID);

                    var result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0; // 0 nghĩa là chưa có bill đang mở
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }
        public int updateBill(SqlConnection conn, SqlTransaction tran, int tableID, decimal sum)
        {
            
            string updateQuery = "UPDATE dbo.bill SET Sum = @Sum OUTPUT inserted.ID WHERE TableID = @TableID AND Status = 0";
            try
            {   
                using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn, tran))
                {
                    updateCmd.Parameters.AddWithValue("@Sum", sum);
                    updateCmd.Parameters.AddWithValue("@TableID", tableID);
                    var IDBillUpdate = updateCmd.ExecuteScalar();
                    return IDBillUpdate != null ? Convert.ToInt32(IDBillUpdate) : 0;
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }
        public int checkProductTonTai(SqlConnection conn, SqlTransaction tran, int billID, int ProductsID)
        {
            try
            {
                string query = "SELECT ProductsID FROM dbo.billInfo WHERE BillID = @billID AND ProductsID = @ProductsID ";
                SqlCommand cmd = new SqlCommand(query, conn, tran);
                cmd.Parameters.AddWithValue("@billID", billID);
                cmd.Parameters.AddWithValue("@ProductsID", ProductsID);

                var result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }
        private void XoaSanPhamKhongConTrongDanhSach(SqlConnection conn, SqlTransaction tran, int billID, List<BillInfoDTO> danhSachMon)
        {
            // Lấy danh sách ProductsID hiện có trong billInfo
            var currentProductIDs = new List<int>();
            string selectQuery = "SELECT ProductsID FROM dbo.billInfo WHERE BillID = @BillID";
            using (SqlCommand cmd = new SqlCommand(selectQuery, conn, tran))
            {
                cmd.Parameters.AddWithValue("@BillID", billID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) 
                    {
                        currentProductIDs.Add(reader.GetInt32(0));
                    }
                }
            }

            // Tìm các sản phẩm đã bị xóa khỏi DataGridView
            var newProductIDs = danhSachMon.Select(m => m.ProductsID).ToList();
            var productsToDelete = currentProductIDs.Except(newProductIDs).ToList();
            Console.WriteLine("Current product IDs in DB: " + string.Join(",", currentProductIDs));
            Console.WriteLine("New product IDs from UI: " + string.Join(",", newProductIDs));

            foreach (var productID in productsToDelete)
            {
                string deleteQuery = "DELETE FROM dbo.billInfo WHERE BillID = @BillID AND ProductsID = @ProductsID";
                using (SqlCommand cmd = new SqlCommand(deleteQuery, conn, tran))
                {
                    cmd.Parameters.AddWithValue("@BillID", billID);
                    cmd.Parameters.AddWithValue("@ProductsID", productID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void updateBillInfo(SqlConnection conn, SqlTransaction tran, int billID, List<BillInfoDTO> danhSachMon)
        {
            XoaSanPhamKhongConTrongDanhSach(conn, tran, billID, danhSachMon);
            foreach (var item in danhSachMon)
            {
                if (checkProductTonTai(conn, tran, billID, item.ProductsID) == 0)
                {
                    string query = "INSERT INTO dbo.billInfo (BillID, ProductsID, SoLuong, Gia, ThanhTien, KhuyenMai) " +
                               "VALUES (@BillID, @ProductsID, @SoLuong, @Gia, @ThanhTien, @KhuyenMai)";

                    using (SqlCommand cmd = new SqlCommand(query, conn, tran))
                    {
                        cmd.Parameters.AddWithValue("@BillID", billID);
                        cmd.Parameters.AddWithValue("@ProductsID", item.ProductsID);
                        cmd.Parameters.AddWithValue("@SoLuong", item.SoLuong);
                        cmd.Parameters.AddWithValue("@Gia", item.Gia);
                        cmd.Parameters.AddWithValue("@ThanhTien", item.ThanhTien);

                        cmd.Parameters.AddWithValue("@KhuyenMai", item.KhuyenMai);

                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    string updateQuery = "UPDATE dbo.billInfo " +
                                "SET SoLuong = @SoLuong , Gia = @Gia , ThanhTien = @ThanhTien , KhuyenMai = @KhuyenMai " +
                                "WHERE BillID = @BillID and ProductsID = @ProductsID ";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn, tran))
                    {
                        cmd.Parameters.AddWithValue("@BillID", billID);
                        cmd.Parameters.AddWithValue("@ProductsID", item.ProductsID);
                        cmd.Parameters.AddWithValue("@SoLuong", item.SoLuong);
                        cmd.Parameters.AddWithValue("@Gia", item.Gia);
                        cmd.Parameters.AddWithValue("@ThanhTien", item.ThanhTien);
                        cmd.Parameters.AddWithValue("@KhuyenMai", item.KhuyenMai);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
        public void luuBillInfo(SqlConnection conn, SqlTransaction tran, int billID, List<BillInfoDTO> danhSachMon)
        {
            foreach (var item in danhSachMon)
            {
                string query = "INSERT INTO dbo.billInfo (BillID, ProductsID, SoLuong, Gia, ThanhTien, KhuyenMai) " +
                               "VALUES (@BillID, @ProductsID, @SoLuong, @Gia, @ThanhTien, @KhuyenMai)";

                using (SqlCommand cmd = new SqlCommand(query, conn, tran))
                {
                    cmd.Parameters.AddWithValue("@BillID", billID);
                    cmd.Parameters.AddWithValue("@ProductsID", item.ProductsID);
                    cmd.Parameters.AddWithValue("@SoLuong", item.SoLuong);
                    cmd.Parameters.AddWithValue("@Gia", item.Gia);
                    cmd.Parameters.AddWithValue("@ThanhTien", item.ThanhTien);

                    cmd.Parameters.AddWithValue("@KhuyenMai", item.KhuyenMai);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void updateTable(int tableID)
        {
            using (SqlConnection conn = DataConnect.TaoKetNoi())
            {
                conn.Open();
                string update = "UPDATE dbo.tables SET Status = ~Status WHERE ID = @TablesID";
                try
                {
                    
                    using (SqlCommand cmd = new SqlCommand(update, conn))
                    {
                        cmd.Parameters.AddWithValue("@TablesID", tableID);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi cập nhật: " + ex.Message);
                }
            }
        }
        public bool LuuBillVaChiTiet(int theTV, List<BillInfoDTO> danhSachMon,decimal sum)
        {
            int billID = 0;
            using (SqlConnection conn = DataConnect.TaoKetNoi())
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();
                try
                {
                    int checkStatus = checkBillOpen(Session.tablesID);
                    if(checkStatus == 0)
                    {
                        billID = luuBill(conn, tran, theTV, sum);
                        luuBillInfo(conn, tran, billID, danhSachMon);
                        updateTable(Session.tablesID);
                    }
                    else
                    {
                        billID = updateBill(conn, tran, Session.tablesID, sum);
                        updateBillInfo(conn, tran, billID, danhSachMon) ;
                    }

                    tran.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }
        public int LayIDMonTheoTen(string tenMon)
        {
            using (SqlConnection conn = DataConnect.TaoKetNoi())
            {
                conn.Open();
                string query = "SELECT ID FROM products WHERE Name = @tenMon";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tenMon", tenMon);

                object result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
        }
        public string showSDT(int tableID)
        {
            try
            {
                using (SqlConnection conn = DataConnect.TaoKetNoi())
                {
                    conn.Open();
                    string query = "SELECT theTV.PhoneNumber " +
                                        "FROM bill , theTV " +
                                        "WHERE bill.TheID = theTV.ID and bill.TableID = @tableID and bill.Status = 0";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@tableID", tableID);
                    object result = cmd.ExecuteScalar();
                    if (result != null) 
                    {
                        return result.ToString();
                    }

                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "";
        }
        public DataTable showData()
        {
            try
            {
                using (SqlConnection conn = DataConnect.TaoKetNoi())
                {
                    string query = "SELECT p.ImageFood, p.Name, bi.SoLuong, bi.ThanhTien " +
                                        "FROM bill as b, billInfo as  bi, Products as p " +
                                        "WHERE b.ID = bi.BillID and bi.ProductsID = p.ID and b.TableID = @TableID and b.Status = 0 ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TableID", Session.tablesID);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public bool checkStatusTable(int tableID)
        {
            try
            {
                using (SqlConnection conn = DataConnect.TaoKetNoi())
                {
                    conn.Open();
                    string select = "SELECT Status FROM dbo.tables WHERE ID = @Table";
                    SqlCommand cmd = new SqlCommand(select, conn);
                    cmd.Parameters.AddWithValue("@Table", tableID);
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToBoolean(result); // result là kiểu bit nên chuyển thành bool luôn
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        public bool chuyenTable(int tableID)
        {
            if(!checkStatusTable(tableID))
            {
                try
                {
                    using (SqlConnection conn = DataConnect.TaoKetNoi())
                    {
                        conn.Open();
                        string query = "UPDATE dbo.bill " +
                                        "SET TableID = @TableIDNew " +
                                        "WHERE TableID = @TableID ";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@TableIDNew", tableID);
                        cmd.Parameters.AddWithValue("@TableID", Session.tablesID);
                        cmd.ExecuteNonQuery();  
                    }
                    updateTable(tableID);
                    updateTable(Session.tablesID);
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return false ;
        }
        public bool ghepTable(int tableGhep)
        {
            try
            {
                using (SqlConnection conn = DataConnect.TaoKetNoi())
                {
                    conn.Open();
                    string update = "UPDATE dbo.bill " +
                        "SET GroupTableID = @GroupTableID " +
                        "WHERE TableID = @TableID ";
                    SqlCommand cmd = new SqlCommand(update, conn);
                    cmd.Parameters.AddWithValue("@GroupTableID", tableGhep);
                    cmd.Parameters.AddWithValue("@TableID", Session.tablesID);
                    cmd.ExecuteNonQuery();
                    updateTable(tableGhep);
                    return true;

                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false ;
        }
        public int? checkKM(int TableID)
        {
            try
            {
                using (SqlConnection conn = DataConnect.TaoKetNoi())
                {
                    conn.Open();
                    string query = "SELECT TheID FROM bill WHERE TableID = @TableID and Status = 0";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TableID", TableID);

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return 10;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

    }
}
