using PrintService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using PdfSharpCore.Pdf;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf.IO;
using MyProject.Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Hosting;

namespace PrintService.Implement
{
    public class PrintHelperService : IPrintService
    {
        private readonly AppDbContext _context;
        private IWebHostEnvironment _hostEnvironment;

        public PrintHelperService(AppDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _hostEnvironment = environment;
        }
        public void Print(int orderId)
        {
            var order = _context.Orders.FirstOrDefault(p => p.Id == orderId); 
            // Load the PDF template file
            PdfDocument document = PdfReader.Open("HDSAMPLE.pdf", PdfDocumentOpenMode.Modify);

            // Get the first page of the PDF document
            PdfPage page = document.Pages[0];

            // Create a graphics object for the page
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Set the font and font size for the text
            XFont font = new XFont("Arial", 12, XFontStyle.Regular);

            // Draw the text onto the page
            gfx.DrawString(order.Name, font, XBrushes.Black, new XRect(150, 127, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString(order.Address + " - " + order.PhoneNumber, font, XBrushes.Black, new XRect(105, 158, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

            var listProduct = _context.OrderDetails.Where(x => x.OrderId == orderId).Include("Product").ToList();

            decimal total = 0;
            double y = 218;
            for (int i = 0; i < listProduct.Count(); i++)
            {
                var gia = _context.GiaXes.Where(x => x.ProductId == listProduct[i].ProductId && x.MauXe == listProduct[i].Color).FirstOrDefault();
                gfx.DrawString(listProduct[i].Product.ProductName.ToString() + " - " + listProduct[i].Color, font, XBrushes.Black, new XRect(90, y, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                gfx.DrawString("1", font, XBrushes.Black, new XRect(300, y, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                gfx.DrawString(gia.Gia.ToString(), font, XBrushes.Black, new XRect(323, y, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                gfx.DrawString(gia.Gia.ToString(), font, XBrushes.Black, new XRect(460, y, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                y += 23.5;
                total += gia.Gia;
            }

            gfx.DrawString(total.ToString(), font, XBrushes.Black, new XRect(460, 570.5, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
            string path = Path.Combine(_hostEnvironment.WebRootPath, "output.pdf");
            // Save the PDF document
            document.Save(path);
        }
    }
}
