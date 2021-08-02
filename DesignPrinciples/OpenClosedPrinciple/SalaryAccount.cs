using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.OpenClosedPrinciple
{
    public class SalaryAccount : IAccount
    {
        double interest, balance = 30000;
        public void CalculateInterest()
        {
            interest = balance * 0.5;
            Console.WriteLine("Interest Amount for Salary Saving Account : {0}\n", interest);
        }
    }
}
