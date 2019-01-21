using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex26_WorkflowEngine
{
    class Workflow
    {
        public List<IRunnable> Steps { get; private set; }

        public Workflow()
        {
            Steps = new List<IRunnable>();
        }

        public Workflow(List<IRunnable> steps)
        {
            Steps = steps;
        }

        public virtual void AddStep(IRunnable activity)
        {
            Steps.Add(activity);
        }

    }
}
