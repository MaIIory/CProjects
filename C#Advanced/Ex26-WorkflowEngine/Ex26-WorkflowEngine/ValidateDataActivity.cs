using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex26_WorkflowEngine
{
    class ValidateDataActivity : IRunnable
    {
        public void Execute()
        {
            Console.WriteLine("Validate user data");
        }
    }
}
