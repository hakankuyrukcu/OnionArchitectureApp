using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureApp.Application.Parameters
{
  public class RequestParameter
  {
    public int Pagesize { get; set; }
    public int PageNumber { get; set; }

    public RequestParameter(int pagesize, int pageNumber)
    {
      Pagesize = pagesize;
      PageNumber = pageNumber;
    }
  }
}
