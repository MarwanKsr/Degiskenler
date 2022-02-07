using System;

namespace Degisken
{
    class program
    {
        static void Main(string[] args)
        {
            short sh1 = -5;
            ushort sh2 = 5;
            byte b1 = 6;
            sbyte b2 = -5;
            int i1 = -7;
            uint i2 = 7;
            long l1 = -8;
            ulong l2 = 8;

            Console.WriteLine(sh1);
            Console.WriteLine(sh2);
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(i1);
            Console.WriteLine(i2);
            Console.WriteLine(l1);
            Console.WriteLine(l2);

            string adi = "Marwan";
            string soyad = "Kaseer";
            Console.WriteLine(adi + " " + soyad);

            float j1 = 0.50f;
            double d1 = 2.5;
            decimal d2 = 3.5m;

            Console.WriteLine(j1);
            Console.WriteLine(d1);
            Console.WriteLine(d2);

            Console.WriteLine(DateTime.Now);

            string str =Convert.ToString(i1);
            string str1 = Convert.ToString(d1);

            Console.WriteLine(DateTime.Now.ToString("dd.MM.yyyy"));








        }
    }
}