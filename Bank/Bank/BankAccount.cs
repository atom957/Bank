using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class BankAccount
    {
        public Operations operations { get; set; }
        public double balance { get; set; }

        
        public BankAccount()
        {
            balance = 0;
            operations = new Operations();
        }
        public virtual double withdraw(double amount)
        {
            balance -= amount;
            operations.add("wypłata wyskokosci: " + amount + " balans: "+ balance);
            return amount;
        }
        public virtual double withdraw(int percentage)
        {
            double z = double.Parse(percentage.ToString()) / double.Parse("100") * balance;
            balance -= z;
            operations.add("wypłacono " + percentage + " procent" + " balans: " + balance);
            return z;
        }

        public virtual double transfer(double amount)
        {
            balance += amount;
            operations.add("wpłata wyskokosci: " + amount + " balans: " + balance);
            return amount;
        }
        public virtual double tranafer(int percentage)
        {
            double z = double.Parse(percentage.ToString()) / double.Parse("100") * balance;
            balance += z;
            operations.add("wpłacono " + percentage + " procent" + " balans: " + balance);
            return z;
        }
    }
}
