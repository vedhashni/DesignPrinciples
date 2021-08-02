using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.SS.Formula.Functions;

namespace SingleResponsibilityPrinciple
{
    public class Scheduler : IManager<Task>
    {
        //Declaring a list
        private List<Task> scheduleTasks;
        //Constructor
        public Scheduler()
        {
            scheduleTasks = new List<Task>();
        }
        //ADDENTRY--->To add te data in list
        public new void AddEntry(Task entry)
        {
            scheduleTasks.Add(entry);
        }
        //REMOVEENTRY---->Remove the index using lambda expression
        public new void RemoveEntryAt(int index) =>
            scheduleTasks.RemoveAt(index);

        public override string ToString() =>
       string.Join(Environment.NewLine, scheduleTasks.Select(x => $"Task with id: {x.TaskId} with content: {x.Content} is going to be executed on: {x.ExecuteOn}"));
    }
}
