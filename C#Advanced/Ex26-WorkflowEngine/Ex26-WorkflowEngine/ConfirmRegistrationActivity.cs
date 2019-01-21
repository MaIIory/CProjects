using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex26_WorkflowEngine
{
    class ConfirmRegistrationActivity : IRunnable
    {
        public void Execute()
        {
            Console.WriteLine("Send registration confirmation to a user");
        }
    }
}
