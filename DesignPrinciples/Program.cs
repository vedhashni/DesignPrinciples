using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPrinciples.OpenClosedPrinciple;


namespace DesignPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design Principles");

            int option = Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:

                    SavingAccount regularSaving = new SavingAccount();
                    regularSaving.CalculateInterest();
                    SalaryAccount salarySaving = new SalaryAccount();
                    salarySaving.CalculateInterest();
                    break;
            }
        }
    }
}
