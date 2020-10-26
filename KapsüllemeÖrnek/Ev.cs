using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsüllemeÖrnek
{
    class Ev
    {
        private string semt;
        public string Semt
        {
            get { return semt; }

            set { semt = value.ToUpper(); }
        }

        private int odasayisi;
        public int OdaSayisi
        {
            get { return odasayisi; }
            set { odasayisi = Math.Abs(value); }
        }

        private int kat;
        public int Kat
        {
            get { return kat; }
            set { kat = Math.Abs(value); }
        }

        private int alan;
        public int Alan
        {
            get { return alan; }
            set { alan = Math.Abs(value); }
        }


    }
}
