using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductsDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Gia { get; set; }
        public int CategoryID {  get; set; }
        public string MoTa { get; set; }
        public string ImageFood { get; set; }
        public bool TrangThai { get; set; }
        public int KhuyenMai {  get; set; }
    }
}
