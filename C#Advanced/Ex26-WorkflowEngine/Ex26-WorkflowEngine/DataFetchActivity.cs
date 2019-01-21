using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex26_WorkflowEngine
{
    class DataFetchActivity : IRunnable
    {
        public void Execute()
        {
            Console.WriteLine("Fetch user data to the system");
        }
    }
}
