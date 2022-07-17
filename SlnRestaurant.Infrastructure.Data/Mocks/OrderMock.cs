using SlnRestaurant.Core.Services.Entities;

namespace SlnRestaurant.Infrastructure.Data.Mocks;

public class OrderMock
{
    private static Guid _orderId = Guid.Parse("12e0fc72-d564-4b19-bddb-1619ff6f605b");

    public static IEnumerable<Order> GetOrders()
    {
        var orders = new List<Order>();
        orders.Add(new Order { Id = Guid.NewGuid(), StartDate = DateTime.Now, TotalValue = 450000, Products = GetProducts() });
        orders.Add(new Order { Id = _orderId, StartDate = DateTime.Now, TotalValue = 250000, Products = GetProducts() });

        return orders;
    }

    private static IDictionary<Guid, double> GetProducts() { 
        var products = new Dictionary<Guid, double>();
        products.Add(Guid.NewGuid(), 35000);
        products.Add(Guid.NewGuid(), 25000);
        products.Add(Guid.NewGuid(), 15000);

        return products; 
    }


}
