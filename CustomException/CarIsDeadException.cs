using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomException
{
    [Serializable]
    public class CarIsDeadException : ApplicationException
    {
        public CarIsDeadException() { }

        public CarIsDeadException(string message) : base(message) { }

        public CarIsDeadException(string message, System.Exception inner) : base(message) { }

        public CarIsDeadException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }

    }
}
