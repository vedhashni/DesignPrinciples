using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.InterfaceSegregationPrinciple
{
    public class Cannon : IPrintContent, IPhotoCopyContent
    {
        public void PrintContent()
        {
            Console.WriteLine("\nPrint Content Data of Cannon210");
        }
        public void PhotoCopyContent()
        {
            Console.WriteLine("\nPrint Copy Content Data of Cannon210");
        }
    }
}
