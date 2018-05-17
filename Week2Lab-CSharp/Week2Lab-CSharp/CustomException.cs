using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lab_CSharp
{
    class CustomException : Exception
    {
        public string Message {get; set;}
        public CustomException(string message)
        {
            Message = message;
        }
    }
}
