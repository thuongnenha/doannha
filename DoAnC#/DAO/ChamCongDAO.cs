using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class ChamCongDAO
    {
        public DateTime? gioVao()
        {
            try
            {
                using (SqlConnection conn = DataConnect.TaoKetNoi())
                {
                    conn.Open();
                    string query = "INSERT INTO chamcong (UserID, Ngay, GioVao, GioRa, WorkingTime) " +
                                        "VALUES (@UserID, @Ngay, @GioVao, @GioRa, @WorkingTime)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    DateTime now = DateTime.Now;
                    cmd.Parameters.AddWithValue("@UserID", Session.userID);
                    cmd.Parameters.AddWithValue("@Ngay", now);
                    cmd.Parameters.AddWithValue("@GioVao", now.TimeOfDay);
                    cmd.Parameters.AddWithValue("@GioRa", DBNull.Value);
                    cmd.Parameters.AddWithValue("@WorkingTime", DBNull.Value);
                    cmd.ExecuteNonQuery();
                    return now;
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return null;    
        }
        public DateTime? gioRa(DateTime dt)
        {
            try
            {
                using(SqlConnection conn = DataConnect.TaoKetNoi())
                {
                    conn.Open();
                    string query = "UPDATE chamcong " +
                                        "SET GioRa = @GioRa , WorkingTime = @WorkingTime " +
                                        "WHERE Ngay = @Ngay and UserID = @UserID ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    DateTime now = DateTime.Now;
                    TimeSpan workingTime = now - dt;
                    cmd.Parameters.AddWithValue("@GioRa", now.TimeOfDay);
                    cmd.Parameters.AddWithValue("@WorkingTime", Convert.ToInt32(Math.Floor(workingTime.TotalHours)));
                    cmd.Parameters.AddWithValue("@Ngay", dt);
                    cmd.Parameters.AddWithValue("UserID", Session.userID);
                    cmd.ExecuteNonQuery();
                    return now;
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return null;
        }
    }
}
