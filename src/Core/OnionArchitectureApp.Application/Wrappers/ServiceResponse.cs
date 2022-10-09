using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureApp.Application.Wrappers
{
  public class ServiceResponse<T> : BaseResponse
  {
    public T Value { get; set; }

    public ServiceResponse(T value) : base(true, "Ok")
    {
      Value = value;
    }

    public ServiceResponse(T value, bool successStatus, string Message) : base(successStatus, Message)
    {
      Value = value;
    }
  }
}
