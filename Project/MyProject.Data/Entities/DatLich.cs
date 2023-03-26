using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Data.Entities
{
    public class DatLich
    {
        public int Id { get; set; }
        public string TenNguoiDat{ get; set; }
        public string SoDienThoai { get; set; }
        public int ProductId { get; set; }
        public Product Products { get; set; }
        
    }
}
