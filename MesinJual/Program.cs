using System;

namespace MesinJual
{
    class Program
    {
        static void Main(string[] args)
        {
            MesinPenjualan j1 = new MesinPenjualanBonbin();
            Console.WriteLine(j1.Keluarkan(2.00M));
        }
    }
}
