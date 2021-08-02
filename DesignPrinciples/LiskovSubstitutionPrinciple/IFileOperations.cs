using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.LiskovSubstitutionPrinciple
{
    public interface IFileReader
    {
        void ReadFile(string filePath);
    }
    public interface IFileWriter
    {
        void WriteFile(string filePath);
    }
}
