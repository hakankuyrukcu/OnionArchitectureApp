using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitectureApp.Application.Interfaces.Repository;
using OnionArchitectureApp.Persistence.Context;
using OnionArchitectureApp.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureApp.Persistence
{
  public static class ServiceRegistration
  {
    public static void AddPersistanceRegistration(this IServiceCollection serviceCollection)
    {
      serviceCollection.AddDbContext<ApplicationDbContext>(opt => opt.UseInMemoryDatabase("memoryDb"));
      serviceCollection.AddTransient<IProductRepository, ProductRepository>();
    }
  }
}
