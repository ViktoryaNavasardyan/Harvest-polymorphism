using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Polymorphism.Model
{
    public class NotSupportedInterfaceException : Exception
    {
        public NotSupportedInterfaceException() { }
        public NotSupportedInterfaceException(string message) : base(message) { }
        public NotSupportedInterfaceException(string message, Exception inner) : base(message, inner) { }
        protected NotSupportedInterfaceException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
