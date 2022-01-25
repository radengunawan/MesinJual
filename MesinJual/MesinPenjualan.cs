using System;

namespace MesinJual
{
    internal class MesinPenjualan
    {
        public virtual string Item { get; }
        
        protected  virtual bool cekBanyak(decimal v)
        {
            return false;
        }

        public string Keluarkan (decimal v)
        {
            if (v)
        }
    }
}