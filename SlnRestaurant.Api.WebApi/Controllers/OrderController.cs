using Microsoft.AspNetCore.Mvc;
using SlnRestaurant.Core.Services.Contracts;
using SlnRestaurant.Core.Services.Entities;
using System.Collections;

namespace SlnRestaurant.Api.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrderController : ControllerBase
{
    private readonly IGenericRepository<Order> _orderRepository;

    public OrderController(IGenericRepository<Order> orderRepository)
    {
        _orderRepository = orderRepository;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Order>>> GetAll()
    {
        try
        {
            return Ok(_orderRepository.GetAllAsync().GetAwaiter().GetResult());
        }
        catch (Exception ex)
        {
            return BadRequest();
        }
    }

    [HttpGet("{orderUid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<Order>> GetById(Guid orderUid)
    {
        try
        {
            var order = _orderRepository.GetByIdAsync(orderUid);

            if (order is null)
                return BadRequest();

            return Ok(order);
        }
        catch (Exception ex)
        {
            return BadRequest();
        }
    }

}
