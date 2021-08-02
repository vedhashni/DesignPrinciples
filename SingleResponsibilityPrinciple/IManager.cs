using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    //Interface
    public class IManager<T>
    {
        public void AddEntry(T entry) { }
        public void RemoveEntryAt(int index) { }
    }
}
