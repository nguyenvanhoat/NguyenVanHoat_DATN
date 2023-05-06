using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintService.Interface
{
    public interface IPrintService
    {
        public void Print(int orderId);
        public void PrintBaoCao(DateTime start, DateTime end);
    }
}
