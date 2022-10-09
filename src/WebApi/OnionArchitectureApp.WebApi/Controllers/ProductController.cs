using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionArchitectureApp.Application.DTO;
using OnionArchitectureApp.Application.Features.Commands.CreateProduct;
using OnionArchitectureApp.Application.Features.Queries.GetAllProducts;
using OnionArchitectureApp.Application.Features.Queries.GetProductById;
using OnionArchitectureApp.Application.Interfaces.Repository;

namespace OnionArchitectureApp.WebApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ProductController : ControllerBase
  {
    private readonly IMediator mediator;

    public ProductController(IMediator mediator)
    {
      this.mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
      var query = new GetAllProductQuery();
      return Ok(await mediator.Send(query));
    }

    [HttpGet("{Id}")]
    public async Task<IActionResult> GetById(Guid Id)
    {
      var query = new GetProductByIdQuery() { Id = Id };
      return Ok(await mediator.Send(query));
    }

    [HttpPost]
    public async Task<IActionResult> Post(CreateProductCommand command)
    {
      return Ok(await mediator.Send(command));
    }
  }
}
