using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class TheTVBUS
    {
        private TheTVDAO theTVDAO = new TheTVDAO();
        public string checkInput(string str)
        {
            if (string.IsNullOrEmpty(str)) return "Không được để trống !!!";
            return null;
        }
        public string checkPhonNumber(string str)
        {
            if (str.Length < 10) return "Số điện thoại có vài số thôi à ?";
            return null;
        }
        public bool taoTheTV(string name, string sdt, string diachi)
        {
            return theTVDAO.luuTheTV(name, sdt, diachi);
        }
    }
}
