using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class ControlerBUS
    {
        public bool checkDangNhap()
        {
            if (Session.chucVu == "admin") return true;
            return false;
        }
    }
}
