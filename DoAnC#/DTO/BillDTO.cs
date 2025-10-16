using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BillDTO
    {
        public int ID {  get; set; }
        public int TableID {  get; set; }
        public string UserID {  get; set; }
        public int? TheID {  get; set; }
        public bool Status {  get; set; }
        public decimal TienKhachDua {  get; set; }
        public decimal TienTraKhach {  get; set; }
        public decimal Sum {  get; set; }
    }
}
