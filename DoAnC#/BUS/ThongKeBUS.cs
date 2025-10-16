using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class ThongKeBUS
    {
        ThongKeDAO thongKeDAO = new ThongKeDAO();
        public DataTable showSPUTN()
        {
            return thongKeDAO.showSPUTN();
        }
        public DataTable showNVBNN()
        {
            return thongKeDAO.showNVBNN();
        }
        public DataTable showDT()
        {
            return thongKeDAO.showDT();
        }
    }
}
