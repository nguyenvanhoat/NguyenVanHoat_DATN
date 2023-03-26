using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Data.Entities
{
    public class ChiTietPhieuNhap
    {
        public int ID { get; set; }
        public string PhieuNhapId { get; set; }
        public int ProductId { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public string DVT { get; set; } 
        public Product Product { get; set; }
        public PhieuNhap PhieuNhap { get; set; }
    }
}
