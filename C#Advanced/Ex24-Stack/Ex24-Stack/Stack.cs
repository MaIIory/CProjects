using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex24_Stack
{
    class Stack
    {
        private readonly List<object> _stack = new List<object>();

        public void Push(object obj)
        {
            if (obj is null)
                throw new InvalidOperationException("Null can't be stored on the stack.");

            _stack.Add(obj);
        }

        public object Pop()
        {
            if (_stack.Count <= 0)
                throw new InvalidOperationException("Stack is empty.");

            var result = _stack[_stack.Count-1];
            _stack.RemoveAt(_stack.Count-1);
            return result;
        }

        public void Clear()
        {
            _stack.Clear();
        }
    }
}
