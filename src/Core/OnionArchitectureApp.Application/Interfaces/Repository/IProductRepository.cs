using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionArchitectureApp.Domain.Entities;

namespace OnionArchitectureApp.Application.Interfaces.Repository
{
  public interface IProductRepository : IGenericRepositoryAsync<Product>
  {
    
  }
}
