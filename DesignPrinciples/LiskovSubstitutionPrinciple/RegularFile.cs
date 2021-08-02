using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DesignPrinciples.LiskovSubstitutionPrinciple
{
    class RegularFile : IFileReader
    {
        public void ReadFile(string filePath)
        {
            // Read File logic    

            string regularData = @"C:\Users\ven\source\repos\DesignPrinciples\DesignPrinciples\LiskovSubstitutionPrinciple\RegularData.txt";
            string[] lines = File.ReadAllLines(regularData);
            Console.WriteLine("\nData Successfully read from RegularData\n");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
