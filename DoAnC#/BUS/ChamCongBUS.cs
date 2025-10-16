using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class ChamCongBUS
    {
        ChamCongDAO chamCong = new ChamCongDAO();
        public DateTime? gioVao()
        {
            return chamCong.gioVao();
        }
        public DateTime? gioRa(DateTime dt)
        {
            return chamCong.gioRa(dt);
        }
    }
}
