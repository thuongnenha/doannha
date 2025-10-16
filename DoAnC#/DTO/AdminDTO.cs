using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AdminDTO : IUser
    {
        public string ID {  get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
