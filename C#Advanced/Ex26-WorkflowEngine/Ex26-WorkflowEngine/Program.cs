using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex26_WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {

            var newUserAdditionSequence = new List<IRunnable>
            {
                new DataFetchActivity(),
                new ValidateDataActivity(),
                new StoreDataActivity(),
                new ConfirmRegistrationActivity()
                
            };
            var newUserAdditionWorkflow = new Workflow(newUserAdditionSequence);
            WorkflowEngine.Run(newUserAdditionWorkflow);

        }
    }
}
