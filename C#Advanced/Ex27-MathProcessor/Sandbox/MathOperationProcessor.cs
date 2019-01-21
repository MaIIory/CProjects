using System;

namespace MathProcessor
{
    public class MathOperationProcessor
    {
        //delegate handler, there is no custom delegate definiton
        public Action<float,float> MathOpHandler;

        //registration method
        public void AddOperation(Action<float,float> operation)
        {
            MathOpHandler += operation;
        }

        //unregistration method
        public void RemoveOperation(Action<float,float> operation)
        {
            MathOpHandler -= operation;
        }
    }
}
