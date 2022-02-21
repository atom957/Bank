using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Controller2
    {
        public bool sprawdzanie { get; set; }
        public bool sprawdzanieStankonta { get; set; }
        public bool sprawdzanieOkno { get; set; }
        public Controller2()
        {
            sprawdzanie = false;
            sprawdzanieStankonta = false;
            sprawdzanieOkno = false;
        }
    }
}
