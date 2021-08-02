using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class Task
    {
        //Declaring getter and setter methods
        
            public int TaskId { get; set; }
            public string Content { get; set; }
            public DateTime ExecuteOn { get; set; }
        
    }
}
