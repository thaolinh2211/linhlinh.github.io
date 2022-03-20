using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien
{ /* ma sinh vien
   * ho ten
   * nam sinh
   * diem lap trinh
   * diem csdl
   * diem tb , diem tb = (diem lap trinh + diem csdl)/2 */

    internal class Sinhvien
    {
        private string msv;
        private string hoten;
        private int namsinh;
        private double diemlt;
        private double dcsdl;
        private double dtb;
        private string quequan;
        public Sinhvien()
        {
        }
        public Sinhvien( string hoten, int namsinh, string quequan, double diemlt, double dcsdl)
        {
            this.hoten = hoten;
            this.namsinh = namsinh;
            this.quequan = quequan;
            this.diemlt = diemlt;
            this.dcsdl = dcsdl;
        }
        public void NhapTT()
        {
            Console.WriteLine("Nhap ho ten:");
            hoten = Convert.ToString(hoten);
            Console.WriteLine("Nhap ma sinh vien:");
            msv = Convert.ToString(msv);
            Console.WriteLine("Nhap nam sinh:");
            namsinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap diem lap trinh:");
            diemlt = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Nhap diem co so du lieu:");
            dcsdl = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap diem trung binh:");
            dtb = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" ");
        }
        public void DiemTB(Sinhvien sv)
        {
            double dtb = (diemlt + dcsdl) / 2;
        }
        public void XuatTT()
        {
            Console.WriteLine("Thong tin sinh vien la:{0}, {1}, {2},{3},{4},{5},{6}", hoten, msv, namsinh, diemlt, dcsdl, dtb);
        }
    }
}
