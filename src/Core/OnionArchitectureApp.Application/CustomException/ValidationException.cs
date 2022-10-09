﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureApp.Application.CustomException
{
  public class ValidationException : Exception
  {
    public ValidationException() : base("Validation Error Occured")
    {
    }

    public ValidationException(string Message) : base(Message)
    {

    }

    public ValidationException(Exception ex) : this(ex.Message)
    {

    }
  }
}
