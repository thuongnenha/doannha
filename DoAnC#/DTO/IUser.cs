using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public interface IUser
    {
        string ID { get; set; }
        string Ho { get; set; }
        string Ten { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }
        string Password { get; set; }
    }
}
