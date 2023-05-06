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
using MyProject.Data.Entities;

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

        public void PrintBaoCao(DateTime start, DateTime end)
        {
            //end = end.AddDays(1);
            int countNhap = 0;
            decimal tienNhap = 0;
            int countXuat = 0;
            decimal tienXuat = 0;
            var listDonHang = _context.Orders.Where(x => x.OrderDate >= start && x.OrderDate <= end.AddDays(1)).ToList();
            var listPhieuNhap = _context.PhieuNhaps.Where(x => x.NgayGiao >= start && x.NgayGiao <= end.AddDays(1)).ToList();

            foreach (var item in listDonHang)
            {
                var listDetails = _context.OrderDetails.Where(x => x.OrderId == item.Id).ToList();
                
                foreach(var i in listDetails)
                {
                    countXuat += i.Quantity;
                    tienXuat += i.Price;
                }
            }

            foreach (var item in listPhieuNhap)
            {
                var listDetails = _context.ChiTietPhieuNhaps.Where(x => x.PhieuNhapId == item.MaPhieu).ToList();
                foreach (var i in listDetails)
                {
                    countNhap += i.SoLuong;
                    tienNhap += i.DonGia;
                }
            }

            // Load the PDF template file
            PdfDocument document = PdfReader.Open("BaoCao.pdf", PdfDocumentOpenMode.Modify);

            // Get the first page of the PDF document
            PdfPage page = document.Pages[0];

            // Create a graphics object for the page
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Set the font and font size for the text
            XFont font = new XFont("Arial", 12, XFontStyle.Regular);

            gfx.DrawString($"Từ Ngày {start.ToString("dd/MM/yyyy")} - {end.ToString("dd/MM/yyyy")}", font, XBrushes.Black, new XRect(180, 127, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

            gfx.DrawString($"{countNhap}", font, XBrushes.Black, new XRect(310, 186, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

            gfx.DrawString($"{tienNhap}", font, XBrushes.Black, new XRect(310, 206, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

            gfx.DrawString($"{countXuat}", font, XBrushes.Black, new XRect(310, 226, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

            gfx.DrawString($"{tienXuat}", font, XBrushes.Black, new XRect(310, 246, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

            gfx.DrawString($"{tienXuat - tienNhap}", font, XBrushes.Black, new XRect(160, 292, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

            string path = Path.Combine(_hostEnvironment.WebRootPath, "outputBaoCao.pdf");
            // Save the PDF document
            document.Save(path);
        }
    }
}
