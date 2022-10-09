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

namespace OnionArchitectureApp.Application.Features.Queries.GetAllProducts
{
  public class GetAllProductQuery : IRequest<ServiceResponse<List<ProductDTO>>>
  {


    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductQuery, ServiceResponse<List<ProductDTO>>>
    {
      private readonly IProductRepository productRepository;
      private readonly IMapper mapper;

      public GetAllProductsQueryHandler(IProductRepository productRepository, IMapper mapper)
      {
        this.productRepository = productRepository;
        this.mapper = mapper;
      }


      public async Task<ServiceResponse<List<ProductDTO>>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
      {
        var products = await productRepository.GetAllAsync();
        var viewModel = mapper.Map<List<ProductDTO>>(products);

        return new ServiceResponse<List<ProductDTO>>(viewModel);
      }
    }
  }
}
