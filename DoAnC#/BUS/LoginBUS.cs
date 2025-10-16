using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.IO.Pipes;
using System.Text.RegularExpressions;


namespace BUS
{
    public class LoginBUS
    {
        private LoginDAO loginDAO = new LoginDAO();

        public string checkInputTk(string userInput)
        {
            if (string.IsNullOrEmpty(userInput))
            {
                return "Không được để trống!!!";
            }
            else if (!new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$").IsMatch(userInput))
            {
                return "Email không hợp lệ !!!";
            }
            return null;
        }
        public string checkInputMK(string userInput)
        {

            if (string.IsNullOrEmpty(userInput))
            {
                return "Không được để trống!!!";
            }
            return null;
        }
        public bool ViPham(string email, string password)
        {
            return string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password);//hàm trả về false nếu > 1 null
        }

        public bool CheckLogin(string email, string password)
        {
            if (loginDAO.checkLoginAD(email, password)) return true;
            else if (loginDAO.checkLoginNV(email, password)) return true;
            return false;
        }

    }
}
