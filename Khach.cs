using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuexe
{
    internal class Khach
    {
        private string HoTen;
        private double Sogiothue;
        private string LoaiXeThue;
    }
    public void Nhap() 
    {
        Console.Write("Nhap ho ten khach hang:");
        HoTen = Console.ReadLine();
        Console.Write("Nhap so gio thue xe:");
        Sogiothue = Double.Parse(Console.ReadLine());
        Console.Write("Nhap loai xe thue:");
        LoaiXeThue = Console.ReadLine();
    }
    public double TinhTien( double Sogiothue)
    {

    }
}
