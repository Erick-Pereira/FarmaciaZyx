using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Response
    {
        public Response(string message, bool hasSuccess)
        {
            Message = message;
            HasSuccess = hasSuccess;
        }

        public string Message { get; private set; }
        public bool HasSuccess { get; private set; }
    }
}
