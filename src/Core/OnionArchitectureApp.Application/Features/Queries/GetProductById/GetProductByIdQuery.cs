using AutoMapper;
using MediatR;
using OnionArchitectureApp.Application.DTO;
using OnionArchitectureApp.Application.Interfaces.Repository;
using OnionArchitectureApp.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureApp.Application.Features.Queries.GetProductById
{
  public class GetProductByIdQuery : IRequest<ServiceResponse<GetProductByIdDTO>>
  {
    public Guid Id { get; set; }


    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ServiceResponse<GetProductByIdDTO>>
    {
      private readonly IProductRepository productRepository;
      private readonly IMapper mapper;

      public GetProductByIdQueryHandler(IProductRepository productRepository, IMapper mapper)
      {
        this.productRepository = productRepository;
        this.mapper = mapper;
      }

      public async Task<ServiceResponse<GetProductByIdDTO>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
      {
        var product = await productRepository.GetByIdAsync(request.Id);
        var result = mapper.Map<GetProductByIdDTO>(product);
        return new ServiceResponse<GetProductByIdDTO>(result);
      }
    }
  }
}
