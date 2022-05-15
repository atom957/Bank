using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class BankAccountPremium: BankAccount
    {
        public override double withdraw(int percentage)
        {
            double baseAmount = base.withdraw(percentage);
            double e = (1.0 / 100.0) * baseAmount;
            double m = Math.Round(e,2);
            base.balance += m;
            return e;
        }
        public override double withdraw(double amount)
        {
            double baseAmount = base.withdraw(amount);
            double s = (1.0 / 100.0) * baseAmount;
            double m = Math.Round(s,2);
            base.balance += m;
            return s;
        }
        public override double transfer(double amount)
        {
            double baseAmount = base.transfer(amount);
            double s = (1.0 / 100.0) * baseAmount;
            double m = Math.Round(s,2);
            base.balance += m;
            return s;
        }
        public override double tranafer(int percentage)
        {
            double baseAmount = base.tranafer(percentage);
            double e = (1.0 / 100.0) * baseAmount;
            double m = Math.Round(e,2);
            base.balance += m;
            return e;
        }
    }
}
