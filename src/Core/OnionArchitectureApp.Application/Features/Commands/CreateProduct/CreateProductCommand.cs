using AutoMapper;
using MediatR;
using OnionArchitectureApp.Application.Interfaces.Repository;
using OnionArchitectureApp.Application.Wrappers;
using OnionArchitectureApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureApp.Application.Features.Commands.CreateProduct
{
  public class CreateProductCommand : IRequest<ServiceResponse<Guid>>
  {
    public String Name { get; set; }
    public Decimal Value { get; set; }
    public int Quantity { get; set; }



    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ServiceResponse<Guid>>
    {
      private readonly IProductRepository productRepository;
      private readonly IMapper mapper;

      public CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
      {
        this.productRepository = productRepository;
        this.mapper = mapper;
      }

      public async Task<ServiceResponse<Guid>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
      {
        var product = mapper.Map<Product>(request);
        await productRepository.AddAsync(product);
        return new ServiceResponse<Guid>(product.Id);
      }
    }
  }
}
