using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Data.Entities
{
    public class ChiTietBaoHanh
    {
        public int Id { get; set; }
        public DateTime Ngay{ get; set; }
        public string ChiTiet { get; set; }
        public int BaoHanhId { get; set; }
        public BaoHanh BaoHanh { get; set; }
    }
}
