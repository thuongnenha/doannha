using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class BillBUS
    {
        private BillDAO  billDAO = new BillDAO();
        public DataTable showData()
        {
            return billDAO.showData();
        }
        public bool checkTien(decimal tienDua, decimal sum)
        {
            return tienDua < sum;
        }
        public bool checkNull(string tienDua)
        {
            if(string.IsNullOrEmpty(tienDua))
            {
                return true;
            }
            return false;
        }
        public bool xacNhanThanhToan(decimal tienDua, decimal tienTra, decimal sum)
        {
            return billDAO.xacNhanThanhToan(tienDua, tienTra, sum);
        }
    }
}
