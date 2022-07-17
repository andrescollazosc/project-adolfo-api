using SlnRestaurant.Core.Services.Contracts;
using SlnRestaurant.Core.Services.Entities;
using SlnRestaurant.Infrastructure.Data.Mocks;

namespace SlnRestaurant.Infrastructure.Data.Repositories;

public class OrderRepository : IGenericRepository<Order>
{
    public async Task<Order> CreateAsync(Order entity)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(Guid uId)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Order>> GetAllAsync()
    {
        return OrderMock.GetOrders().ToList();
    }

    public async Task<Order> GetByIdAsync(Guid uId)
    {
        var orderDb = OrderMock.GetOrders().FirstOrDefault(x => x.Id == uId);

        return orderDb ?? new Order();
    }

    public async Task<Order> UpdateAsync(Order entity)
    {
        throw new NotImplementedException();
    }

}
