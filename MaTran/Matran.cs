using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaTran
{
    internal class Matran
    {
        private int m; //so dong
        private int n; //so cot
        private int[,] a; //Mang 2 chieu
        public Matran(int m, int n)
        {
            this.m = m;
            this.n = n;
            a = new int[m, n];
        }
        public void Nhap()
        {
            Console.Write("Nhap so dong:");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so cot:");
            n = Convert.ToInt32(Console.ReadLine());
            a = new int[m, n];

        }
    }

}
