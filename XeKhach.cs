using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuexe
{
    internal class XeKhach:Xe
    {
        private double Sogiothue;
        private string HoTen;
        public override void Nhap()
        {
            Console.Write("Nhap ho ten nguoi thue:");
            HoTen = Console.ReadLine();
            Console.Write("Nhap so gio thue xe:");
            Sogiothue = Double.Parse(Console.ReadLine());
        }
        public override double TinhTien()
        {
            return 250000 + (Sogiothue - 1) * 70000;
        }
        public override void Hien()
        {
            Console.Write("Ho ten nguoi thue xe: {0}" +
                "So gio thue xe: {1}" +
                "Tong tien phai tra: {2}", HoTen, Sogiothue, TinhTien());
        }
    }
}
