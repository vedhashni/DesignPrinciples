using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.InterfaceSegregationPrinciple
{
    public interface IPrintContent
    {
        void PrintContent();
    }
    public interface IPhotoCopyContent
    {
        void PhotoCopyContent();
    }
    public interface IPrintDuplex
    {
        void PrintDuplexContent();
    }
}
