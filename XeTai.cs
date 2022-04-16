using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuexe
{
    public class XeTai:Xe 
    {
        private double SoGiothue;
        private string HoTen;
        public override void Nhap()
        {
            Console.Write("Nhap ho ten nguoi thue xe:");
            HoTen = Console.ReadLine();
            Console.Write("Nhap so gio thue xe:");
            SoGiothue = Double.Parse(Console.ReadLine());
        }
        public override double TinhTien() 
        {
            return 220000 + (SoGiothue - 1) * 85000;
        }
        public override void Hien()
        {
            Console.Write("Ho ten nguoi thue xe: {0}, " +
                "so gio thue xe:{1}," +
                " tong tien phai tra: {2}", HoTen, SoGiothue, TinhTien());
        }
    }
}
