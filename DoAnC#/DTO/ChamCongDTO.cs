using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChamCongDTO
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public DateTime? Ngay {  get; set; }
        public TimeSpan? GioVao { get; set; }
        public TimeSpan? GioRa { get; set; }
        public int? WorkingTime {  get; set; }
    }
}
