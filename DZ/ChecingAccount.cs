using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    public class ChecingAccount
    {

        double m_balance;
        private string v;
        private double currentBalance;

        public ChecingAccount(string v, double currentBalance)
        {
            this.v = v;
            this.currentBalance = currentBalance;
        }

        public double Balance { get; set; }

        public void Withdraw(double amount)
        {
            if (m_balance >= amount)
            {
                m_balance -= amount;
            }
            else
            {
                throw new ArgumentException(nameof(amount), "Withdrawal exceeds balance!");
            }
        }
    }
}
