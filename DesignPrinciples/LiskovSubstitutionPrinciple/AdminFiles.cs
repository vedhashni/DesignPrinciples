using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DesignPrinciples.LiskovSubstitutionPrinciple
{
    class AdminFiles : IFileReader, IFileWriter
    {
        public void ReadFile(string filePath)
        {
            // Read File logic
            string adminPath = @"C:\Users\Radhika\source\repos\DesignPrinciples\AdminData.txt";
            string text = File.ReadAllText(adminPath);
            Console.WriteLine("\nData Successfully read from AdminData\n");
            Console.WriteLine(text);
        }

        public void WriteFile(string filePath)
        {
            //Write File Logic
            string adminWritePath = @"C:\Users\Radhika\source\repos\DesignPrinciples\AdminData.txt";
            using (StreamWriter writer = new StreamWriter(adminWritePath))
            {
                writer.WriteLine("UserName: Admin");
                writer.WriteLine("Password: test@123");
            }
            Console.WriteLine($"\nFile {filePath} has been written\n");

        }
    }
}
