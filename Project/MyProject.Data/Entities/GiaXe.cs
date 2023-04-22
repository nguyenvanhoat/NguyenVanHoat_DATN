using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Data.Entities
{
    public class GiaXe
    {
        public int Id { get; set; }
        public string MauXe { get; set; }
        public decimal Gia { get; set; }
        public int SanPhamId { get; set; }
        public Product Product { get; set; }
    }
}
