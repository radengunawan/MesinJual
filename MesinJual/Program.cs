using System;

namespace MesinJual
{
    class Program
    {
        static void Main(string[] args)
        {
            MesinPenjualan j1 = new MesinPenjualanBonbin();
            Console.WriteLine(j1.Keluarkan(1.00M));
            //MesinPenjualan.cekBanyak(1F); <--protected
        }
    }
}
