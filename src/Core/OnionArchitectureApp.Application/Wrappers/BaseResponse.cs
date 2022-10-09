using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureApp.Application.Wrappers
{
  public class BaseResponse
  {
    public Guid Id { get; set; }
    public bool SuccessStatus { get; set; }
    public String Message { get; set; }

    public BaseResponse()
    {
      Id = Guid.NewGuid();
    }

    public BaseResponse(bool successStatus) : this()
    {
      SuccessStatus = successStatus;
    }

    public BaseResponse(bool successStatus, string message) : this()
    {
      SuccessStatus = successStatus;
      Message = message;
    }
  }
}
