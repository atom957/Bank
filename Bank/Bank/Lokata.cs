using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Lokata
    {
        public enum TypLokaty
        {
            NORMAL,
            PROGRESS
        }

        public double kwota { get; set; }
        public DateTime dataPoczatkowa { get; set; }
        public DateTime dataBiezaca { get; set; }
        public TypLokaty typLokaty { get; set; }
    }
}
