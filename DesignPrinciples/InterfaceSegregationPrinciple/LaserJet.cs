using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.InterfaceSegregationPrinciple
{
    public class LaserJet : IPrintContent, IPrintDuplex
    {
        public void PrintContent()
        {
            Console.WriteLine("\nPrint Content Data of HPLaser");
        }
        public void PrintDuplexContent()
        {
            Console.WriteLine("\nPrint Duplex Content Data of HPLaser");
        }
    }
}
