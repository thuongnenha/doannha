using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BillInfoDTO
    {
        public int ID { get; set; }
        public int BillID { get; set; }
        public int ProductsID { get; set; }
        public int SoLuong { get; set; }
        public decimal Gia { get; set; }
        public decimal ThanhTien { get; set; }
        public int KhuyenMai { get; set; }
    }
}
