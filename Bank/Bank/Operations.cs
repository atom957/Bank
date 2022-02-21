using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Operations
    {
        public List<string> bankoper { get; }

        public Operations()
        {
            bankoper = new List<string>();
        }

        public void add(string i)
        {
            bankoper.Add(i);
        }
        public void show()
        {
            
        }
    }
}
