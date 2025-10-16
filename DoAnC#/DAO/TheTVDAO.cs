using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class TheTVDAO
    {
        
        public bool luuTheTV(string name, string number, string diachi)
        {
            string checkQuery = "SELECT COUNT(*) FROM TheTV WHERE PhoneNumber = @PhoneNumber";
            using(SqlConnection conn = DataConnect.TaoKetNoi())
            {
                conn.Open();
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@PhoneNumber", number);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        return false;
                    }
                    else
                    {
                        string insertQuery = "INSERT INTO dbo.TheTV (UserID, FullName, PhoneNumber, DiaChi, TrangThai) " +
                                                "VALUES (@UserID, @FullName, @PhoneNumber, @DiaChi, @Status)";
                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@UserID", Session.userID);
                            insertCmd.Parameters.AddWithValue("@FullName", name);
                            insertCmd.Parameters.AddWithValue("@PhoneNumber", number);
                            insertCmd.Parameters.AddWithValue("@DiaChi", diachi);
                            insertCmd.Parameters.AddWithValue("@Status", 1);
                            insertCmd.ExecuteNonQuery();
                        }
                        return true;

                    }
                }
                    
            }
        }
    }
}
