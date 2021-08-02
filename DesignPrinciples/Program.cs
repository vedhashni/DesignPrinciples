using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPrinciples.OpenClosedPrinciple;
using DesignPrinciples.LiskovSubstitutionPrinciple;
using DesignPrinciples.InterfaceSegregationPrinciple;


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

                case 2:
                    //LISKOV SUBSTITUITION PRINCIPLE
                    //Creting a instance for admindatafile class using interface
                    IFileWriter fileWriter = new AdminFiles();
                    fileWriter.WriteFile(@"C:\Users\ven\source\repos\DesignPrinciples\DesignPrinciples\LiskovSubstitutionPrinciple\AdminData.txt");

                    IFileReader fileReader = new AdminFiles();
                    fileReader.ReadFile(@"C:\Users\ven\source\repos\DesignPrinciples\DesignPrinciples\LiskovSubstitutionPrinciple\AdminData.txt");

                    IFileReader fileReaderR = new RegularFile();
                    fileReaderR.ReadFile(@"C:\Users\ven\source\repos\DesignPrinciples\DesignPrinciples\LiskovSubstitutionPrinciple\RegularData.txt");
                    break;

                case 3:
                    Console.WriteLine("*******HPLaser*******");
                    IPrintContent content = new LaserJet();
                    content.PrintContent();
                    IPrintDuplex printDuplex = new LaserJet();
                    printDuplex.PrintDuplexContent();
                    Console.WriteLine("*******Cannon*******");
                    IPrintContent content1 = new Cannon();
                    content1.PrintContent();
                    IPhotoCopyContent copyContent = new Cannon();
                    copyContent.PhotoCopyContent();
                    break;
            }
        }
    }
}
