using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO : IUser
    {
        public string ID { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public decimal Luong {  get; set; }//kiểu decimal chuyên tính toán tiền tệ
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
