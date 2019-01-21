using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex26_WorkflowEngine
{
    class WorkflowEngine
    {
        public static void Run(Workflow workflow)
        {
            Console.WriteLine("Starting workflow:");
            foreach (var step in workflow.Steps)
                step.Execute();
        }
    }
}
