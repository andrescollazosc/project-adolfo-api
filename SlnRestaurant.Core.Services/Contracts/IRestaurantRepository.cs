namespace SlnRestaurant.Core.Services.Contracts;

public interface IRestaurantRepository
{
    Task<bool> Create();
    Task<bool> Delete();
    Task<bool> Update();
}
