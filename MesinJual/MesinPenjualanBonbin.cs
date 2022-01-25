namespace MesinJual
{
    class MesinPenjualanBonbin : MesinPenjualan
    {
        //public virtual string Item { get; }
        
        public override string Item {
            get { return "a handful of animal feed"; }
        }

        //protected virtual bool cekBanyak(decimal duit)
        protected override bool cekBanyak(decimal duit)
        {
            return duit >= 1.25M;
        }

    }//END CLASS
}