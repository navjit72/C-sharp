﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem
{
    class CustomMadeException : Exception
    {
        public override string Message { get; }
        public CustomMadeException(string message)
        {
            Message = message;
        }
    }
}
