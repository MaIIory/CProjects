using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex26_WorkflowEngine
{
    class StoreDataActivity : IRunnable
    {
        public void Execute()
        {
            Console.WriteLine("Store user data in database");
        }
    }
}
