using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App18_SimpleException
{
    //The exception created with 'exception' snippet
    [Serializable]
    public class CarExplodedException : Exception
    {
        public CarExplodedException() { }
        public CarExplodedException(string message) : base(message) { }
        public CarExplodedException(string message, Exception inner) : base(message, inner) { }
        protected CarExplodedException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

}
