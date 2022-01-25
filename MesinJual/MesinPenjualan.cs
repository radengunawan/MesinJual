using System;

namespace MesinJual
{
    class MesinPenjualan
    {
        public virtual string Item { get; }
        
        protected virtual bool cekBanyak(decimal duit)
        {
            return false;
        }

        public string Keluarkan (decimal duit)
        {
            if (cekBanyak(duit)) return Item;
            else
            {
                return "Enter right amount";
            }
        }

    } // END class
}// END namespace