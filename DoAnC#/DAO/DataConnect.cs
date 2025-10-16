using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAO
{
    public static class DataConnect
    {
        static string strConnect = "Data Source=DESKTOP-31FQEF0\\THUONGDO;Initial Catalog=QLQuanCF;Integrated Security=True;Encrypt=True";
        public static SqlConnection TaoKetNoi()
        {
            return new SqlConnection(strConnect);
        }
        public static SqlDataReader TruyVan(string truyvan, SqlConnection conn)
        {
            SqlCommand comm = new SqlCommand(truyvan, conn);
            return comm.ExecuteReader();
        }

        public static int ThucThi(string thucthi, SqlParameter[] sp, SqlConnection conn)
        {
            SqlCommand comm = new SqlCommand(thucthi, conn);
            comm.Parameters.AddRange(sp);
            return comm.ExecuteNonQuery();
        }

        public static int Xoa(string xoa, SqlConnection conn)
        {
            SqlCommand comm = new SqlCommand(xoa, conn);
            return comm.ExecuteNonQuery();
        }
    }
}
