using SlnRestaurant.Core.Services.Contracts;
using SlnRestaurant.Core.Services.Entities;

namespace SlnRestaurant.Infrastructure.Data.Repositories;

public class TableRepository : IGenericRepository<Table>
{
    public Task<Table> CreateAsync(Table entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid uId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Table>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Table> GetByIdAsync(Guid uId)
    {
        throw new NotImplementedException();
    }

    public Task<Table> UpdateAsync(Table entity)
    {
        throw new NotImplementedException();
    }
}
