using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Data.Entities
{
    public class BaoHanh
    {
        public BaoHanh()
        {
            ChiTietBaoHanhs = new HashSet<ChiTietBaoHanh>();
        }
        public int Id { get; set; }
        public DateTime NgayMua { get; set; }
        public string SoMay { get; set; }
        public string SoDienThoai { get; set; }
        public ICollection<ChiTietBaoHanh> ChiTietBaoHanhs { get; set; }
    }
}
