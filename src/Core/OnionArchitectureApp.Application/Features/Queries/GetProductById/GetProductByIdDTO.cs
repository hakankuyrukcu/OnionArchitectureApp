﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureApp.Application.Features.Queries.GetProductById
{
  public class GetProductByIdDTO
  {
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }

    public String Name { get; set; }
    public Decimal Value { get; set; }
    public int Quantity { get; set; }
  }
}
