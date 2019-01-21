using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProcessor
{
    class Program
    {

        static void Main(string[] args)
        {
            float x = 5;
            float y = 6;

            var mathProcessor = new MathOperationProcessor();
            mathProcessor.AddOperation(MathOperations.Add);
            mathProcessor.AddOperation(MathOperations.Substract);
            mathProcessor.AddOperation(MathOperations.Multiply);
            mathProcessor.AddOperation(MathOperations.Divide);

            mathProcessor.MathOpHandler(x, y);
            /* Pros:
             * 1. MathOperations class is easily extensible
             * 2. MathOperationsProcessor and MathOperations are loosely coupled
             * */
        }
    }
}
